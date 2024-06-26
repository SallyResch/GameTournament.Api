﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameTournament.Data.Data;
using GameTournament.Core.Entities;
using GameTournament.Core.Repositories;
using AutoMapper;
using GameTournament.Core.Dto;

namespace GameTournament.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentsController : ControllerBase
    {
        //private readonly GameTournamentApiContext _context;

        /* public TournamentsController(GameTournamentApiContext context)
         {
             _context = context;
         }*/


       


        private readonly IUoWRepository _uowRepository;
        private readonly IMapper _mapper;
        public TournamentsController (IUoWRepository uowRepository, IMapper mapper)
        {
            _uowRepository = uowRepository;
            _mapper = mapper;
        }

        /*// GET: api/Tournaments
       [HttpGet]
       public async Task<ActionResult<IEnumerable<Tournament>>> GetTournament()
       {
           return await _context.Tournament.ToListAsync();
       }
       */
        // GET ALL TOURNAMENTS: api/Tournaments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TournamentDto>>> GetTournaments()
        {
            var tournaments = await _uowRepository.TournamentRepository.GetAllAsync();
            return Ok(tournaments);
        }

        // GET SPECIFIC TOURNAMENT: api/Tournaments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TournamentDto>> GetTournament(int id)
        {
            var tournament = await _uowRepository.TournamentRepository.GetAsync(id);

            if (tournament == null)
            {
                return NotFound();
            }

            return Ok(tournament);
        }

        /* // PUT: api/Tournaments/5
         // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
         [HttpPut("{id}")]
         public async Task<IActionResult> PutTournament(int id, Tournament tournament)
         {
             if (id != tournament.Id)
             {
                 return BadRequest();
             }

             _context.Entry(tournament).State = EntityState.Modified;

             try
             {
                 await _context.SaveChangesAsync();
             }
             catch (DbUpdateConcurrencyException)
             {
                 if (!TournamentExists(id))
                 {
                     return NotFound();
                 }
                 else
                 {
                     throw;
                 }
             }

             return NoContent();
         }*/
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTournament(int id, Tournament tournament)
        {
            if (id != tournament.Id)
            {
                return BadRequest();
            }

            _uowRepository.TournamentRepository.Update(tournament);

            try
            {
                await _uowRepository.CompleteAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TournamentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /*// POST: api/Tournaments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tournament>> PostTournament(Tournament tournament)
        {
            _context.Tournament.Add(tournament);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTournament", new { id = tournament.Id }, tournament);
        }
        */

        // POST: api/Tournaments
        [HttpPost]
        public async Task<ActionResult<TournamentDto>> PostTournament(Tournament tournament)
        {
            await _uowRepository.TournamentRepository.AddAsync(tournament);
            await _uowRepository.CompleteAsync();

            return CreatedAtAction("GetTournament", new { id = tournament.Id }, tournament);
        }

        /*// DELETE: api/Tournaments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTournament(int id)
        {
            var tournament = await _context.Tournament.FindAsync(id);
            if (tournament == null)
            {
                return NotFound();
            }

            _context.Tournament.Remove(tournament);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */

        // DELETE: api/Tournaments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTournament(int id)
        {
            var tournament = await _uowRepository.TournamentRepository.GetAsync(id);
            if (tournament == null)
            {
                return NotFound();
            }

            _uowRepository.TournamentRepository.Remove(tournament);
            await _uowRepository.CompleteAsync();

            return NoContent();
        }
        /* private bool TournamentExists(int id)
        {
            return _context.Tournament.Any(e => e.Id == id);
        }
       */
        private async Task<bool> TournamentExists(int id)
        {
            var tournament = await _uowRepository.TournamentRepository.GetAsync(id);
            return tournament != null;
        }
    }
}
