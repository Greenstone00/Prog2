# Progression
## week 4
* Set up Unity and Visual Studio for the project
* Made some pixel and character art for the game
* Some debugging in Visual Studio
* Made the basic map and loaded the game objects
* Give the playable character object gravity and coliders so it can not fall out of the map and itneract with the world around it
## week 5
* Made the playable character shootable, so you can launch it towards stuff
* Give the playable character some texture changes if it's clicked on
* Give the playable character some indicators for the launching part and made it fit the screen and made it pass to the playable game object
* Some debugging in the palyable object's code
## week 6
* Added enemies and wrote them a script so they die on collision with the playable game object or getting hit on their head
* Animated some more frames for the enemies so they can blink
* Made changes in the lineart and basic look of the map
* Made a virtual camera with cinnematics that follows our cat and the enemies and adjust it according to them
* Made a particle system that pops up upon enemy death
* Some basic debbugging with some numbers and date that did not match the previous settings
    * (right now there is a bug, where if a mosue gets hit, but it's not a direct hit, it starts spinning for no reason at all)
## week 7
* Mad a script that takes us to next sceenes when all enemies are elliminated.
* Made the Lvl Controller with the script, so now we have multiple (4, as right now) levels in the game.
* Not much more, had some test this week and they took all my time and energy.
## week 8
* Made a fully fincional menu for the game.
* Made a volume controller so we can change the music's volume.
* Made some patching up for the level controller so it works with the menu.
* Added a pauseable menu when Esc is hit in game. 
* Some bugfixing with the new pause menu (like when we leave a game level, and get back to the main menu, and start to play again, the game was still paused).
* Fixed the mouses animations (they weren't blinking, but they were intended to).
* Added a hint text for the first level that dissapears upon clicking in the game.
* Added a ending scene.
* Made an option if R is hit on an ongoing level the level also resets if the player don't want to wait for the auto reset.
* Fix a bug where the levels weren't loading properly after beating the game and replaying it.
* Fixed an audio error where the Main Menu track started to play the music on max volume.
## week 10
* Made the hint into a separate button in the main menu.
* Made some changes how to levels load.
* Made some transitions between levels, so it's not frame to frame loads the next.
## week 11
* Made the player's Vector3 clamped, so it can't be dragged all the way over the sceen.
* Fixed a bug where the cat would end up under the map with the clamped vec3.
* Made a change so the game won't load the next level in the next frame all the mice are dead but instead waits 2 seconds.
* Made new sprites and anims for new enemies.
* Added 4 more levels.
