# SeeShells: Windows Shellbag Timeline Display & Parser
[![GitHub release (latest by date)](https://img.shields.io/github/v/release/ShellBags/v2?include_prereleases)](https://github.com/ShellBags/v2/releases/tag/v2.0-beta.4)
[![GitHub All Releases](https://img.shields.io/github/downloads/ShellBags/v2/total)](https://github.com/ShellBags/v2/releases)
[![SeeShells License](https://img.shields.io/github/license/RickLeinecker/SeeShells)](https://github.com/RickLeinecker/SeeShells/blob/master/LICENSE)

[![SeeShells Logo](website/src/assets/logo.png)](https://rickleinecker.github.io/SeeShells/)
### [Visit v1 Website](https://rickleinecker.github.io/SeeShells/)
### [Visit v2 Website](https://shellbags.github.io/v2/#/)

SeeShells is a configurable Windows desktop application which focuses on extracting specific Registry data known as ShellBags. SeeShells displays this information in a interactive timeline that highlights user events as they were recorded.

The goal of SeeShell is to assist digital forensics investigators in their course of actions and provide more information that can be used as evidence in a court of law.

In addition to the timeline, SeeShells provides exporting:
 - CSV of all ShelBag information parsed.
 - HTML representation of the timeline
 - PDF for formal forensics reporting
 
 SeeShells operates on both running machines (live) and registry hive files (offline).

## Requirements
- Windows Vista SP2 or newer 
- [NET Framework 4.6](https://www.microsoft.com/en-us/download/details.aspx?id=53344) or newer


## Configuration 
JSON configuration files are used within the SeeShells application to provide information about Windows versions and their registry keys.
This ensures that if any new discoveries are found in the future regarding ShellBag information, they can easily be updated in the configuration file, and the program can adjust accordingly.

See the [Help Section](https://rickleinecker.github.io/SeeShells/help) for modifying SeeShells configurations. 

## Contributors
### v1 Developers
- Sara Frackiewicz
- Klayton Killough [@klaki892](https://github.com/klaki892)
- Aleksandar Stoyanov [@AlekStoyanov](https://github.com/AlekStoyanov)
- Bridget Woodye [@bridCquinn](https://github.com/bridCquinn)
- Yara As-Saidi [@yara-58](https://github.com/yara-58)

### v2 Developers
 - Spencer Ross [@serspencer](https://github.com/serspencer)
 - Jake Meyer [@jaymey](https://github.com/jaymey)
 - Josh Rueda [@SecurityNoodle](https://github.com/SecurityNoodle)
 - Devon Gadarowski [@devon-gadarowski ](https://github.com/devon-gadarowski)
 - Kaylee Hoyt [@hoytk6](https://github.com/hoytk6)

### Sponsor
- Richard Leinecker [@RickLeinecker](https://github.com/RickLeinecker)
