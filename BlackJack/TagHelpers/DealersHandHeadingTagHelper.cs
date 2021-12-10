using BlackJack.Models;
using BlackJack.Models.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.TagHelpers
{
    [HtmlTargetElement("dealer-heading")]
    public class DealersHandHeadingTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string dealerHeader = "Dealer";
            var game = viewContext.ViewData.Model as Game;
            Dealer dealer = game.Dealer;
            if (dealer.MustShowCards)
            {
                dealerHeader = $"{dealerHeader}: {dealer.Hand.Total}";
                output.BuildTag("h5");
                output.Content.SetContent(dealerHeader);
            }
            else
            {
                output.BuildTag("h5");
                output.Content.SetContent(dealerHeader);
            }
        }
    }
}
