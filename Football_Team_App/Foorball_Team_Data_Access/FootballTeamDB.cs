using Football_Team_Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foorball_Team_Data_Access
{
    public class FootballTeamDB : DbContext
    {
        public FootballTeamDB(DbContextOptions option) 
            : base(option) { }

        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
        }

        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasData(
                     new Player
                     {
                         Id = 1,
                         Firstname = "Zlatan",
                         Lastname = "Ibrahimovic",
                         DateOfBirth = "03-10-1981",
                         Value = 2500000.00
                     },
                     new Player
                     {
                         Id = 2,
                         Firstname = "Sandro",
                         Lastname = "Tonali",
                         DateOfBirth = "08-05-2000",
                         Value = 65000000.00
                     }
                );
            modelBuilder.Entity<Team>()
                .HasData(
                      new Team
                      {
                          Id = 1,
                          Name = "AC Milan",
                          City = "Milano",
                          Stadium = "San Siro",
                          FoundedYear = 1899,
                          History = "AC Milan was founded as Milan Foot-Ball and Cricket Club in 1899 by English expatriates Alfred Edwards and Herbert Kilpin. " +
                                      "The club claims 16 December of that year as their foundation date, but historical evidence seems to suggest that the club was actually" +
                                      " founded a few days earlier, most likely on 13 December."
                      }
                );
        }

    }
}
