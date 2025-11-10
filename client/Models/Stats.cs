using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models;

public class Stats
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public static Stats operator +(Stats a, Stats b)
    {
        return new Stats
        {
            Strength = a.Strength + b.Strength,
            Dexterity = a.Dexterity + b.Dexterity,
            Constitution = a.Constitution + b.Constitution,
            Intelligence = a.Intelligence + b.Intelligence,
            Wisdom = a.Wisdom + b.Wisdom,
            Charisma = a.Charisma + b.Charisma
        };
    }
}