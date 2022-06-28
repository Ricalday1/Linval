namespace Heroesvillanos
{
    public interface IRepository
    {
        List<Heroevillano> GetAll();
        List<Heroevillano> GetHeroevillanoByName(string name);

        long Create(Heroevillano heroevillano);
    }
}