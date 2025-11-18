using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace client.Utilities;

public static class XmlStorageService
{
    private static readonly string BaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
    public static string DirectoryPath => BaseDirectory;

    private static string EnsureXmlExtension(string fileName)
    {
        return fileName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase)
            ? fileName
            : fileName + ".xml";
    }

    public static void SaveToFile<T>(T obj, string fileName)
    {
        Directory.CreateDirectory(BaseDirectory);
        var filePath = Path.Combine(BaseDirectory, EnsureXmlExtension(fileName));

        using var stream = new FileStream(filePath, FileMode.Create);
        var serializer = new XmlSerializer(typeof(T));
        serializer.Serialize(stream, obj);
    }

    public static T LoadFromFile<T>(string fileName)
    {
        var filePath = Path.Combine(BaseDirectory, EnsureXmlExtension(fileName));
        if (!File.Exists(filePath))
            throw new FileNotFoundException("File not found.", filePath);

        using var stream = new FileStream(filePath, FileMode.Open);
        var serializer = new XmlSerializer(typeof(T));
        return (T)serializer.Deserialize(stream);
    }

    public static void DeleteFile(string fileName)
    {
        var filePath = Path.Combine(BaseDirectory, EnsureXmlExtension(fileName));
        if (File.Exists(filePath))
            File.Delete(filePath);
    }

    public static bool FileExists(string fileName)
    {
        var filePath = Path.Combine(BaseDirectory, EnsureXmlExtension(fileName));
        return File.Exists(filePath);
    }

}