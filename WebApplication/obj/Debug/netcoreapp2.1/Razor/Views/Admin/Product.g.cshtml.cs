#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Admin\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21ff72665c94abd93d9567ec41d5b267ad0efe61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Product), @"mvc.1.0.view", @"/Views/Admin/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Product.cshtml", typeof(AspNetCore.Views_Admin_Product))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ff72665c94abd93d9567ec41d5b267ad0efe61", @"/Views/Admin/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ad_product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery-1.11.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Admin\Product.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(59, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e2846dd30266432ea3fdd7931ca85e8d", async() => {
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
            BeginContext(126, 3337, true);
            WriteLiteral(@"
<div class=""k main-form"">
    <div class=""k l-form"">
        <div class=""k bd-catagory"">
            <span class=""k t t-nt-tt-pr"">Product Category</span>
            <div class=""k ic-add-category"" onclick=""showdialog()""></div>
        </div>
        <div class=""k bd-prd"">
            <div class=""k ic-pdt""></div>
            <span class=""k t t-name-pr"">Milk tea</span>
            <div class=""k ic-next""></div>
        </div>
        <div class=""k bd-prd"">
            <div class=""k ic-pdt""></div>
            <span class=""k t t-name-pr"">Tea</span>
            <div class=""k ic-next""></div>
        </div>
        <div class=""k bd-prd"">
            <div class=""k ic-pdt""></div>
            <span class=""k t  t-name-pr"">Yaourt</span>
            <div class=""k ic-next""></div>
        </div>
    </div>
    <div class=""k r-form"">
        <div class=""k ic-add-pdt""onclick=""showdialogPrduct()""></div>
        <span class=""k t t-add-pdt""onclick=""showdialogPrduct()"">Add Product</span>
        <div cla");
            WriteLiteral(@"ss=""k item-pr-form"">
            <div class=""k img-pdt""></div>
            <div class=""k f-pdt-name"">
                <span class=""k t name-product"">Trà sữa trân châu đường đen</span>
                <span class=""k t total-pdt"">Total: 35</span>
            </div>
            <div class=""k f-pdt-name"">
                <span class=""k t name-product"">Saleprice: 20.000 Đ</span>
                <span class=""k t total-pdt"">Import price: 10.000 Đ</span>
                <span class=""k t total-pdt"">Manufacturing date: 12/01/2019</span>
                <span class=""k t t-warning"">Expiry date: 12/12/2019</span>
                <div class=""k ic_delete_pdt""></div>
                <div class=""k ic_edit_pdt""></div>
            </div>
        </div>
        <div class=""k item-pr-form"">
            <div class=""k img-pdt""></div>
            <div class=""k f-pdt-name"">
                <span class=""k t name-product"">Trà sữa thạch trái cây</span>
                <span class=""k t total-pdt"">Total: 35</span>
    ");
            WriteLiteral(@"        </div>
            <div class=""k f-pdt-name"">
                <span class=""k t name-product"">Saleprice: 20.000 Đ</span>
                <span class=""k t total-pdt"">Import price: 10.000 Đ</span>
                <span class=""k t total-pdt"">Manufacturing date: 12/01/2019</span>
                <span class=""k t t-warning"">Expiry date: 12/12/2019</span>
                <div class=""k ic_delete_pdt""></div>
                <div class=""k ic_edit_pdt""></div>
            </div>
        </div>
        <div class=""k item-pr-form"">
            <div class=""k img-pdt""></div>
            <div class=""k f-pdt-name"">
                <span class=""k t name-product"">Trà sữa vị đào</span>
                <span class=""k t total-pdt"">Total: 35</span>
            </div>
            <div class=""k f-pdt-name"">
                <span class=""k t name-product"">Saleprice: 20.000 Đ</span>
                <span class=""k t total-pdt"">Import price: 10.000 Đ</span>
                <span class=""k t total-pdt"">Manufacturin");
            WriteLiteral(@"g date: 12/01/2019</span>
                <span class=""k t t-warning"">Expiry date: 12/12/2019</span>
                <div class=""k ic_delete_pdt""></div>
                <div class=""k ic_edit_pdt""></div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(3481, 66, true);
            WriteLiteral("<div id=\"f-add-category\" class=\"f-add-ctl\" style=\"display:none\">\r\n");
            EndContext();
            BeginContext(4201, 1197, true);
            WriteLiteral(@"    <span class=""k t ctl-tt"">Category name</span>
    <input class=""k input-ctg"" type=""text"" />
    <span class=""k bnt_add_ctg"">Save</span>
</div>
<div id=""f-add-product"" class=""f-add-ctl"" style=""display:none"">
    <div class=""k bd-add-pdt"">
        <span class=""k t pdt-tt"">Product name</span>
        <input class=""k input-pdt"" type=""text"" />
    </div>
    <div class=""k bd-add-pdt"">
        <span class=""k t pdt-tt"">Total</span>
        <input class=""k input-pdt"" type=""text"" />
    </div>
    <div class=""k bd-add-pdt"">
        <span class=""k t pdt-tt"">Saleprice</span>
        <input class=""k input-pdt"" type=""text"" placeholder=""VNĐ""/>
    </div>
    <div class=""k bd-add-pdt"">
        <span class=""k t pdt-tt"">Import price</span>
        <input class=""k input-pdt"" type=""text""placeholder=""VNĐ""/>
    </div>
    <div class=""k bd-add-pdt"">
        <span class=""k t pdt-tt"">Manufacturing date</span>
        <input class=""k input-pdt"" type=""text"" />
    </div>
    <div class=""k bd-add-pdt"">
  ");
            WriteLiteral("      <span class=\"k t pdt-tt\">Expiry date</span>\r\n        <input class=\"k input-pdt\" type=\"text\" />\r\n    </div>\r\n    <span class=\"k bnt_add_ctg\">Save</span>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(5398, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6f8b5eb71c7430aaeda2d5f213b503a", async() => {
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
            BeginContext(5462, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5464, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "613bc9243cea46c383a8280d82d76643", async() => {
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
            BeginContext(5526, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5528, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6ad80e608614f7c862b5166aa084129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5586, 974, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://code.jquery.com/ui/1.11.1/themes/smoothness/jquery-ui.css"" />


<script>
    function showdialog() {
        $(""#f-add-category"").dialog({
            autoOpen: false,
            width: 400,
            maxHeight: 300,
            fluid: false,
            title: ""Add category"",
            draggable: false,
            resizable: false,
            modal: true,
            position: { my: ""center"", at: ""center"" }
        });
        $(""#f-add-category"").dialog(""open"");
    }
    function showdialogPrduct() {
        $(""#f-add-product"").dialog({
            autoOpen: false,
            width: 600,
            maxHeight: 500,
            fluid: false,
            title: ""Add Product"",
            draggable: false,
            resizable: false,
            modal: true,
            position: { my: ""center"", at: ""center"" }
        });
        $(""#f-add-product"").dialog(""open"");
    }
</script>");
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
