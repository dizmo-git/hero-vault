using client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Classes;

public class Ranger : CharacterClass
{
    public Ranger()
    {
        Name = "Ranger";
        ClassAbilities.Add(new Ability("Piercing Shot", "Ranged attack that ignores armor.", AbilityType.Active, 8));
        StartingEquipment.Add(new Item("Bow", "Simple wooden bow", ItemType.Weapon));
        StartingEquipment.Add(new Item("Leather Armor", "Light protection for mobility", ItemType.Armor));
    }

    public override Stats GetClassBonus() =>
        new Stats { Dexterity = 3, Wisdom = 2 };

    public override void LevelUp(Character character)
    {
        character.Stats.Dexterity += 2;
        character.Stats.Wisdom += 1;
    }
}