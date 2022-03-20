# .NET Project Template

This is a repository template for a modern, enterprise-level .NET project.  Notable features include:
- Properties are centrally managed via `Directory.Build.props`
- NuGet Packages are centrally managed via `Packages.props`
- MSBuild SDKs are used customize the build process
- The project hierarchy is expressed with `dirs.proj` traversal projects
- VS Solution Files are not committed to the repository
## Prerequisites

- [ ] Download the [.NET SDK](https://dotnet.microsoft.com/en-us/download)

## Getting Started

- [ ] Update SDK versions in `global.json`
- [ ] Update NuGet package versions in `Packages.props`
- [ ] (Optional) Install the `slgen` tool

## Build and Test

Use the .NET CLI to build and test:

```
> dotnet build
> dotnet test
```

## Using Visual Studio

We do not check in VS solution files (`*.sln`). These can be generated on the fly with the [slngen](https://github.com/microsoft/SlnGen#getting-started---net-core-global-tool-recommended) tool instead:

```
> slngen --folders true --collapsefolders true
```