#pragma checksum "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830d6cd8c6fa6b414988dcf6883e9549e98371ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models.About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"830d6cd8c6fa6b414988dcf6883e9549e98371ab", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a882f9b0c3708055c97f6c0bdf68a5669842ea9", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <ol>
                <li><a href=""index.html"">Home</a></li>
                <li>Services</li>
            </ol>
            <h2>Services</h2>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Services Section ======= -->
    <section id=""services"" class=""services"">
        <div class=""container"">

            <div class=""row"">
");
#nullable restore
#line 21 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
                 foreach (Service service in Model.Services)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                        <div class=\"icon-box\">\r\n                            <div class=\"icon\">");
#nullable restore
#line 25 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
                                         Write(Html.Raw(service.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "830d6cd8c6fa6b414988dcf6883e9549e98371ab5320", async() => {
#nullable restore
#line 26 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
                                        Write(service.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 27 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
                          Write(service.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 30 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

        </div>
    </section><!-- End Services Section -->
    <!-- ======= Our Skills Section ======= -->
    <section id=""skills"" class=""skills"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Our Skills</h2>
                <p>");
#nullable restore
#line 41 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
              Write(Model.Skill.ContentHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-6\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1486, "\"", 1521, 2);
            WriteAttributeValue("", 1492, "assets/img/", 1492, 11, true);
#nullable restore
#line 46 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
WriteAttributeValue("", 1503, Model.Skill.Image, 1503, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1540, "\"", 1546, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-lg-6 pt-4 pt-lg-0 content\">\r\n                    <h3>");
#nullable restore
#line 49 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
                   Write(Model.Skill.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"fst-italic\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\Nicat\Desktop\P224\ASP-NET\Eterna\WebApplication2\WebApplication2\Views\Services\Index.cshtml"
                   Write(Model.Skill.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>

                    <div class=""skills-content"">

                        <div class=""progress"">
                            <span class=""skill"">HTML <i class=""val"">100%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">CSS <i class=""val"">90%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">JavaScript <i class=""val"">75%</i></");
            WriteLiteral(@"span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">Photoshop <i class=""val"">55%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>

        </div>
    </section><!-- End Our Skills Section -->

</main><!-- End #main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceVM> Html { get; private set; }
    }
}
#pragma warning restore 1591