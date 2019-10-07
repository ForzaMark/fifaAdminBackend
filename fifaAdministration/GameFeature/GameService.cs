using fifaAdministration.Models;
using System.Linq;

namespace fifaAdministration.GameFeature
{
    public interface IGameService {
        Game[] GetAllGames();
        void PostNewGame(Game game);
        Game UpdateGame(Game game);
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

        public Game UpdateGame(Game game)
        {
            var toUpdateGame = context.Games.FirstOrDefault(g => g.Home == game.Home && g.Away == game.Away);
            toUpdateGame.AwayGoals = game.AwayGoals;
            toUpdateGame.HomeGoals = game.HomeGoals;
            context.SaveChanges();
            return game;
        }
    }
}
