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
    [RestrictChildren("deal-button", "hit-button", "stand-button")]
    public class DealHitStandButtonTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string action = (string)context.AllAttributes["asp-action"].Value.ToString();
            
            if (action == "Deal")
            {
                output.BuildTag("form", "action", "Home/Deal", "method", "post", "col");
            }
            else if (action == "Hit")
            {
                output.BuildTag("form", "action", "Home/Hit", "method", "post", "col");
            }
            else
            {
                output.BuildTag("form", "action", "Home/Stand", "method", "post", "col");
            }
        }
    }
}
