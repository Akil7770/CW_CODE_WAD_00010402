#pragma checksum "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a63da4b131cd2560eff9b5d490e274f9a1ab5a6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deliveries_Details), @"mvc.1.0.view", @"/Views/Deliveries/Details.cshtml")]
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
#line 1 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\_ViewImports.cshtml"
using MediaPark;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\_ViewImports.cshtml"
using MediaPark.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63da4b131cd2560eff9b5d490e274f9a1ab5a6c", @"/Views/Deliveries/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b127954e7dc45bf571c3276de422b737318bf21d", @"/Views/_ViewImports.cshtml")]
    public class Views_Deliveries_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MediaPark.Models.Delivery>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<p>00010402</p>\r\n\r\n<div>\r\n    <h4>Delivery</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>Customer Name</th>\r\n                    <th>Review</th>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
                 foreach (var item in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Branch.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Review));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63da4b131cd2560eff9b5d490e274f9a1ab5a6c8312", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\The_OQIL )))))\Desktop\Новая папка (2)\MediaPark\WAD_CW_CODE_00010402\Views\Deliveries\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63da4b131cd2560eff9b5d490e274f9a1ab5a6c10485", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaPark.Models.Delivery> Html { get; private set; }
    }
}
#pragma warning restore 1591
