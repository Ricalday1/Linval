namespace Heroesvillanos;
public class Repository
{     
    public List<Heroevillano> GetAll ()
    {         
        var listHeroevillanoStrings = FileReader.ReadFile(@"C:\Users\1\Desktop\marvel_dc_characters.csv");

        List<Heroevillano>  ListHeroesvillanos = new List<Heroevillano>();        
        foreach (var item in listHeroevillnoStrings.Skip(1))
        {
            var parser = new Parser();
            var heroevillano = parser.Parse(item);
            ListHeroesvillanos.Add(heroevillano);
        }

        return ListHeroesvillanos;
    }
}