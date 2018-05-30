using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
  class Weapon
  {
    private int damage;
    private const int LIGHT_SIDE_DAMAGE = 5;
    private const int DARK_SIDE_DAMAGE = 5;

    public int Damage 
    {
      get
      {
        return damage;
      } 
    }


    public Weapon(Faction faction)
    {
      switch (faction)
      {
        case Faction.LightSide:
          damage = LIGHT_SIDE_DAMAGE;
          break;

        case Faction.DarkSide:
          damage = DARK_SIDE_DAMAGE;
          break;
      }
    }
  }
}