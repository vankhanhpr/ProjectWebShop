#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Admin\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80bc350ea9247d311f2eec9cc2f8cc11937f0add"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80bc350ea9247d311f2eec9cc2f8cc11937f0add", @"/Views/Admin/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ad_product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/adproducts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Css", async() => {
                BeginContext(72, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(78, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d25f132a2c9e4a48ba0a2767457b3d98", async() => {
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
                BeginContext(145, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(150, 283, true);
            WriteLiteral(@"<div class=""k main-form"">
    <div class=""k l-form"" id=""f-ln-prd"">
        <div class=""k bd-catagory"">
            <span class=""k t t-nt-tt-pr"">Product Category</span>
            <div class=""k ic-add-category"" data-toggle=""modal"" data-target=""#myModal2""></div>
        </div>
");
            EndContext();
            BeginContext(716, 266, true);
            WriteLiteral(@"    </div>
    <div class=""k r-form"" id=""f-it-products"">
        <div class=""k ic-add-pdt"" data-toggle=""modal"" data-target=""#myModal1""></div>
        <span class=""k t t-add-pdt"" data-toggle=""modal"" data-target=""#myModal1"" onclick=""createPr()"">Add Product</span>
");
            EndContext();
            BeginContext(1817, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1857, 838, true);
            WriteLiteral(@"<div class=""modal fade"" id=""myModal2"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Add category</h4>
            </div>
            <div class=""modal-body"">
                <span class=""k t ctl-tt"">Category name</span>
                <input class=""k input-ctg"" type=""text"" id=""ip-name-ctl"" />
                <span class=""k bnt_add_ctg"" onclick=""insertLnPr()"">Save</span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>
</div>
");
            EndContext();
            BeginContext(2713, 793, true);
            WriteLiteral(@"<div class=""modal fade"" id=""myModal1"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Add products</h4>
            </div>
            <div class=""modal-body"">
                <div class=""k bd-add-pdt"">
                    <span class=""k t pdt-tt"">Product name</span>
                    <input class=""k input-pdt"" type=""text"" id=""pr-name"" />
                </div>
                <div class=""k bd-add-pdt-pc"">
                    <span class=""k t pdt-tt-pc"">LineProduct</span>
                    <select class=""k input-pdt-pc"" id=""sl-lnpr"">
");
            EndContext();
            BeginContext(3624, 3229, true);
            WriteLiteral(@"                    </select>
                </div>
                <div class=""k bd-add-pdt-pc"">
                    <span class=""k t pdt-tt-pc"" style=""text-align:center;"">Total</span>
                    <input class=""k input-pdt-pc"" type=""text"" id=""total-pr"" />
                </div>
                <div class=""k bd-add-pdt-pc"">
                    <span class=""k t pdt-tt-pc"">Sale price</span>
                    <input onkeyup=""changeKeyPress(this)"" class=""k input-pdt-pc"" type=""text"" placeholder=""đ"" id=""sale-price"" />
                </div>
                <div class=""k bd-add-pdt-pc"">
                    <span class=""k t pdt-tt-pc"" style=""text-align:center;"">Import price</span>
                    <input class=""k input-pdt-pc"" type=""text"" placeholder=""đ"" id=""import-price"" onkeyup=""changeKeyPress(this)"" />
                </div>

                <div class=""k bd-add-pdt"">
                    <span class=""k t pdt-tt"">Old price</span>
                    <input class=""k input-pdt"" type=""te");
            WriteLiteral(@"xt"" id=""pr-oldprice"" placeholder=""đ"" onkeyup=""changeKeyPress(this)"" />
                </div>

                <div class=""k bd-add-pdt"">
                    <span class=""k t pdt-tt"">Manufacturing date</span>
                    <div class=""form-group"">
                        <div class='input-group date' id='datepicker'>
                            <input type='text' class=""form-control"" id=""mn-day"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""k bd-add-pdt"">
                    <span class=""k t pdt-tt"">Expiry date</span>
                    <div class=""form-group"">
                        <div class='input-group date' id='datepicker1'>
                            <input type='text' class=""form-control"" id=""ex-day"" />
                            <");
            WriteLiteral(@"span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""k f-select-img"">
                    <span class=""k t pdt-tt"" style=""width:100%;margin-bottom:10px;"">Image products</span>
                    <i class=""k fa fa-file-image-o"" aria-hidden=""true"" id=""img-main"">
                        <span class=""bnt-sl-img"" onclick=""getImage()"">browse</span>
                        <input id=""multi-file"" class=""hidden"" type=""file"" accept=""image/*"" multiple="""">
                    </i>
                    <div class=""k f-img-view"" id=""f-img-view"">
                        <div class=""k bd-img-it-lv2"">
                        </div>
                        <div class=""k bd-img-view-it-add"">
                            <div class=""k img-view-it"" style=""background-image:url(/images/home/ic_add_img.png)"" onclic");
            WriteLiteral("k=\"getImageIt()\" id=\"bnt-add-it-img\"></div>\r\n                            <input id=\"multi-file-it\" class=\"hidden\" type=\"file\" accept=\"image/*\" multiple=\"\">\r\n");
            EndContext();
            BeginContext(7076, 384, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <span class=""k bnt_add_ctg"" onclick=""insertProduct()"">Save</span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>
</div>
");
            EndContext();
            BeginContext(7482, 4412, true);
            WriteLiteral(@"<div class=""modal fade"" id=""myModal-ud"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Update product</h4>
            </div>
            <div class=""modal-body"">
                <div class=""k bd-add-pdt"">
                    <span class=""k t pdt-tt"">Product name</span>
                    <input class=""k input-pdt"" type=""text"" id=""pr-name-ud"" />
                </div>
                <div class=""k bd-add-pdt-pc"">
                    <span class=""k t pdt-tt-pc"">LineProduct</span>
                    <select class=""k input-pdt-pc"" id=""sl-lnpr-ud""></select>
                </div>
                <div class=""k bd-add-pdt-pc"">
                    <span class=""k t pdt-tt-pc"" style=""text-align:center;"">Total</span>
                    <input class=""k input-pdt-pc"" type=""text"" id=""total-pr-ud"" />
");
            WriteLiteral(@"                </div>
                <div class=""k bd-add-pdt-pc"">
                    <span class=""k t pdt-tt-pc"">Sale price</span>
                    <input class=""k input-pdt-pc"" type=""text"" placeholder=""đ"" id=""sale-price-ud""onkeyup=""changeKeyPress(this)"" />
                </div>
                <div class=""k bd-add-pdt-pc"">
                    <span class=""k t pdt-tt-pc"" style=""text-align:center;"">Import price</span>
                    <input class=""k input-pdt-pc"" type=""text"" placeholder=""đ"" id=""import-price-ud"" onkeyup=""changeKeyPress(this)"" />
                </div>

                <div class=""k bd-add-pdt"">
                    <span class=""k t pdt-tt"">Old price</span>
                    <input class=""k input-pdt"" type=""text"" id=""pr-oldprice-ud"" onkeyup=""changeKeyPress(this)"" />
                </div>

                <div class=""k bd-add-pdt"">
                    <span class=""k t pdt-tt"">Manufacturing date</span>
                    <div class=""form-group"">
                   ");
            WriteLiteral(@"     <div class='input-group date' id='datepicker-ud'>
                            <input type='text' class=""form-control"" id=""mn-day-ud"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""k bd-add-pdt"">
                    <span class=""k t pdt-tt"">Expiry date</span>
                    <div class=""form-group"">
                        <div class='input-group date' id='datepicker1-ud'>
                            <input type='text' class=""form-control"" id=""ex-day-ud"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""k");
            WriteLiteral(@" f-select-img"">
                    <span class=""k t pdt-tt"" style=""width:100%;margin-bottom:10px;"">Image products</span>
                    <i class=""k fa fa-file-image-o"" aria-hidden=""true"" id=""img-main-ud"">
                        <span class=""bnt-sl-img"" onclick=""getImageUd()"">browse</span>
                        <input id=""multi-file-ud"" class=""hidden"" type=""file"" accept=""image/*"" multiple="""">
                    </i>
                    <div class=""k f-img-view"" id=""f-img-view-ud"">
                        <div class=""k bd-img-it-lv2-ud"" id=""list-img-it-ud"">
                        </div>
                        <div class=""k bd-img-view-it-add"">
                            <div class=""k img-view-it"" style=""background-image:url(/images/home/ic_add_img.png)"" onclick=""getImageItUd()"" id=""bnt-add-it-img-ud""></div>
                            <input id=""multi-file-it-ud"" class=""hidden"" type=""file"" accept=""image/*"" multiple="""">
                        </div>
                    </div>
        ");
            WriteLiteral(@"        </div>
                <span class=""k bnt_add_ctg"" onclick=""updateProduct()"">Save</span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>
</div>
");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(11910, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(11916, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4eb67dbe0ed43389506a377fc4fb30c", async() => {
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
                BeginContext(11958, 2, true);
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
