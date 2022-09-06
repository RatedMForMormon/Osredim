using System;
using Unity;

Class Item(Monobehavior)
  {
    private string itemName = new string();
    private char itemType = new char();
    private Dictionary itemAttributes = new Dictionary();
    private Dictionary itemEffects = new Dictionary();
    private string typeName = new string();
  
    public Item(string name, char type, Dictionary attributes, Dictionary effects){
      itemName = name;
      itemType = type;
      itemAttributes = attributes;
      itemEffects = effects;
      typeName = getType(itemName);
    }
    
    public string getName(){
      return itemName;
    }
    public string getType(char type){
      switch(type){
        case 'r':
          return "ring";
        case 'a':
          return "armor";
        case 'w':
          return "weapon";
        default:
          return "Type does not exist for " + type;
      }
    }
    
  }
