using client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Classes;

public class Mage : CharacterClass
{
    public Mage()
    {
        Name = "Mage";
        ClassAbilities.Add(new Ability("Fireball", "Deals high damage based on Intelligence.", AbilityType.Active, 12));
        ClassAbilities.Add(new Ability("Arcane Knowledge", "Increases spell effectiveness.", AbilityType.Passive, 0));
        StartingEquipment.Add(new Item("Staff", "Basic arcane focus", ItemType.Weapon));
    }

    public override Stats GetClassBonus() =>
        new Stats { Intelligence = 4, Wisdom = 1 };

    public override void LevelUp(Character character)
    {
        character.Stats.Intelligence += 3;
        character.Stats.Wisdom += 1;
    }
}
