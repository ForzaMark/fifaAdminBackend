using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaAdministration.Features.Games.Representation
{
    public class GameEditViewModel
    {
        public int Id { get; set; }
        public string HomeName { get; set; }
        public string AwayName { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public int GroupId { get; set; }
    }
}
