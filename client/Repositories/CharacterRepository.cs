using client.Models;
using client.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Repositories;

public class CharacterRepository
{
    private readonly string _folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "characters");

    public CharacterRepository()
    {
        Directory.CreateDirectory(_folderPath);
    }

    private string GetFilePath(string name) => Path.Combine(_folderPath, $"{name}.xml");

    public void Save(Character character)
    {
        var fileName = $"{character.Name}.xml";
        XmlStorageService.SaveToFile(character, Path.Combine("characters", fileName));
    }

    public Character Load(string name)
    {
        var fileName = $"{name}.xml";
        return XmlStorageService.LoadFromFile<Character>(Path.Combine("characters", fileName));
    }

    public void Delete(string name)
    {
        XmlStorageService.DeleteFile(Path.Combine("characters", $"{name}.xml"));
    }

    public List<Character> GetAllCharacters()
    {
        var files = Directory.GetFiles(_folderPath, "*.xml");
        var characters = new List<Character>();

        foreach (var file in files)
        {
            try
            {
                using var stream = new FileStream(file, FileMode.Open);
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Character));
                var character = (Character)serializer.Deserialize(stream);
                characters.Add(character);
            }
            catch
            {
                // Skip corrupted or incompatible files
            }
        }

        return characters;
    }

    public bool Exists(string name)
    {
        return File.Exists(GetFilePath(name));
    }
}
