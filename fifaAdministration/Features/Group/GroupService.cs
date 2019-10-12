using fifaAdministration.Models;
using System.Linq;

namespace fifaAdministration.Features.Group
{
    public interface IGroupService
    {
        Game[] GetGamesOfGroup(int GroupId); 
    }

    public class GroupService : IGroupService
    {
        private readonly FifaDbContext context;

        public GroupService(FifaDbContext _context)
        {
            context = _context;
        }

        public Game[] GetGamesOfGroup(int GroupId)
        {
            var test = context.Games.Where(g => g.GroupId == GroupId);
            return test.ToArray();
        }
    }
}
