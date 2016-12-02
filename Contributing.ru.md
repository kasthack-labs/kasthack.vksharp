# Контрибьютинг & внутреннее устройство

//Мне было лень писать гайд по контрибьютингу на английском

## Как оно работает

Для использования нормальными людьми задуманы целых две версии апи:

* Api - принимает параметры, отдаёт объекты
* RawApi - принимает такие же параметры, но плюется json-строками.

Обработка запроса происходит примерно так:

1. Дёргается метод Api/RawApi
2. Api/RawApi вызывает аналогичный метод у RequestApi, получая сформированный запрос(vkrequest<T>).
3. Запрос передаётся Executor'у в ExecAsync/ExecRawAsync
4. Executor(на данный момент это [JsonExecutor](Sources/kasthack.vksharp/Shared/Implementation/JsonExecutor.cs)) строит HTTP-запрос по VKRequest'у и выполняет его.
5. Если был вызван ExecRawAsync, Executor возвращает полученные данные в виде строке без обработки.
6. Executor десериализует полученные данные.
7. Если свойство Error отлично от null, бросается исключение.
8. Наружу возвращаются десериализованные данные.

## Добавление методов

### Методы

Все методы API описаны в [Sources/kasthack.vksharp/Generated/Methods.xml](Sources/kasthack.vksharp/Shared/Generated/Methods.xml). Формат описан в [соответствующем XSD](Sources/kasthack.vksharp/Shared/Generated/Methods.xsd). Автокомплит в студии иногда отваливается, но проблема на их стороне.

Пример описания метода:

```XML
<Method
    Name="friends.get"              <!--Имя метода-->

    Type="EntityList&lt;int&gt;"    <!--Возвращаемый тип.
            Если в доках сказано, что возвращается "response:1", следует писать void.-->
    NameSuffix="Satan"              <!--Кастомный суффикс для разрешения конфликтов между методами с разными hardcoded params-->
    NeedToken="false"           <!--Необходима ли авторизация для вызова-->

    Pageable="100"              <!--[Опциональный] Добавляет параметры offset и count.
           Значение параметра будет дефолтным значением count-->
>
<Doc>
  <Summary>
    <!--описание метода для xml-документации-->
  </Summary>
</Doc>
<Params>                        <!--Параметры-->
    <Param
           Name="user_id"       <!--Имя параметра. Писать в том виде, как в ВК.
           Генератор сам приведёт к camelCase в коде.-->

           Type="int?"          <!--Тип-->

           Default="null"       <!--[Опциональный] Дефолтное значение-->
           Doc="id пользователя"/>    <!--данные для xml-документации-->

           <!--Custom -- cвоё преобразование к строке с бледжеком и шлюхами.
                #name будет заменено на имя переменной.
                Стандартные преобразования описываются в SharedFuncs.tt-->

    <Param Name="list_id" Type="int?" Default="null" />
    <Param Name="order" Type="UserSortOrder" Default="UserSortOrder.ById" />

            <!--Если последний параметр является массивом, он автоматически станет params-->
</Params>
<Hardcoded>
<!--
Захардкоженные параметры.
Параметры, которые невидимы для юзера(тот, который юзер либы, а не end user), но будут добавлены в запрос.
Применение: методы, которые при разных значениях параметра отдают данные в разных форматах.
Пример: users.get, который отдаёт список интов, если параметр fields пуст и
массив юзеров, если там есть любое значение(включая невалидные)
-->
    <HardcodedParam Name="fields" Value=""/>
</Hardcoded>
</Method>
```

Исходный код и список готовых методов генерируется из него T4-шаблонами из той же папки:

* [RequestApi.tt](Sources/kasthack.vksharp/Shared/Generated/RequestApi.tt) - реквесты
* [RawApi.tt](Sources/kasthack.vksharp/Shared/Generated/RawApi.tt) - сырое апи
* [Api.tt](Sources/kasthack.vksharp/Shared/Generated/Api.tt) - апи с объектами
* [ImplementedMethods.tt](Sources/kasthack.vksharp/Shared/Generated/ImplementedMethods.tt) - список готовых методов

Студия запускает генератор при сохранении шаблона.

### Типы

* Файлы с исходниками лежат в /ReturnTypes/, но имеют неймспес VKSharp.Core.*
* Имена свойств/энамов пишутся в стандартном CamelCase - сериализатор автоматически преобразует из snake_case, в котором отдаёт ВК.
