using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameTournament.Core.Entities;

namespace GameTournament.Data.Data
{
    public class GameTournamentApiContext : DbContext
    {
        public GameTournamentApiContext (DbContextOptions<GameTournamentApiContext> options)
            : base(options)
        {
        }

        public DbSet<GameTournament.Core.Entities.Tournament> Tournament { get; set; } = default!;
        public DbSet<GameTournament.Core.Entities.Game> Game { get; set; } = default!;
    }
}
