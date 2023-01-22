# BetterSinkholes2 - Sinkhole Environmental Hazard Rework

BetterSinkholes2 is a plugin that makes **sinkhole environmental hazards** (found in Light Containment Zone - IX Intersections) more realistic and  similar to SCP: Containment Breach. With the use of this plugin, players who walk into sinkholes fall into the pocket dimension *and may never return*.

## Requirements
- This plugin uses [EXILED](https://github.com/galaxy119/EXILED/).
- Make sure the config option in `config_gameplay.txt` called `sinkhole_spawn_chance` is set to higher than 0.

Note: **BetterSinkholes2 is only made to work with Exiled 6.0.0(+) and SCP:SL 12(+)!**

## Releases and Installation
You can find the latest release [here](https://github.com/rby-blackruby/BetterSinkholes2/releases).
Once downloaded, place the BetterSinkholes2.dll file into the /EXILED/Plugins folder and restart your server.

## Configs (/Exiled/Configs/<your.server.port>-config.yml)
| Config option | Value type | Default value | Description |
| --- | --- | --- | --- |
| `IsEnabled` | bool | true | Enables the BetterSinkholes2 plugin. Set it to false to disable it. |
| `SlowDistance` | float | 1.2f | Distance a the sinkhole where it starts slowing. Don't set it higher than 1.15! |
| `TeleportDistance` | float | 0.6f | Distance from a sinkhole where it teleports you to the pocket dimension. Set it to higher than 0!|
| `TeleportMessageDuration` | ushort | 0 | Duration of the sinkhole teleport message, when teleport message is not empty. |

## Translations (/EXILED/Configs/<your.server.port>-translations.yml)
| Config option | Value type | Default value | Description |
| --- | --- | --- | --- |
| `TeleportMessage` | string | '' | Set it to '' to disable sinkhole teleport message. Can use Unity's RichText. |

## Thank you!

Thank you for being interested in this plugin and I wish you a great time using it! If you have any ideas/problems feel free to contact me on discord: `blackruby#2562`
