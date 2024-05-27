using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Core.Entities
{
    public class Tournament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string TournamentTitle { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<Game> Games { get; set; }
                = new List<Game>();

        public Tournament(string tournamentTitle)
        {
            TournamentTitle = tournamentTitle;
        }
        
    }
}
