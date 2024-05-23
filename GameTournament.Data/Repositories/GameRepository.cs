using GameTournament.Core.Entities;
using GameTournament.Core.Repositories;
using GameTournament.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Data.Repositories
{
    internal class GameRepository : IGameRepository
    {
        private readonly GameTournamentApiContext _context;

        public GameRepository(GameTournamentApiContext context)
        {
            _context = context;
        }
        public void Add(Game game)
        {
            throw new NotImplementedException();
        }
        public async Task AddAsync(Game game)
        {
            await _context.Game.AddAsync(game);
        }
        public Task<bool> AnyAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await _context.Game.ToListAsync();
        }

        public async Task<Game> GetAsync(int id)
        {
            return await _context.Game.FindAsync(id);
        }

        public void Remove(Game game)
        {
            _context.Game.Remove(game);
        }

        public void Update(Game game)
        {
            _context.Entry(game).State = EntityState.Modified;
        }
    }
}
