using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ItemType Type { get; set; }
    public int Power { get; set; } = 0;

    public Item() { }
    public Item(string name, string description, ItemType type)
    {
        Name = name;
        Description = description;
        Type = type;
    }
}

public enum ItemType
{
    Weapon,
    Armor,
    Shield,
    Trinket,
    Consumable
}