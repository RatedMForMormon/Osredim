using System;
using Unity;

Class Item(Monobehavior)
  {
    string itemName = new string();
    char itemType = new char();
    Dictionary itemAttributes = new Dictionary();
    Dictionary itemEffects = new Dictionary();
    string typeName = new string();
  
    Item(string name, char type, Dictionary attributes, Dictionary effects){
      itemName = name;
      itemType = type;
      itemAttributes = attributes;
      itemEffects = effects;
      
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
      }
    }
    
  }
