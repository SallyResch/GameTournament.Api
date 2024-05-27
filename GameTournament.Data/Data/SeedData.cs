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
            using (var context = new GameTournamentApiContext(serviceProvider.GetRequiredService<DbContextOptions<GameTournamentApiContext>>()))
            {
                if (context.Tournament.Any())
                {
                    return;
                }

                var tournaments = new List<Tournament>
                {
                    new Tournament("Spring Championship")
                    {
                        StartDate = new DateTime(2024, 5, 20),
                        Games = new List<Game>
                        {
                            new Game { GameTitle = "Game 1", Time = new DateTime(2024, 5, 21) },
                            new Game { GameTitle = "Game 2", Time = new DateTime(2024, 5, 22) }
                        }
                    },
                    new Tournament("Summer Cup")
                    {
                        StartDate = new DateTime(2024, 6, 15),
                        Games = new List<Game>
                        {
                            new Game { GameTitle = "Game 3", Time = new DateTime(2024, 6, 16) },
                            new Game { GameTitle = "Game 4", Time = new DateTime(2024, 6, 17) }
                        }
                    },
                     new Tournament("Winter Cup")
                    {
                        StartDate = new DateTime(2024, 02, 10),
                        Games = new List<Game>
                        {
                            new Game { GameTitle = "Game 5", Time = new DateTime(2024, 7, 16) },
                            new Game { GameTitle = "Game 6", Time = new DateTime(2024, 7, 17) }
                        }
                    },
                      new Tournament("Fall Cup")
                    {
                        StartDate = new DateTime(2025, 4, 10),
                        Games = new List<Game>
                        {
                            new Game { GameTitle = "Game 7", Time = new DateTime(2025, 4, 11) },
                            new Game { GameTitle = "Game 8", Time = new DateTime(2025, 4, 12) }
                        }
                    }
                };

                context.Tournament.AddRange(tournaments);
                await context.SaveChangesAsync();
            }
        }
    }
}
