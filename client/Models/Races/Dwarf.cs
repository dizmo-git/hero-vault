using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Races;

public class Dwarf : Race
{
    public Dwarf()
    {
        Name = "Dwarf";
        BaseStats = new Stats { Strength = 12, Dexterity = 8, Constitution = 14, Intelligence = 9, Wisdom = 11, Charisma = 8 };
        RacialAbilities.Add(new Ability("Stone Resilience", "Reduces physical damage by 10%", AbilityType.Passive, 0));
    }
}