#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Product\DescriptionProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9801103deec9432928e1352c703505be2315c57f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DescriptionProduct), @"mvc.1.0.view", @"/Views/Product/DescriptionProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/DescriptionProduct.cshtml", typeof(AspNetCore.Views_Product_DescriptionProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9801103deec9432928e1352c703505be2315c57f", @"/Views/Product/DescriptionProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DescriptionProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user_desciptionproduct.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Product\DescriptionProduct.cshtml"
  
    ViewData["Title"] = "DescriptionProduct";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(121, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(127, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e6948c54abf04bd1a7aa35d4f3118c97", async() => {
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
                BeginContext(206, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(211, 669, true);
            WriteLiteral(@"<div class=""k main-form"">
    <div class=""k f-head"">
        <a href=""/admin""><span class=""k t-home"">Home</span></a>
    </div>
    <span class=""k t-ct-ds""> Custom the description product</span>
    <div class=""k f-cust-ds"">
        <div class=""k bd-multil-it"">
            <span class=""k le-text"">Title</span>
            <input id=""titel-des"" type=""text"" class=""input-t"" />
        </div>
        <div class=""k bd-multil-it"">
            <span class=""k le-text"">Description</span>
            <textarea id=""t-des"" class=""input-t""></textarea>
        </div>
        <span class=""bnt-success"" onclick=""updateDes()"">Success</span>
    </div>
</div>


");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(896, 35, true);
                WriteLiteral("\r\n    <script>\r\n        var prid = ");
                EndContext();
                BeginContext(932, 12, false);
#line 30 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Product\DescriptionProduct.cshtml"
              Write(ViewBag.prid);

#line default
#line hidden
                EndContext();
                BeginContext(944, 2305, true);
                WriteLiteral(@";
        getDesPrbyId(prid);
        function getDesPrbyId(id) {
            $.ajax({
                type: ""get"",
                url: linkserver + ""describeproduct/GetDesPrById?id="" + id,
                data: null,
                dataType: 'json',
                contentType: ""application/json"",
                error: function (err) {
                    bootbox.alert(""Eror: "" + err.message);
                },
                success: function (data) {
                    if (data.success && data.data!=null) {
                        $(""#titel-des"").val(data.data.title);
                        $(""#t-des"").val(data.data.describes);
                    }
                    else {
                        bootbox.alert(""Eror: Don't found the data"");
                    }
                }
            });
        }
        function updateDes() {
            var data = { ""prid"": prid, ""title"": $(""#titel-des"").val(), ""describes"": $(""#t-des"").val(), ""stt"": 0 };
            $.ajax({
 ");
                WriteLiteral(@"               url: linkserver + ""describeproduct/CustomDesPr"",
                type: 'POST',
                dataType: 'json',
                data: JSON.stringify(data),
                async: false,
                processData: false,
                contentType: ""application/json"",
                error: function (err) {
                    bootbox.alert({
                        message: ""Error :"" + err.message
                    });
                },
                success: function (data) {
                    if (data.success) {
                        bootbox.alert({
                            size: ""small"",
                            title: ""Custom the describe"",
                            message: ""Custom the descibe product success"",
                            callback: function () {
                                window.location.href = ""/admin/product"";
                            }
                        });
                    }
                    else {
      ");
                WriteLiteral(@"                  bootbox.alert({
                            message: """" + data.error.message,
                            size: 'small'
                        });
                    }
                }
            });

        }
    </script>
");
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
