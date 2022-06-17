using Heroesvillanos;

var repository = new Repository();

repository.LoadFile(@"C:\Users\1\Desktop\marvel_dc_characters.csv");
foreach (var heroevillano in repository.GetAll())
{
    Console.WriteLine(heroevillano.Name);
}