using GameTournament.Core.Entities;
using GameTournament.Core.Repositories;
using GameTournament.Data.Data;
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

        public Task<bool> AnyAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Game>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Game> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Game game)
        {
            throw new NotImplementedException();
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
