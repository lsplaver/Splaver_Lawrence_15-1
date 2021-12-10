using BlackJack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Components
{
    public class Hand : ViewComponent
    {
        private IGame game { get; set; }
        public Hand(IGame g) => game = g;

        public IViewComponentResult Invoke(string handType)
        {
            HandViewModel vm = new HandViewModel();
            if (handType == "Player")
            {
                Models.Hand playerHand = game.Player.Hand;
                vm.HandType = "Player";
                vm.Hand = playerHand;
                return View("~/Views/Shared/Components/Hand/Hand.cshtml", vm);
            }
            else
            {
                Models.Hand dealerHand = game.Dealer.Hand;
                vm.HandType = "Dealer";
                vm.Hand = dealerHand;
                return View("~/Views/Shared/Components/Hand/Hand.cshtml", vm);
            }
        }
    }
}
