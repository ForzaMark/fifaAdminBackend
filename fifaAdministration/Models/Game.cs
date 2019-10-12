using System.ComponentModel.DataAnnotations.Schema;

namespace fifaAdministration.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public string HomePlayer { get; set; }
        public string AwayPlayer { get; set; }

        [ForeignKey(nameof(Group))]
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
