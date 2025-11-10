using client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Classes;

public abstract class CharacterClass
{
    public string Name { get; set; }
    public List<Ability> ClassAbilities { get; set; } = new();
    public List<Item> StartingEquipment { get; set; } = new();
    public abstract Stats GetClassBonus();
    public virtual void LevelUp(Character character) { }
}
