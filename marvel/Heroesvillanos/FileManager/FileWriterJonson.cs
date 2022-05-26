using Newtonsoft.Json;

namespace Heroesvillanos;

public class FileWriterJson : IFileWriter
{
    public void Write(List<Heroevillano> heroesvillanos, string path)
    {
        var json = JsonConvert.SerializeObject(heroesvillanos);
        File.WriteAllText(path, json); 
    }
}