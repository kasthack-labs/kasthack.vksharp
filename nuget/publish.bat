NuGet pack ..\Sources\VKSharp\VKSharp.csproj -Prop Configuration=Release -IncludeReferencedProjects
Nuget Push kasthack.vksharp.*.nupkg
del kasthack.vksharp.*.nupkg
pause