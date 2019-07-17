# HTML Character Code Acquisition Program
Developer tool to look up HTML character codes/HTML character entities. HTML Character Code Acquisition Program is also known as "html-ccap".

| Overall project status | Master branch status |
|------------------------------------------------------------------------|----------------------------|
| [![Project build status](https://ci.appveyor.com/api/projects/status/qekkf6yq173eybn4?svg=true)](https://ci.appveyor.com/project/DrewNaylor/html-character-code-acquisition-program) | [![Master branch Build status](https://ci.appveyor.com/api/projects/status/qekkf6yq173eybn4/branch/master?svg=true)](https://ci.appveyor.com/project/DrewNaylor/html-character-code-acquisition-program/branch/master) |

Screenshot:<br>
![](/docs/images/html-ccap_search-screenshot.png?raw=true)

Copyright notice:

```
HTML Character Code Acquisition Program - Developer tool to look up HTML
character codes/HTML character entities.
Copyright (C) 2019 Drew Naylor
(Note that the copyright years include the years left out by the hyphen.)

This file is part of HTML Character Code Acquisition Program
(Program is also known as "html-ccap".)

html-ccap is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

html-ccap is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with html-ccap.  If not, see <http://www.gnu.org/licenses/>.
```

## Features to add

- Search when typing (if the user wants it that way)
  - GUI configuration is needed, but this can be changed in the config file.
  - Is enabled when `My.Settings.searchWhenTyping` is set to `True`.
- Search on Enter (if the user wants it to work like that instead of when typing)
  - Needs to be added to a GUI, but already in the config file like Search when typing.
  - Is enabled when `My.Settings.searchWhenTyping` is set to `False`.
- An option to hide the Search button if the user wants to
  - Can already be done from the config file.
  - Search button is hidden when `My.Settings.showSearchButton` is set to `False`.
- Updating the XML file from the Options window.
- Functionality for the menubar items, like File\Exit, Tools\Options, and Help\About.
- The Options window looks mostly finished visually, but code needs to be added so it's functional.

Some more features need to be added to this list from my OneNote notebook.


## How to work on the code

To edit the code, simply open `HTML-Character-Code-Acquisition-Program.sln` in Visual Studio. Visual Studio 2015 Community is the version that's used, but other newer versions might work.

## How to build it from source

In addition to the requirements for simply running html-ccap, your computer requires the following software to build it from source code:

- [Microsoft Build Tools 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48159)
  - If [Visual Studio 2015 Community](https://www.visualstudio.com/vs/older-downloads/) is installed, Microsoft Build Tools 2015 is not required for building thumbsget.

If you want to try the latest changes from the master branch, you can download the latest build's [artifacts from AppVeyor](https://ci.appveyor.com/project/DrewNaylor/html-character-code-acquisition-program/branch/master/artifacts). When the download has completed, extract the archive, then open the `Debug` folder. In this folder, double-click on `HTML-Character-Code-Acquisition-Program.exe`.

***

If you don't want to download from AppVeyor to build html-ccap, here's how to do it manually:

1. First, clone the Git repository by running: <code>git clone https://github.com/DrewNaylor/HTML-Character-Code-Acquisition-Program.git</code> or [download the Zip file for the master branch](https://github.com/DrewNaylor/HTML-Character-Code-Acquisition-Program/archive/master.zip) and remember where you saved your files.

2. Next, open the command prompt from the Start menu (`cmd.exe`) and type or copy/paste `cd C:\Program Files (x86)\MSBuild\14.0\Bin\` if you have a 64-bit Windows install or `cd C:\Program Files\MSBuild\14.0\Bin\` if you have a 32-bit Windows install. Press the Enter or Return key when it's pasted. Don't run `cmd.exe` from the Git Shell or else the next step won't work.

3. Third, type `msbuild.exe`, press the spacebar, and drag the `HTML-Character-Code-Acquisition-Program.sln` into the command prompt window and press the Enter or Return key.

4. And finally, once the project is done being built, you'll find the `HTML-Character-Code-Acquisition-Program.exe` file in `HTML-Character-Code-Acquisition-Program\HTML-Character-Code-Acquisition-Program\bin\Debug` wherever you saved the files to earlier along with a config file, a PDB file, and an XML file all named after html-ccap, as well as a file named `searchXml.xml` which is used to store the HTML character codes/character entities.

## System requirements

To use this software, the following requirements must be met:

- [Microsoft .Net 4.6.1 Framework](https://www.microsoft.com/en-us/download/details.aspx?id=49981)

  - Ignore the ad on that page, scroll down, and click the orange Download button. Note that this is the web installer and it'll download its components after it's opened. May take a while to download.
  - If on Linux, you can install this through winetricks with Wine 4.0 if I remember correctly. Should make html-ccap work on Linux, but this is untested.

- Windows versions: Windows 7 SP1, 8.1, 10.
  - Windows 8.0 is untested although it might work.
  - html-ccap has only been officially tested with Windows 10 as of July 13, 2019.

- Architectures: x86 (32-bit) and x64 (64-bit.)

- Hardware requirements: At least a 1.2 GHz CPU; 1 GB of RAM or more.

- Disk space:

  - 32-bit: 3 GB space free.
  - 64-bit: 3 GB space free.

- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in html-ccap due to Visual Studio building problems. There may also be a warning message on first start about Windows Defender SmartScreen saying it "prevented an unrecognized app from starting. Running this app might put your PC at risk." You can click the "More info" link, then the "Run anyway" button if you want to use it, though this may not be allowed on corporate networks.

- Disk space, RAM, and CPU frequency requirements are based on the .Net Framework 4.6.1 requirements. html-ccap itself is quite small, about 25 KB as of July 13, 2019.
