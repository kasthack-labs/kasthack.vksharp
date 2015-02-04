VKSharp [![Flattr this git repo](http://api.flattr.com/button/flattr-badge-large.png)](https://flattr.com/submit/auto?user_id=kasthack&url=https://github.com/kasthack/VKSharp&title=VKSharp&language=&tags=github&category=software)
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