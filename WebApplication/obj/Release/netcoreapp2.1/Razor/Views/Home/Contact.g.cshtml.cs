#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc8d9a835cb55968d5984c5cf31fcc00acb3252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc8d9a835cb55968d5984c5cf31fcc00acb3252", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user_contact.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/usercontact.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(103, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(109, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e0f7f6edc3a471db795b514681d198e", async() => {
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
                BeginContext(178, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(183, 1567, true);
            WriteLiteral(@"<div class=""k main-form"">
    <div class=""k f-compalain"">
        <span class=""k t t-h-cp"">Nhận thông tin phản ánh</span>
        <div class=""k bd-r-input"">
            <div class=""k f-input"">
                <span class=""k t l-t-note"">Tiêu đề</span>
                <input type=""text"" class=""k r-ip""  id=""tt-complain""/>
            </div>
            <div class=""k f-input"">
                <span class=""k t l-t-note"">Số điện thoại của bạn: </span>
                <input type=""text"" class=""k r-ip""id=""phone-client"" maxlength=""10""/>
            </div>
            <div class=""k f-input"">
                <span class=""k t l-t-note"">Nội dung phản ánh</span>
                <textarea class=""k t r-textarea"" id=""conten-complain""></textarea>
            </div>
            <div class=""k f-input"">
                <span class=""k t bnt-sm-cp""onclick=""insertComplain()"">Gửi</span>
            </div>
        </div>
    </div>
    <div class=""k f-contact"">
        <span class=""k t t-h-cp"">Liên hệ với chúng t");
            WriteLiteral(@"ôi</span>
        <h4>Shop Lửa Hồng</h4>
        <h4><i class=""fa fa-link"" aria-hidden=""true""></i><a href=""https://quanluahong.com"">LuaHong Corp</a></h4>
        <h4><i class=""fa fa-envelope-o"" aria-hidden=""true""></i><a href=""https://gmail.com"">khanhnv@hcmute.edu.vn</a></h4>
        <h4><i class=""fa fa-phone-square"" aria-hidden=""true""></i><a>0983.975.408</a></h4>
        <h4><i class=""fa fa-facebook-official"" aria-hidden=""true""></i><a href=""https://facebook.com/atun.1865"">https://facebook.com/atun.1865</a></h4>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1767, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1773, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd3afdaea9554c0781e10eaeccef4c50", async() => {
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
                BeginContext(1816, 4, true);
                WriteLiteral("\r\n\r\n");
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
