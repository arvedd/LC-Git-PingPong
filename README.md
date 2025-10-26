# Spacepong 

<table>
  <tr>
    <td align="left" width="100%">
      <img width="100%" alt="gif1" src="https://media.giphy.com/media/wtaRkBEnx9PSnKh1vi/giphy.gif">
    </td>
    <!-- <td align="right" width="50%">
      <img width="100%" alt="gif2" src="https://github.com/user-attachments/assets/f96b78ce-3f23-4b2e-a17f-c7c1581d5cf5">
    </td> -->
  </tr>
</table>

**Spacepong** is a 2D arcade game inspired by the classic Pong. In this game, players control paddles to deflect a meteor ball and prevent it from crossing their defense line. Each time the meteor successfully passes through the opponent’s defense, the player scores a point. The match continues until one of the players reaches a certain score, and that player is declared the winner.

---

## Developer
Ngakan Nyoman Arya Vedantha (Game Programmer)
<br>

## Built Time
The game was built for 6 days.
<br>

## Features & Scripts 

<table>
  <tr>
    <th>Scripts</th>
    <th>Description</th>
  </tr>
  <tr>
    <td><b>PlayerMovement.cs</b></td>
    <td>Handles players movement using W,S keys and Up, Down arrow keys.</td>
  </tr>
  <tr>
    <td><b>BallControl.cs</b></td>
    <td>Manages the ball's movement.</td>
  </tr>
  <tr>
    <td><b>ScoreZone.cs</b></td>
    <td>Manages scoring when ball hit a collider behind each player.</td>
  </tr>
  <tr>
    <td><b>GameManager.cs</b></td>
    <td>Controls scoring UI for the game.</td>
  </tr>
</table>

---

## Files description

```
├── SpacePong                         # Contain everything needed for SpacePong to works.
   ├── Assets                         # Contains every assets that have been worked with unity to create the game like the scripts and the art.
      ├── Sprites                     # Contains all the game art like the sprites, background, even the character.
      ├── Fonts                       # Contains every font that have been used in the game.
      ├── Sounds                      # Contains every sound used for the game like music and sound effects.
      ├── Scripts                     # Contains all scripts needed to make the gane get goings like PlayerMovement scripts.
      ├── Scenes                      # Contains all scenes that exist in the game for it to interconnected with each other like MainMenu, Gameplay.
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
