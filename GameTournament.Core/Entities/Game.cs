using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Core.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public DateTime Time { get; set; }
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
    }
}
