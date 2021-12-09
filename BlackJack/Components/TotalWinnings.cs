using BlackJack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Components
{
    public class TotalWinnings : ViewComponent
    {
        private IGame game { get; set; }
        public TotalWinnings(IGame g) => game = g;

        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Components/TotalWinnings/TotalWinnings.cshtml", game.Player.TotalWinnings);
        }
    }
}
