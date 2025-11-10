using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models;

public class Inventory
{
    public List<Item> Items { get; private set; } = new();

    public Inventory() { }

    public Inventory(IEnumerable<Item> startingItems)
    {
        Items.AddRange(startingItems);
    }

    public void AddItem(Item item) => Items.Add(item);
    public void RemoveItem(string name) => Items.RemoveAll(i => i.Name == name);
}