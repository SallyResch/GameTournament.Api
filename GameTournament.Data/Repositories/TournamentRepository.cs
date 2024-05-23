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
    internal class TournamentRepository : ITournamentRepository
    {
        private readonly GameTournamentApiContext _context;

        public TournamentRepository(GameTournamentApiContext context)
        {
            _context = context;
        }
        public void Add(Tournament tournament)
        {
            throw new NotImplementedException();
        }
        public async Task AddAsync(Tournament tournament)
        {
            await _context.Tournament.AddAsync(tournament);
        }
        public async Task<bool> AnyAsync(int id)
        {
            return await _context.Tournament.AnyAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Tournament>> GetAllAsync()
        {
            return await _context.Tournament.ToListAsync();
        }

        public async Task<Tournament> GetAsync(int id)
        {
            return await _context.Tournament.FindAsync(id);
        }

        public void Remove(Tournament tournament)
        {
            _context.Tournament.Remove(tournament);
        }

        public void Update(Tournament tournament)
        {
            _context.Entry(tournament).State = EntityState.Modified;
        }
    }
}
