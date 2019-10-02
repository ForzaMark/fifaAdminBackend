using fifaAdministration.Models;
using System.Linq;

namespace fifaAdministration.GameFeature
{
    public interface IGameService {
        Game[] GetAllGames();
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
    }
}
