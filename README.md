# Unity - Ghosts and Candies

A Unity project with some sprites of ghosts and candies.

## Screenshots

![Screenshot](https://github.com/user-attachments/assets/22d38c28-38a7-467b-9bac-a9fde3ab5be9)

## How to use

1. Clone this repository.
2. Open it in Unity.
3. Run the scene.

## Sprites

All sprites were created by [Microsoft designer](https://designer.microsoft.com/).

### Ghosts

The prompt for ghost sprites was `sprite minimalistic cartoon ghost. [emotion]. takes off. front view`.

### Candies

The prompt for candy sprites was `minimalistic cartoon [color] candy`.

I don't know why - it's impossible to get rid of their faces.

## Code

Movement works. Spawner is not the best but still works. Player... I don't want to talk about it.

## Why did I create this

In September 2023, I created a game development club at the university. This idea didn’t catch on and I closed it a year later.

But when it still existed, I hoped to hold thematic events from time to time. One of these events was to be GameJam, held on Halloween.

And here we are. There is no club, but there is me. I, who have a [channel (UA)](https://t.me/DrPinedApple) in Telegram, where a small number of people follow me. So I decided to do such small GameJams, in which only I will participate for my subscribers.

At the same time, this stimulates me to publish something on Github and I apologize very much for the bad code. I gave myself too little time to do everything. Also, for some reason, I decided to immediately document it, although it is clear that this should have been done after the end.

I hope this will be of some use to you.

## How did I create this

I wanted to develop this project in a week, but due to unexpected obstacles I only had two days left.

### Day One

- Created a project in Unity. Chose the Universal2D template.
- Created a basic file structure for further work.
- Added empty objects to the scene, for a more visual hierarchy.

- Created the background and sprites of the ghosts using Designer.
- Created the particle effects partially using Designer.
- Created the music using Suno.
- Cropped the images using Segment.

- Created the prefabs of the ghosts.
- Created the prefabs of the explosion and movement of the ghost effect.

### Day two

- Wrote a ghost movement script.
- Wrote a ghost movement trajectory change script.
- Wrote a ghost death script.

- Created a spawner.
    - The spawner has two points, depending on the position of which ghosts are created.
        - These points are automatically located depending on the screen size.
- Wrote a ghost spawn script.

- Wrote a mouse click handler.
- Wrote a score counter.

- Created an Endgame panel.
- Added the end of the game when clicking on an evil ghost.

- Added music and sound effects.

## What difficulties did I face

The "Make it work, make it right, make it fast" approach turned out to be quite effective. But its main problem is that if the head is stupid, then "Make it right" becomes an unattainable goal.
In general, if I had a little more time, or experience, the work would have been done a little better.

The main problems were:
- Adding several particles to the effect. I'm still sure that the crutch I used is the wrong solution.
- Spawner. In the process, I wrote such a complex algorithm for spawning ghosts that now I can't even explain what its individual parts are responsible for. It would have been worth breaking it down into methods, or even classes.
- Setting up objects. After 10 hours of work, I started writing something absurd. First I set up the object, and only then created it. Don't do that. The least problem will be the fact that nothing works. But if you add components this way, it's easier to just assemble the prefab from scratch.

## What I gonna do

I want to develop another game for the New Year. I hope it will be better. In the meantime, I have another month to calmly work on my own project.