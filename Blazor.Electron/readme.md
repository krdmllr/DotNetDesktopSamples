# Blazor + Electron sample

The blazor + electron sample shows how to ship a Blazor server side application inside electron as a native desktop application across windows, macos and linux.

Instead of using the ElectronJs library directly, the sample takes adventage of the Electron.NET library which provides tooling, startup and wrapper methods to be used with ASP.NET Core. You can learn more about Electron.NET and on how to set up the project ehre https://github.com/ElectronNET/Electron.NET.

# Running the sample

Running the sample requires the installation of the .NET Core SDK 3.1.3 (3.1.201) https://dotnet.microsoft.com/download/dotnet-core/3.1

ElectronNET provides a global dotnet tool to initialize and start the application, it can be installed using the following command:
```
dotnet tool install ElectronNET.CLI -g
````
Since the project is already setup and initialized, you can start it up immediately using
```
electronize start
```