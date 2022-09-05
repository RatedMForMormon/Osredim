using System;
using Unity;

public Class Npc(): Monobehavior {
  
  private int favor; // Favor tells the NPC how much it likes you, -100 is kill on sight and 100 is will die for you
  private int hp;
  private int mana;
  private int stamina;
  private string name;
  
  public Npc(int favor, int hp, int mana, int stamina, string name){
    this.favor = favor
    this.hp = hp
    this.mana = mana 
    this.stamina = stamina
    this.name = name
  }
  
  
  
}
