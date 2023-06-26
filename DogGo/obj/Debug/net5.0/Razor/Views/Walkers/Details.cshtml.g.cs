#pragma checksum "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf8ad4d0050cf55fae6af3e03ac66ee64fb85f86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walkers_Details), @"mvc.1.0.view", @"/Views/Walkers/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\_ViewImports.cshtml"
using DogGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\_ViewImports.cshtml"
using DogGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8ad4d0050cf55fae6af3e03ac66ee64fb85f86", @"/Views/Walkers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b50fd1f91f777ae09abf39d99992ea9d25da6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Walkers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DogGo.Models.ViewModels.WalkerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n<div class=\"row flex-column\" style=\"margin-top:20px\">\r\n<h2 class=\"ml-0\">Walker Profile</h2>\r\n<div class=\"row\">\r\n    <img class=\"bg-info mr-5\"");
            BeginWriteAttribute("src", " src=\"", 261, "\"", 289, 1);
#nullable restore
#line 11 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
WriteAttributeValue("", 267, Model.Walker.ImageUrl, 267, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\" style=\"width:100px;height:100px\"/>\r\n            <dl class=\"row justify-content-between flex-column\" style=\"width:400px\">\r\n                <div class=\"row\" style=\"width:800px\">\r\n                    <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n                    <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n            </div>\r\n            <div class=\"row justify-content-between\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Walker.Neighborhood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Walker.Neighborhood.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
        </div>
    </dl>
    </div>
</div>
    <div class="" row justify-content-between"" style=""height:500px"">
    <div class=""row w-100 justify-content-between"" style=""margin-top:75px"">
<div class=""row flex-column"" style=""width:300px"">
");
#nullable restore
#line 35 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
      
        int totalTime = 0;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Recent Walks</h3>\r\n    <table>\r\n        <tr>\r\n            <th>Date</th>\r\n            <th>Client</th>\r\n            <th>Duration</th>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
     foreach (Walks walk in Model.Walks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n        <td>");
#nullable restore
#line 48 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
        Write(String.Format("{0:d}", @walk.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 49 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
       Write(walk.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 50 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
        Write(walk.Duration/60);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Mins</td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
            {
                totalTime += walk.Duration/60;
            }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 57 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
          
            int hours = totalTime / 60;
            int minutes = totalTime % 60;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"row justify-content-end\">\r\n    <h3>Total Walk Time: ");
#nullable restore
#line 63 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                     Write(hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hrs ");
#nullable restore
#line 63 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
                                  Write(minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Mins</h3>\r\n</div>\r\n\r\n</div>\r\n<div>\r\n    </div>\r\n    <div>\r\n    ");
#nullable restore
#line 70 "C:\Users\cwrai\workspace\DogGo\DogGo\Views\Walkers\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf8ad4d0050cf55fae6af3e03ac66ee64fb85f868753", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DogGo.Models.ViewModels.WalkerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
