NuGet pack ..\Sources\kasthack.vksharp\kasthack.vksharp.csproj -Prop Configuration=Release -IncludeReferencedProjects
Nuget Push kasthack.vksharp.*.nupkg
del kasthack.vksharp.*.nupkg
pause