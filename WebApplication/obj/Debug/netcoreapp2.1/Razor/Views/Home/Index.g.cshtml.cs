#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d88eb78d494f4fdd142da7acb6852a0cba86efa"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d88eb78d494f4fdd142da7acb6852a0cba86efa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(92, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "38f5d70ec8df4598875d567b6359cccc", async() => {
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
            BeginContext(153, 11072, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""k main-form"">
        <div class=""k bg-slider""></div>
        <div class=""k f-dt-note"">
            <span class="" t bf-t-note""></span>
            <span class="" t t-f-favr"">MÓN ĂN NỔI BẬT</span>
            <span class="" t bf-t-note""></span>
        </div>
        <div class=""k bd-main-it"">
            <div class=""k db-it-prd"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
            <div class=""k db");
            WriteLiteral(@"-it-prd"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
            <div class=""k db-it-prd"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.0");
            WriteLiteral(@"00₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>

            <div class=""k owl-dots"">
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
        <div class=""k bd-main-it"">
            <div class=""k db-it-prd it-fvr"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-");
            WriteLiteral(@"name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
            <div class=""k db-it-prd it-fvr"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                <");
            WriteLiteral(@"/div>
            </div>
            <div class=""k db-it-prd it-fvr"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
            <div class=""k db-it-prd it-fvr"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.00");
            WriteLiteral(@"0₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
            <div class=""k db-it-prd it-fvr"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
            <div class=""k db-it-prd it-fvr"">
             ");
            WriteLiteral(@"   <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
            <div class=""k db-it-prd it-fvr"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
    ");
            WriteLiteral(@"                <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
            <div class=""k db-it-prd it-fvr"">
                <div class=""k main-it"">
                    <div class=""k bd-img"">
                        <div class=""k img-product""></div>
                    </div>
                    <span class=""k t t-name-it"">Bánh bông lan </span>
                    <span class=""k t t-price-it"">30.000₫ </span>
                    <span class=""k t t-price-pro-it"">35.000₫ </span>
                    <div class=""f-dt-pdt"">
                        <i class=""fa fa-shopping-cart""></i>
                        <i class=""fa fa-info""></i>
                    </div>
                </div>
            </div>
        </div>

        <div class=""k f-new-pdt"">
            <div class=""k f-dt-note"">
                <span class="" t bf-t-note t-new-pdt-l");
            WriteLiteral(@"ine""></span>
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
                    <div class=""k body-it-new"">
                        <div class=""k img-it-new""></div>
                        <div class=""k f-note-inf"">
          ");
            WriteLiteral(@"                  <span class=""k t t-name-it-new"">Bánh bông lan </span>
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
                            <span class=""k t t-inf-it"">Đây là 1 sản phẩm đặc biệt ra mắt nhằm hưởng ứng hội nghị thưởng đỉnh 2 nước Triều Tiên - Mỹ </span>
                        </div>
                    </div>
                </div>
                <div class=""k bd-id-");
            WriteLiteral(@"new"">
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
</div>");
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
