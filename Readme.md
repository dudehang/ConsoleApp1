Text Novel Test
simple command line text novel. There will be a start screen that you will have to press something to start the game. The game will start off in a dungeon and you will wonder around and find shit in rooms.
Using the text as string arrays. You press enter if you want the next line.


Design Brief

Program Structure:

Control function -> world class -> area class -> object class


Control function:
	Handles all IO and gamestate variables

World class:
	Contains descriptors and paramaters for the current 'world' the player is occupying.
	Contains a list of area instances.

Area class:
	Contains descriptors and parameters for the current local area of the player. 
	IE. room, section of road, etc
	May contain N objects

Object class:
	Multiple types of object:
		Actor, Item, Static

	Keys, enemies, machinery - Anything requiring anything beyond a description and movement/helper functions

