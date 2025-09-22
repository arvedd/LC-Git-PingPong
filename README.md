# Spacepong 

**Spacepong** is a 2D arcade game inspired by the classic Pong. In this game, players control paddles to deflect a meteor ball and prevent it from crossing their defense line. Each time the meteor successfully passes through the opponent’s defense, the player scores a point. The match continues until one of the players reaches a certain score, and that player is declared the winner.

---

## Developer
Ngakan Nyoman Arya Vedantha (Game Programmer)
<br>

## Built Time
The game was built for 5 days.
<br>

## Features & Scripts 

<table>
  <tr>
    <th>Feature</th>
    <th>Description</th>
    <th>Main Scripts</th>
  </tr>
  <tr>
    <td><b>Players Movement</b></td>
    <td>Handles players movement using W,S keys and Up, Down arrow keys.</td>
    <td><code>PlayerMovement.cs</code></td>
  </tr>
  <tr>
    <td><b>Ball System</b></td>
    <td>Manages the ball's movement.</td>
    <td><code>BallControl.cs</code></td>
  </tr>
  <tr>
    <td><b>Scoring System</b></td>
    <td>Manages scoring when ball hit a collider behind each player.</td>
    <td><code>ScoreZone.cs</code></td>
  </tr>
  <tr>
    <td><b>Game UI</b></td>
    <td>Controls scoring UI for the game.</td>
    <td><code>GameManager.cs</code></td>
  </tr>
</table>

---

## 📂Files description

```
├── SpacePong                     # Contain everything needed for SpacePong to works.
   ├── .vscode                        # Contains configuration files for Visual Studio Code (VSCode) when it's used as the code editor for the project.
      ├── extensions.json             # Contains settings and configurations for debugging, code formatting, and IntelliSense. This folder is related to Visual Studio Code integration.
      ├── launch.json                 # Contains the configuration necessary to start debugging Unity C# scripts within VSCode.                     
      ├── setting.json                # Contains workspace-specific settings for VSCode that are applied when working within the Unity project.
   ├── Assets                         # Contains every assets that have been worked with unity to create the game like the scripts and the art.
      ├── Art                         # Contains all the game art like the sprites, background, even the character.
      ├── Game Animation              # Contains every animation clip and animator controller that played when the game start.
      ├── Game Musics                 # Contains every sound used for the game like music and sound effects.
      ├── Game Scripts                # Contains all scripts needed to make the gane get goings like PlayerMovement scripts.
      ├── Prefabs                     # Contains every pre-configured, reusable game object that you can instantiate (create copies of) in your game scene.
      ├── Scenes                      # Contains all scenes that exist in the game for it to interconnected with each other like MainMenu, Gameplay, etc
      ├── ThirdParty Packages         # Contains the Package Manager from unity registry or unity asset store assets for game purposes.
   ├── Packages                       # Contains game packages that responsible for managing external libraries and packages used in your project.
      ├── Manifest.json               # Contains the lists of all the packages that your project depends on and their versions.
      ├── Packages-lock.json          # Contains packages that ensuring your project always uses the same versions of all dependencies and their sub-dependencies.
   ├── Project Settings               # Contains the configuration of your game to control the quality settings, icon, or even the cursor settings
├── README.md                         # The description of Lightning Boy file from About til the developers and the contribution for this game.
```

## Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Player 1 movement |
| Arrow Keys           | Player 2 movement |

<br>

## Project Goal

This game was created as a **learning project** to experiment with Unity.

---
