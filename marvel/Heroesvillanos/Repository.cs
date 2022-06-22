namespace Heroesvillanos;
public class Repository
{     
    public List<Heroevillano> ListHeroesvillanos { get; set;}
    public bool LoadedFile {get; set;} = false;

    public void LoadFile(String filename)
    {
        try
        {
            ListHeroesvillanos = new List<Heroevillano>();
            var listHeroevillanoStrings = FileReader.ReadFile(filename);
            foreach (var item in listHeroevillanoStrings.Skip(1).Take(20))
            {
                // Console.WriteLine(item);
                var parser = new Parser ();
                var heroevillano = parser.Parse(item);
                ListHeroesvillanos.Add(heroevillano);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }         
        LoadedFile = true;
    }
    
    public List<Heroevillano> GetAll ()
    {
        if(LoadedFile == false)
        {
            throw new Exception("No se ha cargado el archivo");
        }
        return ListHeroesvillanos;
    }

    public List<Heroevillano> GetHeroevillanoByName (String name)
    {
        Console.WriteLine("leyendo nombres de heroes o villanos");
        if(LoadedFile == false)
        {
            throw new Exception("No se ha cargado el archivo");
        }
        return ListHeroesvillanos.Where(m => m. Name.Contains(name)).ToList();
    }
     public long Create (Heroevillano heroevillano)
    {
        throw new NotImplementedException();
    }
}

       