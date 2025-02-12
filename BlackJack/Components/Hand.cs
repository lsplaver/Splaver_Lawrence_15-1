﻿using BlackJack.Models;
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

        public IViewComponentResult Invoke(string handType, object hand)
        {
            HandViewModel vm = new HandViewModel();
            if (handType == "Player")
            {
                Models.Hand playerHand = (Models.Hand)hand;
                vm.HandType = "Player";
                vm.Hand = playerHand;
                return View("~/Views/Shared/Components/Hand/Hand.cshtml", vm);
            }
            else
            {
                Models.Hand dealerHand = (Models.Hand)hand;
                vm.HandType = "Dealer";
                vm.Hand = dealerHand;
                return View("~/Views/Shared/Components/Hand/Hand.cshtml", vm);
            }
        }
    }
}
