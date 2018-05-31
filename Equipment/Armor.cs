using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
  class Armor
  {
    private const int LIGHT_SIDE_ARMOR = 5;
    private const int DARK_SIDE_ARMOR = 5;

    private int armorPoints;
    public int ArmorPoints
    {
      get
      {
        return armorPoints;
      }
    }

    public Armor(Faction faction)
    {
      switch (faction)
      {
        case Faction.LightSide:
          armorPoints = LIGHT_SIDE_ARMOR;
          break;
        case Faction.DarkSide:
          armorPoints = DARK_SIDE_ARMOR;
          break;
      }
    }
  }
}