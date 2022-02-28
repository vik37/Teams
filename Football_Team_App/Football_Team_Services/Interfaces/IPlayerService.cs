using Football_Team_ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Team_Services.Interfaces
{
    public interface IPlayerService
    {
        IEnumerable<PlayerVM> GetAll();
        void AddNewPlayer(PlayerVM entity);
        
    }
}
