#pragma checksum "C:\Users\Ibrahim\Source\Repos\LimakFinal\LimakAz\Views\Balance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6514533d66eef54656bb6ea67c5a7d91888ab348"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Balance_Index), @"mvc.1.0.view", @"/Views/Balance/Index.cshtml")]
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
#line 1 "C:\Users\Ibrahim\Source\Repos\LimakFinal\LimakAz\Views\_ViewImports.cshtml"
using LimakAz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ibrahim\Source\Repos\LimakFinal\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ibrahim\Source\Repos\LimakFinal\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ibrahim\Source\Repos\LimakFinal\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.Models.Settings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6514533d66eef54656bb6ea67c5a7d91888ab348", @"/Views/Balance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193bdce69418faf7fc4d341454722a3f16e70f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Balance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BalanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("AZN"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: white; box-shadow:none;outline:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onFocus", new global::Microsoft.AspNetCore.Html.HtmlString("value=\'\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IncreaseBalance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "balance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ibrahim\Source\Repos\LimakFinal\LimakAz\Views\Balance\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content -->
<div class=""col-sm-12 col-md-8 col-lg-9"">
    <div>
        <div class=""content"">
            <div class=""balance-orange"">
                <div class=""card order-item order-item-balance"">
                    <div class=""card-body"" style=""padding: 2rem !important;"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""balance-card"">
                                    <div class=""balance-card-header"">
                                        <div class=""balance-card-total"">
                                            <h3 class=""balance-card-title"">Balansım</h3>
                                            <div class=""balance-card-total-price"">
                                                <span>
                                                    ");
#nullable restore
#line 22 "C:\Users\Ibrahim\Source\Repos\LimakFinal\LimakAz\Views\Balance\Index.cshtml"
                                               Write(Model.Member.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <sup class=""manat"">₼</sup>
                                                </span>
                                            </div>
                                        </div>
                                        <div class=""balance-card-date"">
                                            <p>Son əlavə tarixi</p>
                                            <strong>2022-10-07</strong>
                                        </div>
                                    </div>
                                    <div class=""balance-card-body"">
                                        <p class=""balance-card-text"">
                                            Azərbaycana çatdırılma haqqının
                                            ödənilməsi və online kuryer sifarişi üçün balansınızı
                                            artıra
                                            bilərsiniz.
                                        </p>
                                        <h4 class=""balance-c");
            WriteLiteral(@"ard-note upper"">
                                            ARTIRILAN BALANS GERİ
                                            QAYTARILMIR.
                                        </h4>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""card order-item order-item-payment"">
                <div class=""card-body"">
                    <h3 class=""balance-payment-title"">
                        Ödəniş üçün balans artımı
                    </h3>
                    <div class=""row"">
                        <div class=""col-lg-6 col-12"">
                            <div class=""balance-payment-form"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6514533d66eef54656bb6ea67c5a7d91888ab3489452", async() => {
                WriteLiteral("\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-12\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6514533d66eef54656bb6ea67c5a7d91888ab3489879", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 61 "C:\Users\Ibrahim\Source\Repos\LimakFinal\LimakAz\Views\Balance\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Money);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>
                                    <button type=""submit""
                                            class=""btn btn-submit btn-block btn-primary"">
                                        Balansı artır
                                    </button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-lg-6 col-12"">
                            <div class=""balance-payment"">
                                <div class=""balance-payment-card"">
                                    <img src=""assets/images/visa-2.svg""");
            BeginWriteAttribute("alt", " alt=\"", 4133, "\"", 4139, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img src=\"assets/images/mastercard-2.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4220, "\"", 4226, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <p class=""balance-payment-text"">
                                    Min:
                                    <strong>1 USD</strong>
                                    - Max:
                                    <strong>50 USD</strong>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BalanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
