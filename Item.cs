using System;
using Unity;

Class Item(Monobehavior)
  {
    string name = new string();
    char type = new char();
    Dictionary attributes = new Dictionary();
    Dictionary effects = new Dictionary();
    item(string name, char type, Dictionary attributes, Dictionary effects){
      this.name = name;
      this.type = type;
      this.attributes = attributes;
      this.effects = effects;
    }
    
  }
