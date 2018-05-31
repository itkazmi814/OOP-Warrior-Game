using System;
using System.Threading;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
  class Warrior
  {
    private const int LIGHT_SIDE_STARTING_HEALTH = 20;
    private const int DARK_SIDE_STARTING_HEALTH = 20;
    
    private readonly Faction FACTION;

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
      FACTION = faction;
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

    public void Attack(Warrior enemy)
    {
      int damage = weapon.Damage / enemy.armor.ArmorPoints;
      enemy.health -= damage;
      AttackResult(damage, enemy);
      Thread.Sleep(200);
    }

    public void AttackResult(int damage, Warrior enemy)
    {
      if (enemy.health <= 0)
      {
        enemy.isAlive = false;
        Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
        Tools.ColorfulWriteLine($"{name} is victorious!", ConsoleColor.Green);
      }
      else
      {
        Console.WriteLine($"{name} attacked {enemy.name}. {damage} damage was inflicted to {enemy.name}. {enemy.name} has {enemy.health} health remaining.");
      }
    }

  }
}