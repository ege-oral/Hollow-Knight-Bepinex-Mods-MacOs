# Mac Hollow Knight BepInEx Mods

This repository contains a collection of mods for Hollow Knight using BepInEx on macOS.  
The mods include One-Hit Kill, Infinite Jumps, No Damage, Super Speed, and Infinite Dash.

## Features

- **Infinite Dash** – Dash without cooldown.
- **Infinite Jumps** – Jump endlessly, even in mid-air.
- **No Damage** – Prevent all incoming damage.
- **One-Hit Kill** – Defeat all enemies instantly.
- **Super Speed** – Move at double speed.


## Installation Guide

### 1. Install BepInEx for macOS
1. Download **BepInEx-Unity.Mono-macos-x64** from the official repository:  
   [BepInEx Releases](https://github.com/BepInEx/BepInEx/releases)
2. Extract the downloaded archive and move the contents into your Hollow Knight folder:
```

~/Library/Application Support/Steam/steamapps/common/Hollow Knight/

```
3. Run the game once to generate the required BepInEx folders.

### 2. Install the Mods
1. Download or clone this repository:
```

git clone https://github.com/ege-oral/Hollow-Knight-Bepinex-Mods-MacOs.git

```
2. **If you want to build the mods yourself**, you need to **reference the Hollow Knight game assemblies**:
- **Assembly-CSharp.dll**
- **PlayMaker.dll**

These can be found in:
```

~/Library/Application Support/Steam/steamapps/common/Hollow Knight/hollow_knight.app/Contents/Resources/Data/Managed/

```
3. Build the mods with

```

cd Hollow-Knight-Bepinex-Mods-MacOs
dotnet build

```
4. Move the compiled `.dll` files to the BepInEx plugins folder:
```

cp bin/Debug/netstandard2.0/HollowKnightMods.dll ~/Library/Application\ Support/Steam/steamapps/common/Hollow\ Knight/BepInEx/plugins/

```
## Running the Game with Mods

1. Start Hollow Knight with BepInEx:
```

~/Library/Application\ Support/Steam/steamapps/common/Hollow\ Knight/run_bepinex.sh

```
2. Check the logs to confirm that the mods are loaded:

```

cat ~/Library/Application\ Support/Steam/steamapps/common/Hollow\ Knight/BepInEx/logs/LogOutput.log

```

- If there are **errors in the logs**, open an issue on the GitHub repository with a copy of your log file.
  
## Enjoy!

Have fun exploring Hollow Knight with these mods. Hope you enjoy the enhanced experience!

## Gameplay
https://drive.google.com/file/d/1ZKWbKg48RvyqXQl3p10FKXoSor2NYcSY/view?usp=sharing
