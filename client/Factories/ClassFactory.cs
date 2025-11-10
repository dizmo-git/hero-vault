using client.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Factories;

public static class ClassFactory
{
    public static CharacterClass Create(string className)
    {
        if (string.IsNullOrWhiteSpace(className))
            throw new ArgumentException("Class name cannot be null or empty.");

        return className.ToLower() switch
        {
            "warrior" => new Warrior(),
            "mage" => new Mage(),
            "ranger" => new Ranger(),
            _ => throw new ArgumentException($"Unknown class: {className}")
        };
    }
}