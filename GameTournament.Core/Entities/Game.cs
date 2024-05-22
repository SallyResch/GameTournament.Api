using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Core.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? GameTitle { get; set; }
        public DateTime Time { get; set; }
        public int TournamentId { get; set; }
        public Tournament? Tournament { get; set; }
    }
}
