#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22ae10e8d080d5632678640e0398ebdb0eb76c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Product.cshtml", typeof(AspNetCore.Views_Product_Product))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ae10e8d080d5632678640e0398ebdb0eb76c4f", @"/Views/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/userproduct.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Product\Product.cshtml"
  
    ViewBag.Title = "";
    ViewData["Title"] = "Products";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(131, 123, true);
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css?family=Roboto:300,400,500&amp;subset=vietnamese\" rel=\"stylesheet\">\r\n    ");
                EndContext();
                BeginContext(254, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ea02c7440d14651bff85382c85f26bd", async() => {
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
                BeginContext(318, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(323, 348, true);
            WriteLiteral(@"<div class="" k main-form"">
    <span class=""k link-product"">Danh mục sản phẩm > Chi tiết sản phầm</span>
    <div class=""k body-product"">
        <div class=""k area-product"">
            <div class=""k bd-img-main"">
                <div class=""k img-pdt"" id=""img-main-prd""></div>
            </div>
            <div class=""k form-more-img"">
");
            EndContext();
            BeginContext(828, 249, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"k area-product\">\r\n            <div class=\"k bd-name-tt\">\r\n                <span class=\"k tt-pdt\" id=\"name-prd\">Bánh kem phomas</span>\r\n                <div class=\"k bd-star\" id=\"bd-evaluate\">\r\n");
            EndContext();
            BeginContext(1456, 1648, true);
            WriteLiteral(@"                </div>
                
                <span class=""k t-view-evaluate"">(Xem 0 đánh giá)</span>
            </div>
            <div class=""k bd-price"">
                <span class=""k t-price"" id=""price-pr""></span>
                <span class=""k t-old-price"" id=""old-price"">Giá cũ :</span>
                <span class=""k t-price-dc"" id=""t-price-dc""></span>
            </div>
            <div class=""k bd-amount"">
                <button class=""bnt-amount"" type=""button"" onclick=""changeNumber(false)"">-</button>
                <span class=""bnt-amount"" id=""numb"">1</span>
                <button class=""bnt-amount"" type=""button"" onclick=""changeNumber(true)"">+</button>
                <button id=""#bnt-bought"" class=""add-to-cart"" type=""button""onclick=""addPrToCarrt()"">
                    <span class=""text"" >CHỌN MUA</span>
                </button>
            </div>
            <div class=""k bd-deliver"">
                <span class=""k t-note-del"">THỜI GIAN GIAO HÀNG DỰ KIẾN</span>
   ");
            WriteLiteral(@"             <span class=""k t-add-del"">
                    Giao hàng tới:
                </span>
                <span class=""k t-adddress"">Thôn cành lá, xã Cành Cây, huyện Trên Mây tỉnh Dưới Đất</span>
                <div class=""k f-time-del "">
                    <i class=""fa fa-truck ic-deli"" aria-hidden=""true""> </i>
                    <span class=""k t-time"">Dự kiến trong ngày 23 tháng5 năm 2019</span>
                </div>
            </div>
        </div>
    </div>
    <div class=""k form-some-pr"">
        <span class=""k t-view-s-pr"">SẢN PHẨM TƯƠNG TỰ</span>
        <div class=""k bd-list-pr"">
");
            EndContext();
            BeginContext(4900, 114, true);
            WriteLiteral("            <i class=\"fa fa-angle-right bnt-next-pr\" aria-hidden=\"true\"></i>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5031, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5037, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "036fcf2d57ca41469c9ee650a0ddf653", async() => {
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
                BeginContext(5080, 54, true);
                WriteLiteral("\r\n    <script>\r\n        try {\r\n            var prid = ");
                EndContext();
                BeginContext(5135, 15, false);
#line 110 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Product\Product.cshtml"
                  Write(ViewBag.product);

#line default
#line hidden
                EndContext();
                BeginContext(5150, 159, true);
                WriteLiteral(";\r\n            getProductById(prid, bindingPrById)\r\n            getEvaluate(prid);\r\n        }\r\n        catch (er) {\r\n            //\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(5312, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
