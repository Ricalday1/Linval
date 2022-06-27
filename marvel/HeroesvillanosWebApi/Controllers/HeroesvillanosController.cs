using Microsoft.AspNetCore.Mvc;
using Heroesvillanos;

namespace HeroesvillanosWebApi.Controllers;


// http://www.heroesvillanoswebapi.com/swagger/index.html

// http://www.heroesvillanoswebapi.com/api/heroesvillanos

[ApiController]
[Route("api/[controller]")]
public class HeroesvillanosController : ControllerBase
{
    private readonly ILogger<HeroesvillanosController> _logger;
    private readonly Repository _repository;
    public HeroesvillanosController(ILogger<HeroesvillanosController> logger)
    {
        _logger = logger;
        _repository = new Repository();
        _repository.LoadFile(@"C:\Users\1\Desktop\marvel_dc_characters.csv");
    }

    [HttpGet]
    [Route("GetHeroesvillanos")]
    public IEnumerable<Heroevillano> GetHeroesvillanos()
    {
        return _repository.GetAll();
    }

    [HttpGet]
    [Route("GetHeroesvillanosByName")]
    public IEnumerable<Heroevillano> GetHeroesvillanosByName(String name)
    {
       // _logger.Log("Leyendo por nombre de heroes o villanos");
        return _repository.GetHeroevillanoByName(name);
    }

     [HttpPost]
    [Route("Heroesvillanos")]
    public long Post([FromBody] Heroevillano heroevillano)
    {
        return _repository.Create(heroevillano);
    }
}

   