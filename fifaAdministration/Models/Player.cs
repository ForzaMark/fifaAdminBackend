using System.Collections.Generic;

namespace fifaAdministration.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}
