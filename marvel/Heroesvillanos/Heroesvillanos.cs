using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Heroesvillanos;
// POCO Objects - Plain Old CSharp Objects
// A POCO object is a class that is designed to represent a database table.


public class Heroevillano
{
    
    
    
    public long Id {get; set;}
    public string Name {get; set;}
    [JsonConverter(typeof(StringEnumConverter))]
    public string Identity {get; set;}
     
    public string Alignment {get; set;}

    public string EyeColor {get; set;}

    public Gender Gender {get; set;}
    [JsonConverter(typeof(StringEnumConverter))]
    public Status Status {get; set;}

    public string Universe {get;}

    

}

