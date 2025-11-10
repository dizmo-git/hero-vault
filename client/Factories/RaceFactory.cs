using client.Models.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Factories;

public static class RaceFactory
{
    public static Race Create(string raceName)
    {
        if (string.IsNullOrWhiteSpace(raceName))
            throw new ArgumentException("Race name cannot be null or empty.");

        return raceName.ToLower() switch
        {
            "human" => new Human(),
            "elf" => new Elf(),
            "dwarf" => new Dwarf(),
            _ => throw new ArgumentException($"Unknown race: {raceName}")
        };
    }
}