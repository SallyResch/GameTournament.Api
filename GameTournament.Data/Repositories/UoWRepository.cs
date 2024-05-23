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
        public UoWRepository(GameTournamentApiContext context)
        {
            _context = context;
        }

        public ITournamentRepository TournamentRepository => throw new NotImplementedException();

        public IGameRepository GameRepository => throw new NotImplementedException();

        public Task CompleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
