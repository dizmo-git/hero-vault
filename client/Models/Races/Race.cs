using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models.Races;

public abstract class Race
{
    public string Name { get; set; }
    public Stats BaseStats { get; set; }
    public List<Ability> RacialAbilities { get; set; } = new();
    public virtual string GetDescription() => Name;
}