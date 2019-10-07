using fifaAdministration.GameFeature.Representation;
using fifaAdministration.Models;
using Microsoft.AspNetCore.Mvc;

namespace fifaAdministration.GameFeature
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public IActionResult GetAllGames()
        {
            return Ok(_gameService.GetAllGames());
        }

        [HttpPost]
        public IActionResult PostNewGame([FromBody]GameWriteViewModel gameView)
        {
            var game = new Game
            {
                Home = gameView.HomeName,
                Away = gameView.AwayName,
                HomeGoals = gameView.HomeGoals,
                AwayGoals = gameView.AwayGoals
            };
            _gameService.PostNewGame(game);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGame(GameWriteViewModel gameView)
        {
            var game = new Game
            {
                Home = gameView.HomeName,
                Away = gameView.AwayName,
                HomeGoals = gameView.HomeGoals,
                AwayGoals = gameView.AwayGoals
            };
            _gameService.UpdateGame(game);
            return Ok();
        }
    }
}