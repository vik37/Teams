using Foorball_Team_Data_Access;
using Foorball_Team_Data_Access.Interfaces;
using Foorball_Team_Data_Access.Repositories;
using Football_Team_Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Team_Services.Helper
{
    public static class DIModule
    {
        public static IServiceCollection REgisterModules(string connectionString, IServiceCollection services)
        {
            services.AddDbContext<FootballTeamDB>(opt=>opt.UseSqlServer(connectionString));

            services.AddTransient<IRepository<Team>, TeamRepo>();
            services.AddTransient <IRepository<Player>, PlayerRepo>();

            return services;
        }
    }
}
