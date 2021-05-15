THIS REPOSITORY IS CURRENTLY IN A WORK IN PROGRESS STATE, THIS IS NOT READY FOR GENERAL USE YET.

# Bug-Fables-Entity-Editor
An entity editor for the game [Bug Fables: The Everlasting Sapling](https://store.steampowered.com/app/1082710/Bug_Fables_The_Everlasting_Sapling/) made in .NET 5. 

This program is supported on Windows and Linux. It uses the [Avalonia UI](http://avaloniaui.net/) framework which offers a rich UI and many features to make developing very comfortable for WPF and .NET developers.

## System Requirements
The only requirement is to have the .NET runtime installed. For Windows, you can install the latest version of .NET by following [this link](https://dotnet.microsoft.com/download) (note, you ideally want to install .NET, not .NET Core or .NET Framework). For Linux, refer to your distribution's documentation for proper installation of the runtime.

## How to Build
This section is intended ***only for developers***. You do not need to do this if you only want to use the program. Refer to the ***Installation*** section for this purpose.

### Microsoft Windows
This repository provides a solution file for Visual Studio 2019 and later. Your Visual Studio must have the .NET components installed including the .NET SDK.

Open the solution file `BugFablesDataEditor.sln` located in the root directory with Visual Studio. Select the build configuration and build it.

Alternatively, you may use the dotnet SDK command line tools or any other IDE that supports .NET 5 such as Visual Studio Code.

### Linux
> _The .NET 5 SDK is required. Please refer to your distribution's documentation for specific instructions on how to install it._

To build, simply run the following command from the root directory:

	dotnet build BugFablesDataEditor.csproj

The compiled binaries should appear in the directory named `bin`.

## License
This program is licensed under the MIT license which grants you the permission to do anything you wish to with the software, as long as you preserve all copyright notices. (See the file LICENSE for the legal text.). That being said, this project contains assets from the game meaning it cannot be distributed for commercial purposes. This project is not affiliated with Moonsprout Games.

## Special Thanks
I would like to thank everyone from Moonsprout Games for making this amazing game as it brought inspiration to me and to everyone in the community it sparked.
