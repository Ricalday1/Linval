namespace Heroesvillaos
{
    public interface IRepository
    {
        List<Heroevillano> GetAll();
        List<Heroevillano> GetHeroevillanoByName(string name);

        long Create(Heroevillao heroevillano);
    }
}