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
    [HtmlTargetElement("stand-button", Attributes = "data")]
    public class StandButtonTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        [HtmlAttributeName("data")]
        public ModelExpression Source { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string needsDeal = Source.Model.ToString();

            if (needsDeal != "True")
            {
                output.BuildTag("button", "type", "submit", "btn btn-primary", "Stand");
            }
            else
            {
                output.BuildTag("button", "type", "submit", "btn btn-primary", "disabled", "true", "Stand");
            }
        }
    }
}
