The interactor is meant to call functions and pass different variables to certain items in order to affect them in certain ways.
this will have a few children such as Spell and Weapon.

Interactor()

  interact(Interactee, Interaction)
    apply the interaction to the Interactee
    
Like I said, it will have a Spell child

Spell() extends Interactor
  
  enum Target() somehow I want this enum to limit who the player can click on
    self
    other
    area
  
  PossibleTargets <- List of Target()s EXAMPLE: You can have a spell that can be used on either yourself or a player, or it can be limited to yourself, or limited to an area. BUT, it cannot be area and another type
  TargetFriendly <- bool
  
  Effects <- Dictionary of (Effects: Potency)
  
  make a constructor that 
  
  SpellTarget <- List of GameObjects // this will be singular for the single spells or will be a list of all that are inside the area of effect 
  
  activate_spell()
    interact(SpellTarget, Effects) // apply effects to spell target
    
