using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Races;

public class Human : Race
{
    public Human()
    {
        Name = "Human";
        BaseStats = new Stats { Strength = 10, Dexterity = 10, Constitution = 10, Intelligence = 10, Wisdom = 10, Charisma = 10 };
        RacialAbilities.Add(new Ability("Adaptive Spirit", "Gain +1 to all stats at level up", AbilityType.Passive, 0));
    }
}