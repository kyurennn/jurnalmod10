using Microsoft.AspNetCore.Mvc;
using Modul10_103022400056;
using Modul10_103022400056.Controllers;

namespace Modul10_103022400056.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> Games = new List<Game>
        {
            new Game("Valorant", "Riot Games", "2020", "FPS", 8.5, ["PC"], ["Multiplayer"], true, 0),
            new Game("GTA V", "Rockstar Games", "2013", "Open World", 9.5, ["PC", "PS4", "PS5", "XBOX"], ["Singleplayer, Multiplayer"], true, 300000),
            new Game("The Witcher 3", "CD Projekt Red", "2015", "RPG", 9.7, ["PC", "PS4", "PS5", "XBOX", "Switch"], ["Singleplayer"], false, 25000)
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public GameController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Game> Get()
        {
            return Games;
        }

        [HttpGet("{id}")]
        public Game GetById([FromRoute] int id)
        {
            return Games[id];
        }

        [HttpPost]
        public void Post([FromBody] Game newGame)
        {
            Games.Add(newGame);
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] Game updatedGame)
        {
            Games[id] = updatedGame;
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            Games.RemoveAt(id);
        }
    }
}