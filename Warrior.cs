using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
  class Warrior
  {
    private const int LIGHT_SIDE_STARTING_HEALTH = 100;
    private const int DARK_SIDE_STARTING_HEALTH = 100;
    
    private Faction faction;

    private int health;
    private string name;
    private bool isAlive;

    public bool IsAlive 
    {
      get
      {
        return isAlive;
      } 
    }

    private Weapon weapon;
    private Armor armor;

    public Warrior(string name, Faction faction)
    {
      this.name = name;
      this.faction = faction;
      isAlive = true;

      switch (faction)
      {
        case Faction.LightSide:
          weapon = new Weapon(faction);
          armor = new Armor(faction);
          health = LIGHT_SIDE_STARTING_HEALTH;
          break;
        case Faction.DarkSide:
          weapon = new Weapon(faction);
          armor = new Armor(faction);
          health = DARK_SIDE_STARTING_HEALTH;
          break;
      }

    }

  }
}