using BlackJack.Models;
using BlackJack.Models.TagHelpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlackJack.Models.Game;

namespace BlackJack.TagHelpers
{
    [HtmlTargetElement("deal-button", Attributes = "data")]
    public class DealButtonTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        [HtmlAttributeName("data")]
        public ModelExpression Source { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string needsDeal = Source.Model.ToString();

            if (needsDeal == "True")
            {
                output.BuildTag("button", "type", "submit", "btn btn-primary", "Deal");
            }
            else
            {
                output.BuildTag("button", "type", "submit", "btn btn-primary", "disabled", "true", "Deal");
            }
        }
    }
}
