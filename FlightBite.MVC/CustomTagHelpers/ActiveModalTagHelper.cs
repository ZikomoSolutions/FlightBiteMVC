using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FlightBite.MVC.CustomTagHelpers
{
    [HtmlTargetElement(Attributes = "is-modal-section-active")]
    public class ActiveModalTagHelper : TagHelperComponent
    {
        public ActiveModalTagHelper(IHtmlGenerator generator) 
        {

        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            var existingClasses = output.Attributes["class"].Value.ToString();

            if (output.Attributes["class"] != null)
            {
                output.Attributes.Remove(output.Attributes["class"]);
            }
            output.Attributes.Add("class", $"{existingClasses} show");



        }



    }
}
