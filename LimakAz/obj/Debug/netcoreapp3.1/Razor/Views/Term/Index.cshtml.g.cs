#pragma checksum "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\Term\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b440c93ef60dd8b103f71aad08bb0847752f418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Term_Index), @"mvc.1.0.view", @"/Views/Term/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\_ViewImports.cshtml"
using LimakAz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.Models.Settings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b440c93ef60dd8b103f71aad08bb0847752f418", @"/Views/Term/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10a6eeb31fee36ad6100b089d6d3f557358b4cc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Term_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Term>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""main-container"">
    <!-- Terms Start -->
    <section id=""terms"">
        <div class=""block"">
            <div class=""block-header"">
                <h2 class=""block-title"">Qaydalar</h2>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item"">
                        <a href=""index.html"">Ana səhifə</a>
                    </li>
                    <li class=""breadcrumb-item active"">
                        <span>Qaydalar</span>
                    </li>
                </ul>
            </div>
            <div class=""block-body"">
                <div class=""accordion"">
");
#nullable restore
#line 20 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\Term\Index.cshtml"
                     foreach (Term term in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 761, "\"", 839, 4);
            WriteAttributeValue("", 769, "content-box", 769, 11, true);
            WriteAttributeValue(" ", 780, "term-content-box", 781, 17, true);
            WriteAttributeValue(" ", 797, "mb-20", 798, 6, true);
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\Term\Index.cshtml"
WriteAttributeValue(" ", 803, term == Model[0] ? "active" : "", 804, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"label\">");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\Term\Index.cshtml"
                                          Write(term.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"content\" style=\"padding:0 4rem;\">\r\n                                <p>\r\n                                    ");
#nullable restore
#line 26 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\Term\Index.cshtml"
                               Write(Html.Raw(term.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\Term\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- Terms End -->\r\n</div>\r\n\r\n<script src=\"./assets/js/main.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Term>> Html { get; private set; }
    }
}
#pragma warning restore 1591
