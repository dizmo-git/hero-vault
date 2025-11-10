using client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models;

public class Ability
{
    public string Name { get; }
    public string Description { get; }
    public AbilityType Type { get; }
    public int Power { get; }

    public Ability() { }
    public Ability(string name, string description, AbilityType type, int power)
    {
        Name = name;
        Description = description;
        Type = type;
        Power = power;
    }

    public virtual void Use(Character user, Character target)
    {
        Console.WriteLine($"{user.Name} uses {Name} on {target.Name}!");
    }
}

public enum AbilityType
{
    Active,
    Passive
}