# Cart Talking Mod

> **This is an updated and maintained fork of the original [TalkingCart mod by Syntaxe](https://thunderstore.io/c/repo/p/Syntaxe/TalkingCart/). The original mod is no longer being maintained, so this version has been updated to be compatible with the latest game update, fixing broken field references and adding support for newer enemies added since the original release.**

This mod makes the cart talk with voice and subtitles. The cart will warn the players when an enemy is nearby, let you know when an enemy has despawned/respawned, and tell you how many items are in the vicinity.

It was created as a part of the following YouTube video: https://youtu.be/naOCUkJkmzk

# Supported Features

- The cart has a chance of reacting aggressively if you damage an item in front of it. You can configure the chance from the config file.
- The cart will tell the players which enemies are present in the level at the start of each level.
- If an enemy enters the area around the cart within 20 units of the cart's position, the cart will warn the players.
- If an enemy that has been communicated as near exits the area around the cart, more than 23 units away, the cart will notify the players.
- If an enemy despawns, the cart will notify the players.
- If an enemy that has been communicated as despawned respawns, the cart will notify the players.
- If an enemy dies, the cart will notify the player.
- The player can disable the cart's communications by holding it in strong mode and pressing the Z key.
- The players can trigger the cart to tell them how many items are in the surrounding area by holding the cart in strong mode and pressing the X key.
- If modded enemies are present in the level, the cart will communicate their info using the game's TTS functionality.

All keybindings are changeable in the config file. Here is a list of valid keycodes: https://docs.google.com/spreadsheets/d/17ehNwtSd3fG-BeMJhkKTawRa0C0B_jTt7XAwhTI-oWk/edit?usp=sharing

# Issues

Please report bugs, wrong enemy announcements, or compatibility issues on GitHub: https://github.com/xcyberpunkx0/TalkingCart-Repo/issues

# Version 1.6.0

- Fixed enemy voice lines being mismatched, such as Headman/Duck announcements using Shadow Child or Mentalist clips.
- Voice clips are now resolved by their asset names inside `talkingcartassetbundle` instead of fragile numeric list positions.
- Restored bundled voice clips for supported enemies while keeping TTS fallback for enemies without bundled clips.
- Fixed `Apex Predator` being shown/logged as the internal game name; it is now displayed as `Duck`.
- Improved pronunciation aliases for names like Headman, Headgrab, Shadow Child, and Upscream.
- Fixed repeated respawn/despawn `ArgumentOutOfRangeException` errors caused by cart enemy-tracking lists getting out of sync.
- Fixed enemy announcements triggering before the player actually grabs the cart at the start of a level.
- Added safer guards around player/cart lookup during loading and level transitions.
- Kept the `roasts` and `talkingcartassetbundle` assets packaged with the plugin.

# Mod Type

Client-side.

# Attribution

This mod is based on the original **TalkingCart** by **Syntaxe**:
- [Original Thunderstore listing](https://thunderstore.io/c/repo/p/Syntaxe/TalkingCart/)
- [Original YouTube showcase](https://youtu.be/naOCUkJkmzk)

All original code, voice assets and design belong to Syntaxe. This fork only exists to keep things working while the original maintainer is away. If Syntaxe comes back and wants to take over again, this fork will step aside.

*Note: This is my first time maintaining a mod. I didn't include attribution at first because I didn't know about it, not because I was trying to hide anything. I've added it now and will keep it going forward.*

*The mod icon was made with an AI image generator. The mod code itself is hand-written.*
