using System.ComponentModel.DataAnnotations.Schema;

namespace fifaAdministration.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }

        [ForeignKey(nameof(HomePlayer))]
        public int? HomePlayerId { get; set; }

        public virtual Player HomePlayer { get; set; }

        //[ForeignKey(nameof(AwayPlayer))]
        //public int? AwayPlayerId { get; set; }

        //public virtual Player AwayPlayer { get; set; }
    }
}
