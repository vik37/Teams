using Football_Team_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football_Team_App.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            this._teamService = teamService;
        }
        public IActionResult Index(int teamId)
        {
            var team = _teamService.Get(teamId);
            return View(team);
        }
    }
}
