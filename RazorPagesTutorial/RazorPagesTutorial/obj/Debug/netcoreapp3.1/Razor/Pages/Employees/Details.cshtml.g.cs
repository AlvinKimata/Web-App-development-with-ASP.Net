#pragma checksum "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/Employees/Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c340f1db0dd53a419d7183ae10ed6e40d5e57690a28e5c2d472184ca5b599851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesTutorial.Pages.Employees.Pages_Employees_Details), @"mvc.1.0.razor-page", @"/Pages/Employees/Details.cshtml")]
namespace RazorPagesTutorial.Pages.Employees
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/_ViewImports.cshtml"
using RazorPagesTutorial;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c340f1db0dd53a419d7183ae10ed6e40d5e57690a28e5c2d472184ca5b599851", @"/Pages/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fe5cebe49655dec7dabac185dac865dc51b765504ccb6160510bb688b7db18e6", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Employees_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/Employees/Details.cshtml"
  
    ViewData["Title"] = "Employee page.";
    var photoPath = "~/images/" + (Model.Employee.PhotoPath) ?? "noimage.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row justify-content-center m-3\">\n    <div class=\"col-sm-8\">\n        <div class=\"card\">\n            <div class=\"card-header\">\n                <h1>");
#nullable restore
#line 12 "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/Employees/Details.cshtml"
               Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n\n            <div class=\"card-body text-center\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c340f1db0dd53a419d7183ae10ed6e40d5e57690a28e5c2d472184ca5b5998515183", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/Employees/Details.cshtml"
                                   WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/Employees/Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                <h4>Employee ID : ");
#nullable restore
#line 18 "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/Employees/Details.cshtml"
                             Write(Model.Employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                <h4>Email : ");
#nullable restore
#line 19 "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/Employees/Details.cshtml"
                       Write(Model.Employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                <h4>Department : ");
#nullable restore
#line 20 "/home/debonair/Documents/web/Web-App-development-with-ASP.Net/RazorPagesTutorial/RazorPagesTutorial/Pages/Employees/Details.cshtml"
                            Write(Model.Employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n            </div>\n            <div class=\"card-footer text-center\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c340f1db0dd53a419d7183ae10ed6e40d5e57690a28e5c2d472184ca5b5998518479", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <a href=\"#\" class=\"btn btn-primary\">Back</a>\n");
            WriteLiteral("                <a href=\"#\" class=\"btn btn-danger\">Delete</a>\n            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesTutorial.Pages.Employees.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesTutorial.Pages.Employees.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesTutorial.Pages.Employees.DetailsModel>)PageContext?.ViewData;
        public RazorPagesTutorial.Pages.Employees.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
