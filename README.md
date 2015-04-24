[![Build status](https://ci.appveyor.com/api/projects/status/ufrmo018fhqr7s8r?svg=true&passingText=I%20have%20time%20to%20do%20ya%20mom%20instead%20of%20fixing%20code)](https://ci.appveyor.com/project/kasthack/vksharp)

=======


###Installation
```PowerShell
Install-Package kasthack.vksharp
```


###Usage

1. Create VKApi instanse
	```C#
	var api = new VKApi();
	```
2. Get token URL
	```C#
	VKToken.GetOAuthURL( APP_KEY, PERMISSIONS );
	```
3. Make token from response
	```C#
	var token = VKToken.FromRedirectUrl( REDIRECT_URL );
	```
4. Add to Api
	```C#
	api.AddToken(token);
	```
5. Enjoy



### Implemented methods
Lurk Sources/VKSharp/Api/Generated/ImplementedMethods.txt