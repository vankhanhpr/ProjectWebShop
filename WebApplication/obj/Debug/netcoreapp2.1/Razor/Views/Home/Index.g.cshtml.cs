#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2128b7302d5b97a8bf5cf6fc20350a601eaa4abd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#line 2 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2128b7302d5b97a8bf5cf6fc20350a601eaa4abd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/userhome.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(105, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(111, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "779934280ac840ae82115749c6864523", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(172, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(177, 410, true);
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""k main-form"">
        <div class=""k bg-slider""></div>
        <div class=""k f-dt-note"">
            <span class="" t bf-t-note""></span>
            <span class="" t t-f-favr"">MÓN ĂN NỔI BẬT</span>
            <span class="" t bf-t-note""></span>
        </div>
        <div class=""k bd-main-it"">
            <div class=""k main-it-lv2"">

            </div>
");
            EndContext();
            BeginContext(1238, 543, true);
            WriteLiteral(@"            <div class=""k owl-dots"">
                <div class=""owl-dot"">
                    <span></span>
                </div>
                <div class=""owl-dot"">
                    <span></span>
                </div>
            </div>
        </div>

        <div class=""k f-dt-note"">
            <span class="" t bf-t-note""></span>
            <span class="" t t-f-favr"">MÓN ĂN ĐƯỢC YÊU THÍCH</span>
            <span class="" t bf-t-note""></span>
        </div>
        <div class=""k bd-main-it"" id=""bd-pr-favorite"">
");
            EndContext();
            BeginContext(2439, 3027, true);
            WriteLiteral(@"        </div>

        <div class=""k f-new-pdt"">
            <div class=""k f-dt-note"">
                <span class="" t bf-t-note t-new-pdt-line""></span>
                <span class="" t t-f-favr t-new-pdt"">MÓN ĂN MỚI</span>
                <span class="" t bf-t-note t-new-pdt-line""></span>
            </div>
            <div class=""k bd-main-it"">
                <div class=""k bd-id-new"">
                    <div class=""k body-it-new"">
                        <div class=""k img-it-new""></div>
                        <div class=""k f-note-inf"">
                            <span class=""k t t-name-it-new"">Bánh bông lan </span>
                            <span class=""k t t-price-it"">30.000₫ </span>
                            <span class=""k t t-inf-it"">Đây là 1 sản phẩm đặc biệt ra mắt nhằm hưởng ứng hội nghị thưởng đỉnh 2 nước Triều Tiên - Mỹ </span>
                        </div>
                    </div>
                </div>
                <div class=""k bd-id-new"">
                    <div");
            WriteLiteral(@" class=""k body-it-new"">
                        <div class=""k img-it-new""></div>
                        <div class=""k f-note-inf"">
                            <span class=""k t t-name-it-new"">Bánh bông lan </span>
                            <span class=""k t t-price-it"">30.000₫ </span>
                            <span class=""k t t-inf-it"">Đây là 1 sản phẩm đặc biệt ra mắt nhằm hưởng ứng hội nghị thưởng đỉnh 2 nước Triều Tiên - Mỹ </span>
                        </div>
                    </div>
                </div>
                <div class=""k bd-id-new"">
                    <div class=""k body-it-new"">
                        <div class=""k img-it-new""></div>
                        <div class=""k f-note-inf"">
                            <span class=""k t t-name-it-new"">Bánh bông lan </span>
                            <span class=""k t t-price-it"">30.000₫ </span>
                            <span class=""k t t-inf-it"">Đây là 1 sản phẩm đặc biệt ra mắt nhằm hưởng ứng hội nghị thưởng đỉnh 2 nước ");
            WriteLiteral(@"Triều Tiên - Mỹ </span>
                        </div>
                    </div>
                </div>
                <div class=""k bd-id-new"">
                    <div class=""k body-it-new"">
                        <div class=""k img-it-new""></div>
                        <div class=""k f-note-inf"">
                            <span class=""k t t-name-it-new"">Bánh bông lan </span>
                            <span class=""k t t-price-it"">30.000₫ </span>
                            <span class=""k t t-inf-it"">Đây là 1 sản phẩm đặc biệt ra mắt nhằm hưởng ứng hội nghị thưởng đỉnh 2 nước Triều Tiên - Mỹ </span>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""k f-dt-note"">
            <span class="" t bf-t-note""></span>
            <span class="" t t-f-favr"">BÀI VIẾT LIÊN QUAN</span>
            <span class="" t bf-t-note""></span>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5483, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5489, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "950492a725c0453eafffc56271e35bea", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5529, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
