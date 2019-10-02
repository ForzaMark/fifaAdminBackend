namespace fifaAdministration.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
    }
}
