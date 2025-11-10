using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Races;

public class Elf : Race
{
    public Elf()
    {
        Name = "Elf";
        BaseStats = new Stats { Strength = 8, Dexterity = 14, Constitution = 9, Intelligence = 12, Wisdom = 11, Charisma = 10 };
        RacialAbilities.Add(new Ability("Keen Senses", "Increased accuracy and perception", AbilityType.Passive, 0));
    }
}
