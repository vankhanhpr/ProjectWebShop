#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f188bec1ac7c36706dafe0f6008d64f33dc98806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f188bec1ac7c36706dafe0f6008d64f33dc98806", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/feather.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dashboard.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(97, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(112, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(118, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "741ac85021a340f9b0d30b1969d44fd1", async() => {
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
                BeginContext(186, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(192, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12c9a3aa3f3341a4b2e4246430ee10e7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(258, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(263, 29, true);
            WriteLiteral("\r\n<div class=\"k main-form\">\r\n");
            EndContext();
            BeginContext(646, 3689, true);
            WriteLiteral(@"
    <div class=""k body-form"">
        <div class=""k l-form"">
            <span class=""k ngvt"">Navigation</span>
            <div class=""k f-it"">
                <div class=""k ic_home""></div>
                <span class=""k text-dt"">Dashboard</span>
                <div class=""ic-show"" onclick=""showListItem()"" id=""icon_show-l-it""></div>
            </div>
            <div class=""k bd-l-it"" id=""catalogy"">
                <div class=""k f-l-it"">
                    <div class=""k ic-down""></div>
                    <span class=""k text-dt"">Product</span>
                </div>
                <div class=""k f-l-it"">
                    <div class=""k ic-down""></div>
                    <span class=""k text-dt"">User</span>
                </div>
            </div>

            <div class=""k f-it"">
                <div class=""k ic_gear""></div>
                <span class=""k text-dt"">Custom</span>
                <div class=""ic-show"" onclick=""showListItem()"" id=""icon_show-l-it""></div>
            ");
            WriteLiteral(@"</div>

        </div>
        <div class=""k r-form"">
            <div class=""k h-table"">
                <a href=""/admin/product"">
                    <div class=""k bd-it-table"">
                        <div class=""k f-it-table"">
                            <span class=""k t-number"">200</span>
                            <div class=""k bd-note"">
                                <span class=""k t-name-it"">Product</span>
                                <div class=""k ic-product""></div>
                            </div>
                            <div class=""k ic_clock""></div>
                            <span class=""k t-status"">update today</span>
                        </div>
                    </div>
                </a>
                <a href=""/admin/useradmin"">
                    <div class=""k bd-it-table"">
                        <div class=""k sd-it-table"">
                            <span class=""k t-number"">10</span>
                            <div class=""k bd-note"">
           ");
            WriteLiteral(@"                     <span class=""k t-name-it"">Account</span>
                                <div class=""k ic-product""></div>
                            </div>
                            <div class=""k ic_clock""></div>
                            <span class=""k t-status"">update today</span>
                        </div>
                    </div>
                </a>
                <a href=""/admin/event"">
                    <div class=""k bd-it-table"">
                        <div class=""k th-it-table"">
                            <span class=""k t-number"">2.000$</span>
                            <div class=""k bd-note"">
                                <span class=""k t-name-it"">Posts</span>
                                <div class=""k ic-product""></div>
                            </div>
                            <div class=""k ic_clock""></div>
                            <span class=""k t-status"">update today</span>
                        </div>
                    </div>
           ");
            WriteLiteral(@"     </a>
                <div class=""k bd-it-table"">
                    <div class=""k four-it-table"">
                        <span class=""k t-number"">200</span>
                        <div class=""k bd-note"">
                            <span class=""k t-name-it"">More+</span>
                            <div class=""k ic-product""></div>
                        </div>
                        <div class=""k ic_clock""></div>
                        <span class=""k t-status"">update today</span>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(4351, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4357, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eec388a99a624617b5bf7404b7360d87", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4398, 2, true);
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
