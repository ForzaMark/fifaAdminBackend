using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace fifaAdministration.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Group))]
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
