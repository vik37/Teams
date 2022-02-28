using Football_Team_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football_Team_App.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            this._playerService = playerService;
        }
        public IActionResult Index()
        {
            var players = _playerService.GetAll().ToList();
            return View(players);
        }
    }
}
