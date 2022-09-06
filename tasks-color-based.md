# Color-Based Abilities
These abilities follow the six colors of magic

* red - destruction
* orange - invigoration
* yellow - creation
* green - restoration
* blue - suppression
* purple - manipulation

Each of these has a basic spell which, depending on their proficiency (level) in the color, can be configured to do various things.

Example: Red magic has a "destroy" spell, a player with higher proficiency could target an enemy's health, mana, stamina, buffs, active effects or any number of things

Note: it's crucial that there be no limit to who you can target, including yourself or teammates.

## Destruction Spells
ANYTHING that destroys, no matter what it destroys
* Destroy Target
## Invigoration Spells
Essentially buffs of any kind
* Invigorate Target
## Creation Spells
Any kind of creation, ie. crafting
* Create Target
## Restoration Spells
You get the pattern now?
* Restore Target
## Suppression Spells
* Suppress Target
## Manipulation Spells
This one is a bit different, it doesn't produce any effects, it manipulates the flow of mana, so it can change the target of an active skill
* Manipulate Mana

After the six colors comes two more, White and Black, Black can be shosen at the beginning of the game, and it gives your character access to black magic and you forego all the colored abilities. White is vastly superior, but you need to achieve 100% proficiency before unlocking it

## White 
White magic allows you to forego the defecits of combining different colors of magic together, and resets your proficiencies of each color, giving you more to progress with, setting the new max proficiency to 200%
White proficiency also resists all types of black magic
* Blessing of Deos - Color synergies never go below zero, proficiencies are reset, setting the new max to 200%. Also resists any kind of black magic depending on your white proficiency
* Excorcise - Remove any black magic effects from a target permanently
## Black
Black magic, if chosen, gives you a "blessing"
Black magic is a void, it focuses on "draining" to make yourself more powerful, so there are a great number of effects to can get by using it, such as draining another's HP regens your own, or draining someone's active skill gives it to you for a limited time.
* Curse of Black magic - the player cannot use colored magic and gains +20% more experience, allows the use of black magic
* Drain Target

## Colorless
Anything to do with transportation

Tasks that need completed for this to work

* NPC class created
* Item class created
* interactor class created - interacts with various things, allows spells to affect their targets - calls functions that lower numbers associated with the target
  * can interact with Spells, NPCs, Items, Players(including self) 
* Spell class? could potentially be the same or a child of interactor
* weapon class? child of item - also an interactor
* armor class? child of item - not an interactor, other items calculate its interaction depending on the skills and attributes it has
