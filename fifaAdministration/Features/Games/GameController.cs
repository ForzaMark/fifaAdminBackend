using fifaAdministration.Features.Games.Representation;
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

        [HttpPost]
        public IActionResult PostNewGame([FromBody]GameWriteViewModel gameView)
        {
            var game = new Game
            {
                HomePlayer = gameView.HomeName,
                AwayPlayer = gameView.AwayName,
                HomeGoals = gameView.HomeGoals,
                AwayGoals = gameView.AwayGoals,
                GroupId = gameView.GroupId
            };
            _gameService.PostNewGame(game);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditGame(GameEditViewModel gameView)
        {
            var game = new Game
            {
                HomePlayer = gameView.HomeName,
                AwayPlayer = gameView.AwayName,
                HomeGoals = gameView.HomeGoals,
                AwayGoals = gameView.AwayGoals,
                GroupId = gameView.GroupId
            };
            _gameService.UpdateGame(gameView.Id, game);
            return Ok();
        }
    }
}