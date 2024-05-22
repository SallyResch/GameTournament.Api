using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Core.Repositories
{
    public interface IUoWRepository
    {
        ITournamentRepository TournamentRepository { get; }
        IGameRepository GameRepository { get; }

        Task CompleteAsync();
    }
}
