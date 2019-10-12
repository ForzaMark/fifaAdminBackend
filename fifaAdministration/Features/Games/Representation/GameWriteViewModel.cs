using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaAdministration.GameFeature.Representation
{
    public class GameWriteViewModel
    {
        public string HomeName { get; set; }
        public string AwayName { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public int GroupId { get; set; }
    }
}
