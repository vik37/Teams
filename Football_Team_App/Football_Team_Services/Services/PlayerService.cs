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
    public class PlayerService : IPlayerService
    {
        private readonly IRepository<Player> _playerRepo;
        private readonly IMapper _mapper;
        public PlayerService(IRepository<Player> playerRepo,IMapper mapper)
        {
            this._playerRepo = playerRepo;
            this._mapper = mapper;
        }
        public IEnumerable<PlayerVM> GetAll()
        {
            var players = _playerRepo.GetAll().ToList();
            return _mapper.Map<IEnumerable<Player>, IEnumerable<PlayerVM>>(players);
        }
        public void AddNewPlayer(PlayerVM entity)
        {
            try
            {
                var player = _mapper.Map<Player>(entity);
                _playerRepo.Add(player);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        
    }
}
