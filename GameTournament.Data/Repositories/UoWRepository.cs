using GameTournament.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Data.Repositories
{
    internal class UoWRepository : IUoWRepository
    {
        public ITournamentRepository TournamentRepository => throw new NotImplementedException();

        public IGameRepository GameRepository => throw new NotImplementedException();

        public Task CompleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
