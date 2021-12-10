using BlackJack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Components
{
    public class PlayerHand : ViewComponent
    {
        private IGame game { get; set; }
        public PlayerHand(IGame g) => game = g;

        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Components/PlayerHand/PlayerHand.cshtml", game.Player.Hand);
        }
    }
}
