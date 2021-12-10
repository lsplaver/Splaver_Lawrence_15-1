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

        public IViewComponentResult Invoke(IGame game)
        {
            foreach(Card card in game.Player.Hand.Cards)
            {
                //< img src = "~/images/@(card.Name).svg" />
                
            }
            

            return View("~/Views/Home/Components/PlayerHand/PlayerHand.cshtml");
        }
    }
}
