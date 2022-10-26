namespace Heroesvillanos;

public class Parser 
{
    public Heroevillano Parse(string line)
    {
        var heroevillano = new Heroevillano();
        var values = line.Split(',');
        heroevillano.Id = long.Parse(values[0]);
        heroevillano.Name = values[1];
        //heroevillano.Identity = (Gender)Enum.Parse(typeof(Gender), values[2]);
        //heroevillno.Alignment = (Alignment)Enum.Parse(typeof(Alige), values[3]);
        //heroevillano.Eyecolor = long.Parse(values[5]);
        //heroevillano.Haircolor = values[6].Split('-').ToList();
        return heroevillano;
    }
    
    public Gender ParseGender(string line)
    {
        Gender returnValue = new Gender();
        var values = line.Split('-');
        foreach (var item in values)
        {
            if(item.Any(Char.IsWhiteSpace))
            {
                if(item == "Male")
                    returnValue = returnValue | Gender.Male | Gender.Female;
            }
            else 
            {
                if (Enum.TryParse<Gender>(item, out var genderValue))
                    returnValue = returnValue | genderValue;
            }
        }
        return returnValue;
    }

    public Identity ParseIndetity(string item)
    {
 
        if (Enum.TryParse<Identity>(item, out var identityValue))
            return identityValue;
        else
            return Identity.NoDual;
    }
}
