using AutoMapper;
using Foorball_Team_Data_Access.Interfaces;
using Football_Team_Domain.Models;
using Football_Team_Services.Interfaces;
using Football_Team_ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Team_Services.Services
{
    public class TeamService : ITeamService
    {
        private readonly IRepository<Team> _teamRepo;
        private readonly IMapper _mapper;
        public TeamService(IRepository<Team> teamRepo, IMapper mapper)
        {
            this._teamRepo = teamRepo;
            this._mapper = mapper;

        }
        public TeamVM Get(int id)
        {
            try
            {
                var team = _teamRepo.GetById(id);
                if(team == null)
                {
                    throw new Exception("Team does not exist!");
                }
                return _mapper.Map<TeamVM>(team);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
