using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Core.Dto
{
    internal class TournamentDto
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TournamentDto() 
        {
            StartDate = DateTime.Now;
            EndDate = StartDate.AddMonths(3).Date;
        }
    }
}
