using Foorball_Team_Data_Access.Interfaces;
using Football_Team_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foorball_Team_Data_Access.Repositories
{
    public class TeamRepo : IRepository<Team>
    {
        private readonly FootballTeamDB _db;
        public TeamRepo(FootballTeamDB db)
        {
            this._db = db;
        }
        public IEnumerable<Team> GetAll()
        {
            return this._db.Team;
        }
        public Team GetById(int id)
        {
            return _db.Team.SingleOrDefault(t => t.Id == id);
        }

        public int Add(Team entity)
        {
            _db.Team.Add(entity);
            return _db.SaveChanges();
        }

        public int Remove(int id)
        {
            var team = _db.Team.SingleOrDefault(t => t.Id == id);
            if (team == null)
                return -1;
            _db.Team.Remove(team);
            return _db.SaveChanges();
        }

        public int Update(Team entity)
        {
            _db.Team.Update(entity);
            return _db.SaveChanges();
        }
    }
}
