# Bug-Fables-Entity-Editor
<p align="center">
  <img src="https://raw.githubusercontent.com/aldelaro5/Bug-Fables-Entity-Editor/master/Assets/icon.ico" />
  <br />
  Icon by	<a href="https://github.com/CerisWhite">Ceris</a> from modified in-game asset
  <br />
  <img src="https://raw.githubusercontent.com/aldelaro5/Bug-Fables-Entity-Editor/master/Docs/Screenshot.png">
</p>

An entity editor for the game [Bug Fables: The Everlasting Sapling](https://store.steampowered.com/app/1082710/Bug_Fables_The_Everlasting_Sapling/) made in .NET 5. It supports the consultation and modification of all fields of every entities in the game.

This program is supported on Windows and Linux. It uses the [Avalonia UI](http://avaloniaui.net/) framework which offers a rich UI and many features to make developing very comfortable for WPF and .NET developers.

## Features
- Supports modification of all the entities fields
- Allows to quickly apply or remove any name modifiers of an entity
- Allows to save all modifications to a directory of the entities data
- No need to consult very complex looking text files with lots of closing curly braces

## System Requirements
The only requirement is to have the .NET runtime installed. For Windows, you can install the latest version of .NET by following [this link](https://dotnet.microsoft.com/download) (note, you ideally want to install .NET, not .NET Core or .NET Framework). For Linux, refer to your distribution's documentation for proper installation of the runtime.

## Installation
Simply download the latest zip from [the release page](https://github.com/aldelaro5/Bug-Fables-Entity-Editor/releases) that corresponds to your OS. To launch it, launch the executable inside the zip. This is a portable software, its directory can be moved and placed wherever you want.

## General Usage
When launched, the program presents multiple tabs corresponding to each section of the entity data. 

You must either open an existing entity data directory. Once done, you may select a map and its entity to consult and edit its information. You may also add a new entity to the current map. When editing an entity's name, you are able to quickly apply or remove any name modifiers.

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
