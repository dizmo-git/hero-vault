using client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Classes;

public class Warrior : CharacterClass
{
    public Warrior()
    {
        Name = "Warrior";
        ClassAbilities.Add(new Ability("Power Strike", "A heavy melee attack that deals double Strength damage.", AbilityType.Active, 10));
        StartingEquipment.Add(new Item("Sword", "Standard one-handed sword", ItemType.Weapon));
        StartingEquipment.Add(new Item("Shield", "Basic iron shield", ItemType.Shield));
    }

    public override Stats GetClassBonus() =>
        new Stats { Strength = 3, Constitution = 2 };

    public override void LevelUp(Character character)
    {
        character.Stats.Strength += 2;
        character.Stats.Constitution += 1;
    }
}