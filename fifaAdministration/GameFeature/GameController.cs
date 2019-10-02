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
    }
}