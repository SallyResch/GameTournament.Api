using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Core.Entities
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string? GameTitle { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("TournamentId")]
        public Tournament? Tournament { get; set; }
        public int TournamentId { get; set; }
    }
}
