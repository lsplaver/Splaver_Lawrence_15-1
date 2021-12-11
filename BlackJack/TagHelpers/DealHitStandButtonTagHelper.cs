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
    [HtmlTargetElement("deal-hit-stand")]
    public class DealHitStandButtonTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        [HtmlAttributeNotBound]
        private IGame game { get; set; }
        public DealHitStandButtonTagHelper(IGame g) => game = g;

        public bool NeedsDeal()
        {
            bool NeedsDeal = false;
            if (!game.Dealer.Hand.HasCards && !game.Player.Hand.HasCards)
            {
                NeedsDeal = true;
            }
            return NeedsDeal;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string action = (string)context.AllAttributes["asp-action"].Value.ToString();
            
            if (action == "Deal")
            {
                output.Attributes.Clear();
                //output.Content.Clear();
                output.BuildOpenTag("form", "asp-action", "Deal", "method", "post", "col");
                if (NeedsDeal())
                {
                    output.Attributes.Clear();
                    //output.Content.Clear();
                    output.BuildTag("button", "type", "submit", "btn btn-primary", "Deal");
                }
                else
                {
                    output.Attributes.Clear();
                    //output.Content.Clear();
                    output.BuildTag("button", "type", "submit", "btn btn-primary", "disabled", "true", "Deal");
                }
                output.Attributes.Clear();
                //output.Content.Clear();
                output.BuildClosingTag("/form");
            }

            if (action == "Hit")
            {
                //output.Attributes.Clear();
                //output.Content.Clear();
                output.BuildOpenTag("form", "asp-action", "Hit", "method", "post", "col");
                if (!NeedsDeal())
                {
                    //output.Attributes.Clear();
                    //output.Content.Clear();
                    output.BuildTag("button", "type", "submit", "btn btn-primary", "Hit");
                }
                else
                {
                    //output.Attributes.Clear();
                    //output.Content.Clear();
                    output.BuildTag("button", "type", "submit", "btn btn-primary", "disabled", "true", "Hit");
                }
                //output.Attributes.Clear();
                //output.Content.Clear();
                //output.BuildClosingTag("/form");
            }

            if (action == "Stand")
            {
                //output.Attributes.Clear();
                //output.Content.Clear();
                output.BuildOpenTag("form", "asp-action", "Stand", "method", "post", "col");
                if (!NeedsDeal())
                {
                    //output.Attributes.Clear();
                    //output.Content.Clear();
                    output.BuildTag("button", "type", "submit", "btn btn-primary", "Stand");
                }
                else
                {
                    //output.Attributes.Clear();
                    //output.Content.Clear();
                    output.BuildTag("button", "type", "submit", "btn btn-primary", "disabled", "true", "Stand");
                }
                //output.Attributes.Clear();
                //output.Content.Clear();
                //output.BuildClosingTag("/form");
            }
        }
    }
}
