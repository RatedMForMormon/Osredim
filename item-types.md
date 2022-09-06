a "Pseudo-code" file detailing what an item is and all the different things that inherit the Item class

# Item
* Name - string
* Magic retention coefficient - int (-100 to 100) - determine 
* Channeling coefficient - int (0 - limit)
* weight - int (0 - limit)
## Weapon
* Type (Blade/Blunt/Range) - int(0-2) // I might get rid of range and just consider arrows as individual weapons
* Effect Modifier 'w' // I need something to tell the weapon how to affect an effect applied to it, potentially just a char that the effect checks when used
## Jewelry
* Type (necklace/ring/bracelet/crown)
* Effect modifier 'j'
* Cumberance - int (0-2)
## Armor
* Type
  * Head
fullhelm/halfhelm/mask/eyepiece/cap
  * Body
cape/plate/chest/abdomen/back
  * Arms
forearms/biceps/elbows
  * hands
gloves/gauntlets
  * legs
Thigh/calf/knee/greaves
  * feet
pauldron
* Effect modifier 'a'
* cumberance - int (0-9) // Cumberance represents the limit on how hard it is to put an item over another
## Consumable
* calls the "interactor" class on its target and applies a custom effect determined by its creation.
