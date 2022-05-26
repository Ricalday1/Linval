using Heroesvillanos;

var repository = new Repository();

foreach (var heroevillano in repository.GetAll())
{
    Console.WriteLine(heroevillano.Name);
}