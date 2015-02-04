Добавление методов
=======

Все методы описаны в Api/Generated/VkSharpFuncs.xml

Описание метода:

```xml
<Method Name="<Имя метода>">
    <Request
		Type="<!--Тип ответа, который вернёт ВК-->"
		NeedToken="<--Использовать токен(true/false)-->"
		Parse="<!--True - отдать parsed объект, false - просто вернуть таск-->" />
    <Params>
		<!--Список параметров-->
		<Param
			Name="<!--имя параметра-->"
			Type="<!--тип параметра-->"
			Default="<!--Дефолтное значение. Если его нет, то атрибут не указывать-->"
			Custom="<!--Своё преобразование к строке с бледжеком и шлюхами. #name будет заменено на имя переменной.-->"/>
    </Params>
</Method>
```

Добавление метода в код:

* Редактируем VkSharpFuncs.xml
* По очереди прогоняем  SortMethods.tt, RequestApi.tt, RawApi.tt, VkApi.tt, ImplementedMethods.tt
* ???
* Profit