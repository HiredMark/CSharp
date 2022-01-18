C# version 10.0 added manually to .csproj
.Net core  4.6.2 
.Net SDK 4.6.2 installed manually
Packages that need to be isntalled: 
Microsoft.CrmSdk.CoreAssemblies
Microsoft.Net.Http



Sample codesnippet for .csproj file 

```
 <PropertyGroup>
    <TargetFramework>net462</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
	<LangVersion>10.0</LangVersion>
  </PropertyGroup>
```
