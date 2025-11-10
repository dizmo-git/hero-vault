using client.Models.Classes;
using client.Models.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace client.Models;

[Serializable]
[XmlInclude(typeof(Human))]
[XmlInclude(typeof(Elf))]
[XmlInclude(typeof(Dwarf))]
[XmlInclude(typeof(Warrior))]
[XmlInclude(typeof(Mage))]
[XmlInclude(typeof(Ranger))]
public class Character
{
    public string Name { get; set; }
    public Race Race { get; set; }
    public CharacterClass Class { get; set; }
    public Stats Stats { get; set; }
    public Inventory Inventory { get; set; }
    [XmlIgnore]
    public int Level { get; private set; } = 1;

    [XmlElement("Level")]
    public int LevelSerializable
    {
        get => Level;
        set => Level = value;
    }
    public int CurrentHealth { get; set; }

    public Character() { }

    public Character(string name, Race race, CharacterClass cls)
    {
        Name = name;
        Race = race;
        Class = cls;

        Stats = race.BaseStats + cls.GetClassBonus();
        Inventory = new Inventory(cls.StartingEquipment);
        CurrentHealth = 10 + Stats.Constitution;
    }

    public void LevelUp()
    {
        Level++;
        Class.LevelUp(this);
        CurrentHealth = 10 + Stats.Constitution;
    }

    public void UseAbility(string abilityName, Character target)
    {
        var ability = Class.ClassAbilities.FirstOrDefault(a => a.Name == abilityName);
        ability?.Use(this, target);
    }
}