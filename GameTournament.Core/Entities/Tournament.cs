using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Core.Entities
{
    public class Tournament
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(20, MinimumLength =3, ErrorMessage ="Must contain 3 - 20 letters")]
        public string? TournamentTitle { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<Game> Games { get; set; }
                = new List<Game>();
        
    }
}
