using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AllOverRepeat.CustomTagHelpers
{
    public class CusLinkTagHelper:TagHelper
    {
        public string Controller { get; set; }
        public string Action { get; set; } = null;
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            if (Action == null)
            {
                output.Attributes.SetAttribute("href", $"/{Controller}/");
            }
            else
            {
                output.Attributes.SetAttribute("href", $"/{Controller}/{Action}");
            }
        }
    }
}
