# kasthack.vksharp


[![Build status](https://ci.appveyor.com/api/projects/status/ufrmo018fhqr7s8r?svg=true&passingText=I%20have%20time%20to%20do%20ya%20mom%20instead%20of%20fixing%20code)](https://ci.appveyor.com/project/kasthack/vksharp)


[![Join the chat at https://gitter.im/kasthack/VKSharp](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/kasthack/VKSharp?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)


### Installation
```PowerShell
Install-Package kasthack.vksharp
```

## Docs

### Usage

1. Register app at https://vk.com/editapp?act=create

2. Get OAuth authorize uri

    ```C#
    var redirect_uri = Token.GetOAuthURL(
        APP_ID,     // APP ID: shown on app's properties page
        PERMISSIONS // Permissions: VKPermission.*, something like VKPermission.Offline | VKPermission.Photos
    );
    ```

3. Show authorization page to user.

4. Build token from redirect uri.

    ```C#
    var token = Token.FromRedirectUrl( REDIRECT_URL );
    ```

5. Use token 

    ```C#
    var api = new Api();
    api.AddToken(token);
    ```

6. Execure requests
    ```C#
    var users = await api.Users.Get(1);
    ```
7. ???
8. Profit

### Implemented methods
Lurk [here](Sources/kasthack.vksharp/Shared/Generated/ImplementedMethods.md)
### Contributing
[Contributing guide(in Russian)](Contributing.ru.md)