using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models.TagHelpers
{
    [HtmlTargetElement("my-temp-message")]
    public class TempMessageTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var tempData = viewContext.TempData;
            if (tempData.ContainsKey("message"))
            {
                output.BuildTag("h4", $"bg-{tempData["background"]} text-white p-2");
                output.Content.SetContent(tempData["message"].ToString());
            }
            else
            {
                output.SuppressOutput();
            }
        }
    }
}
