using System.Xml.Serialization;

namespace Heroesvillanos;

public class FileWriterXml : IFileWriter
{
    public void Write(List<Heroevillano> heroesvillanos, string path)
    {
        var serializer = new XmlSerializer(typeof(List<Heroevillano>));
        using (var writer = new StreamWriter(path))
        {
            serializer.Serialize(writer, heroesvillanos);
        }
    }
}