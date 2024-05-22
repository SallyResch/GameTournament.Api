using GameTournament.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Data.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using (var context = new GameTournamentApiContext(
                serviceProvider.GetRequiredService<DbContextOptions<GameTournamentApiContext>>()))
            {
                // Look for any Tournaments.
                if (context.Tournament.Any())
                {
                    return;   // DB has been seeded
                }

                var tournaments = new List<Tournament>
                {
                    new Tournament
                    {
                        TournamentTitle = "Spring Championship",
                        StartDate = new DateTime(2024, 5, 20),
                        Games = new List<Game>
                        {
                            new Game { GameTitle = "Game 1", Time = new DateTime(2024, 5, 21) },
                            new Game { GameTitle = "Game 2", Time = new DateTime(2024, 5, 22) }
                        }
                    },
                    new Tournament
                    {
                        TournamentTitle = "Summer Cup",
                        StartDate = new DateTime(2024, 6, 15),
                        Games = new List<Game>
                        {
                            new Game { GameTitle = "Game 3", Time = new DateTime(2024, 6, 16) },
                            new Game { GameTitle = "Game 4", Time = new DateTime(2024, 6, 17) }
                        }
                    }
                };

                context.Tournament.AddRange(tournaments);
                await context.SaveChangesAsync();
            }
        }
    }
}
