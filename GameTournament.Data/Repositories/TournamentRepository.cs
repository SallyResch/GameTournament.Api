﻿using GameTournament.Core.Entities;
using GameTournament.Core.Repositories;
using GameTournament.Data.Data;
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

        public Task<bool> AnyAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tournament>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tournament> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Tournament tournament)
        {
            throw new NotImplementedException();
        }

        public void Update(Tournament tournament)
        {
            throw new NotImplementedException();
        }
    }
}
