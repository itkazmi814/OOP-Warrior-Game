using System;
using WarriorWars.Enum;

namespace WarriorWars
{
	class EntryPoint
	{

		static Random rng = new Random();

		static void Main()
		{
				Warrior goodGuy = new Warrior("Obi-Wan", Faction.LightSide);
				Warrior badGuy = new Warrior("Anakin", Faction.DarkSide);

				while (goodGuy.IsAlive && badGuy.IsAlive)
				{
					if (rng.Next(0,10) < 5)
					{
						goodGuy.Attack(badGuy);
					}
					else
					{
						badGuy.Attack(goodGuy);
					}
			}
		}
	}
}
