using fifaAdministration.Models;
using System.Linq;

namespace fifaAdministration.GameFeature
{
    public interface IGameService {
        Game[] GetAllGames();
        void PostNewGame(Game game);
        Game UpdateGame(int id, Game game);
    }

    public class GameService : IGameService
    {
        private readonly FifaDbContext context;

        public GameService(FifaDbContext _context)
        {
            context = _context;
        }

        public Game[] GetAllGames()
        {
            return context.Games.ToArray();
        }

        public void PostNewGame(Game game)
        {
            context.Games.Add(game);
            context.SaveChanges();
        }

        public Game UpdateGame(int id, Game game)
        {
            var existingGame = context.Games.FirstOrDefault(g => g.Id == id);
            existingGame.HomePlayer = game.HomePlayer;
            existingGame.AwayPlayer = game.AwayPlayer;
            existingGame.HomeGoals = game.HomeGoals;
            existingGame.AwayGoals = game.AwayGoals;
            existingGame.GroupId = game.GroupId;
            context.SaveChanges();
            return new Game();
        }
    }
}
