using GameTournament.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournament.Core.Repositories
{
    public interface ITournamentRepository
    {
        Task<IEnumerable<Tournament>> GetAllAsync();
        Task<Tournament> GetAsync(int id);
        Task<bool> AnyAsync(int id);
        void Add (Tournament tournament);
        void Update(Tournament tournament);
        void Remove (Tournament tournament);
    }
}
