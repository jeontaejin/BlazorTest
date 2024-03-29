﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Theme.Material.TagHelpers
{
    public class AppTagHelperComponent : TagHelperComponent
    {
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "app",
                    StringComparison.OrdinalIgnoreCase) &&
                output.Attributes.ContainsName("wasm"))
            {
                output.PostContent.AppendHtml(@$"
<div class=""triangle-container"">
 <div class=""triangles"">
 </div>
</div>
<div class=""loading-container"">
 <img src=""{Module.ContentPath}/images/logo.svg"" alt=""Loading"" title=""Loading BlazorBoilerplate"" /><br />
  Loading BlazorBoilerplate WebAssemblies ...
</div>");
            }

            return Task.CompletedTask;
        }
    }
}
