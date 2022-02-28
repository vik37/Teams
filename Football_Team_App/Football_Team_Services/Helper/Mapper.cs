using AutoMapper;
using Football_Team_Domain.Models;
using Football_Team_ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Team_Services.Helper
{
    public class MapperProfile : Profile 
    {
        public MapperProfile()
        {
            CreateMap<Team, TeamVM>()
                .ReverseMap();
            CreateMap<Player, PlayerVM>()
                .ReverseMap();
        }
    }
}
