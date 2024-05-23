using GameTournament.Core.Repositories;
using GameTournament.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Data.Repositories
{
    public class UoWRepository : IUoWRepository
    {
        private readonly GameTournamentApiContext _context;
        private ITournamentRepository _tournamentRepository;
        private IGameRepository _gameRepository;
        public UoWRepository(GameTournamentApiContext context)
        {
            _context = context;
        }
        public ITournamentRepository TournamentRepository
        {
            get
            {
                if (_tournamentRepository == null)
                {
                    _tournamentRepository = new TournamentRepository(_context);
                }
                return _tournamentRepository;
            }
        }

        public IGameRepository GameRepository
        {
            get
            {
                if (_gameRepository == null)
                {
                    _gameRepository = new GameRepository(_context);
                }
                return _gameRepository;
            }
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
