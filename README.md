# kasthack.vksharp


[![Nuget](https://img.shields.io/nuget/v/kasthack.vksharp.svg)](https://www.nuget.org/packages/kasthack.vksharp/)
[![Build status](https://img.shields.io/appveyor/ci/kasthack/vksharp.svg)](https://ci.appveyor.com/project/kasthack/vksharp)
[![License](LICENSE.txt)](https://img.shields.io/badge/license-LGPL-green.svg)
[![Join the chat at https://gitter.im/kasthack/VKSharp](https://img.shields.io/gitter/room/kasthack/VKSharp.js.svg)](https://gitter.im/kasthack/VKSharp?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)


### Installation
```PowerShell
Install-Package kasthack.vksharp
```

## Docs

### Supported platforms

* .NET
    * 4.0
    * 4.5
    * 4.6
* Mono
    * Anything 4.0+ compatible. I've used 4.2 successfully.
* Xamarin
    * 4.* profile. PCL is not supported yet. Use shared project if you are building a cross-platform forms app.

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
