using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GameTournament.Core.Entities;
using GameTournament.Core.Dto;


namespace GameTournament.Data.Data
{
    public class TournamentMappings : Profile
    {
        public TournamentMappings()
        {
            // Mapping from Tournament to TournamentDto
            CreateMap<Tournament, TournamentDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.TournamentTitle))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.StartDate.AddMonths(3).Date));

            // Mapping from Game to GameDto
            CreateMap<Game, GameDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.GameTitle))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.Time));
        }
    }
}
