using Foorball_Team_Data_Access.Interfaces;
using Football_Team_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foorball_Team_Data_Access.Repositories
{
    public class PlayerRepo : IRepository<Player>
    {
        private readonly FootballTeamDB _db;
        public PlayerRepo(FootballTeamDB db)
        {
            this._db = db;
        }
        public IEnumerable<Player> GetAll()
        {
            return this._db.Player;
        }
        public Player GetById(int id)
        {
            return _db.Player.SingleOrDefault(t => t.Id == id);
        }      
        
        public int Add(Player entity)
        {
            _db.Player.Add(entity);
            return _db.SaveChanges();
        }

        public int Remove(int id)
        {
            var player = _db.Player.SingleOrDefault(t => t.Id == id);
            if (player == null)
                return -1;
            _db.Player.Remove(player);
            return _db.SaveChanges();
        }

        public int Update(Player entity)
        {
            _db.Player.Update(entity);
            return _db.SaveChanges();
        }
    }
}
