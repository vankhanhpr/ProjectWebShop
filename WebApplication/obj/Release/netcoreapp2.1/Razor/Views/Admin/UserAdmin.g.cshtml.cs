#pragma checksum "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Admin\UserAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a1cffe18cd384d958858db4814e15fd59505de0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserAdmin), @"mvc.1.0.view", @"/Views/Admin/UserAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UserAdmin.cshtml", typeof(AspNetCore.Views_Admin_UserAdmin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a1cffe18cd384d958858db4814e15fd59505de0", @"/Views/Admin/UserAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ad_user.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item-role"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item-role udsex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/aduser.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\ASPMVC\ProjectWebShop\WebApplication\Views\Admin\UserAdmin.cshtml"
  
    ViewData["Title"] = "Manage users";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(117, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(123, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8bbebd5151d14ddfaf9065006c78b3b0", async() => {
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
                BeginContext(187, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(192, 360, true);
            WriteLiteral(@"<div class=""main-form"">
    <div class=""bg-tt"">
        <span class=""k t-gt-home"">Home</span>
    </div>
    <div class=""k bd-tt"">
        <div class=""k bd-rol"">
            <span class=""k tt-main"">Users</span>
            <span class=""k note-role"">Filter</span>
            <select class=""k value-roles"" onchange=""changeRoles(this)"">
                ");
            EndContext();
            BeginContext(552, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e0bc59c90344d44a83fa5a015214959", async() => {
                BeginContext(588, 5, true);
                WriteLiteral("Admin");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(602, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(620, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffb4f0a1e8264304a6cfcc5b4a2e627c", async() => {
                BeginContext(656, 4, true);
                WriteLiteral("User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(669, 1257, true);
            WriteLiteral(@"
            </select>
            <i class=""fa fa-plus bnt-add-f"" aria-hidden=""true"" onclick=""showFormCreateUs()""></i>
            <input class=""inp-search"" type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search for names.."" title=""Type in a name"">
        </div>

        <div class=""k tab-body-user"">
            <div class=""k add-form"">
                <div class=""k l-text"">Name: </div>
                <input type=""text"" id=""inp-name"" class=""k input-text"" />
                <input class=""k chb"" id=""check-man"" onclick=""removeCheckbox(1)"" type=""checkbox"" name=""vehicle1"" value=""Bike"" style=""margin-left:15px;"" />
                <span class=""k t-checkb"">Man</span>

                <input class=""k chb"" id=""check-woman"" onclick=""removeCheckbox(2)"" type=""checkbox"" name=""vehicle1"" value=""Bike"" style=""margin-left:15px;"" />
                <span class=""k t-checkb"">Woman</span>

                <input class=""k chb"" id=""check-other"" onclick=""removeCheckbox(3)"" type=""checkbox"" name=""vehicle1");
            WriteLiteral("\" value=\"Bike\" style=\"margin-left:15px;\" />\r\n                <span class=\"k t-checkb\">Other</span>\r\n\r\n                <span class=\"k t-roles\">Set roles:</span>\r\n                <select class=\"k value-roles-add\">\r\n                    ");
            EndContext();
            BeginContext(1926, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1e65d00953e4ede97a484716f2396c8", async() => {
                BeginContext(1962, 5, true);
                WriteLiteral("Admin");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1976, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1998, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40790d363f414b22be96b0cdfa46a67e", async() => {
                BeginContext(2034, 4, true);
                WriteLiteral("User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2047, 2628, true);
            WriteLiteral(@"
                </select>

                <div class=""k l-text"">Email: </div>
                <input type=""text"" class=""k input-adr"" id=""inp-email"" />
            </div>
            <div class=""k add-form"">

                <div class=""k l-text"">Address: </div>
                <input type=""text"" class=""k input-adr"" id=""inp-addr"" />

                <div class=""k l-text"">Phone: </div>
                <input type=""number"" class=""k input-adr"" id=""inp-phone"" />

                <div class=""k l-text"">Birthday: </div>
                <div class=""form-group"">
                    <div class='input-group date' id='datepicker-us'>
                        <input type='text' class=""form-control"" id=""inp-bd"" />
                        <span class=""input-group-addon"">
                            <span class=""glyphicon glyphicon-calendar""></span>
                        </span>
                    </div>
                </div>
            </div>
            <div class=""k add-form"">
               ");
            WriteLiteral(@" <div class=""k l-text"">Avatar: </div>
                <i class=""k fa fa-file-image-o"" aria-hidden=""true"" id=""img-main"" style=""background-image: none; color: rgb(51, 51, 51);"">
                    <span class=""bnt-sl-img"" onclick=""getImage()"">browse</span>
                    <input id=""multi-file"" class=""hidden"" type=""file"" accept=""image/*"" multiple="""">
                </i>
                <div class=""k l-text"" style=""margin-left:20px;"">Password: </div>
                <input type=""password"" class=""k input-adr"" id=""inp-pass"" />
                <input class=""k chb"" id=""check-pass"" onchange=""showpass()"" type=""checkbox"" name=""shp"" value=""shp"" style=""margin-top:7px;"" />
                <div class=""k l-text"" style=""margin-left:5px;"">show</div>

                <div class=""k bnt-add-new-us"" onclick=""insertUser()"">Create user</div>
            </div>
        </div>


        <div class=""k tab-showus"">
            <div class=""k tab-title"">
                <span class=""k note-t"" style=""width:5%;"">Stt<");
            WriteLiteral(@"/span>
                <span class=""k note-t"">Avatar</span>
                <span class=""k note-t"" style=""width:20%;"">Full name</span>
                <span class=""k note-t"" style=""width:5%;"">Gender</span>
                <span class=""k note-t"" style=""width:20%;"">Email</span>
                <span class=""k note-t"">Phone</span>
                <span class=""k note-t"">Birthday</span>
                <span class=""k note-t"">Create day</span>
                <span class=""k note-t"" style=""width:10%;"">Edit</span>
            </div>
            <div class=""k bd-body-us"">
");
            EndContext();
            BeginContext(5672, 1282, true);
            WriteLiteral(@"            </div>

            <div class=""modal fade"" id=""myModalUser"" role=""dialog"">
                <div class=""modal-dialog"">
                    <!-- Modal content-->
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                            <h4 class=""modal-title"">Edit user</h4>
                        </div>
                        <div class=""modal-body"">

                            <div class=""k tab-edit-user"">
                                <div class=""k add-form"">
                                    <div class=""k line-it"">
                                        <span class=""k t-note-u-ud"">Full name:</span>
                                        <input type=""text"" class=""k input-text edit-ip-ud"" id=""ud-fullname"" />
                                    </div>
                                    <div class=""k line-it"" style=""wid");
            WriteLiteral(@"th:50%;"">
                                        <span class=""k t-note-u-ud t-gender"">Gender</span>
                                        <select class=""k value-roles-add edit-ip-ud sl-gender"" id=""sl-gd-ud"">
                                            ");
            EndContext();
            BeginContext(6954, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd04d9350e504621a0e920964aa76c50", async() => {
                BeginContext(6996, 3, true);
                WriteLiteral("Man");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7008, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(7054, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d4543b1fb8470fb56b00b09a6ae8b9", async() => {
                BeginContext(7096, 5, true);
                WriteLiteral("Woman");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7110, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(7156, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5687d73fe1804a3c9808bd541c8cfba7", async() => {
                BeginContext(7198, 5, true);
                WriteLiteral("Other");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7212, 3661, true);
            WriteLiteral(@"
                                        </select>
                                    </div>
                                    <div class=""k line-it"" style=""width:50%;"">
                                        <span class=""k t-note-u-ud"" style=""padding-left:10px;"">Email:</span>
                                        <span class=""k t-note-u-ud edit-ip-ud t-email"" id=""ed-mail""></span>
                                    </div>
                                    <div class=""k line-it"">
                                        <span class=""k t-note-u-ud"">Phone:</span>
                                        <input type=""number"" class=""k input-text edit-ip-ud"" id=""ed-phone"" />
                                    </div>

                                    <div class=""k line-it"">
                                        <span class=""k t-note-u-ud"">Address:</span>
                                        <input type=""text"" class=""k input-text edit-ip-ud"" id=""ed-address"" />
                          ");
            WriteLiteral(@"          </div>

                                    <div class=""k line-it"">
                                        <span class=""k t-note-u-ud"">Birthday:</span>
                                        <div class=""k form-group edit-ip-ud"">
                                            <div class='input-group' id='datepicker-ud-user' style=""width:100%;"">
                                                <input type='text' class=""form-control"" id=""ed-birthday""/>
                                                <span class=""input-group-addon"" >
                                                    <span class=""glyphicon glyphicon-calendar""></span>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""k line-it"">
                                        <span class=""k t-note-u-ud"">Password:</span>
                    ");
            WriteLiteral(@"                    <input type=""password"" class=""k input-text edit-ip-ud"" id=""ed-pass-ud"" style=""width:60%;""/>
                                        <input class=""k chb"" id=""check-pass"" onchange=""showpassUd()"" type=""checkbox"" name=""shp"" value=""shp"" style=""margin-top:7px;margin-left:5px;"" />
                                        <div class=""k l-text"" style=""margin-left:5px;"">show</div>
                                    </div>
                                    <div class=""k line-it"">

                                        <div class=""k l-text"">Avatar: </div>
                                        <i class=""k fa fa-file-image-o ud-img"" id=""image-mainud"" aria-hidden=""true"" style=""background-image: none; color: rgb(51, 51, 51);"">
                                            <span class=""bnt-sl-img"" onclick=""getImageUd()"">browse</span>
                                            <input id=""multi-file-ud"" class=""hidden"" type=""file"" accept=""image/*"" multiple="""">
                                  ");
            WriteLiteral(@"      </i>
                                    </div>
                                    <span class=""k bnt-edit-user""  onclick=""gotoUpdate()"">Update User</span>
                                </div>
                            </div>

                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>

                </div>
            </div>

        </div>

    </div>

</div>

");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(10889, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(10895, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5933c768df481ea0e0c35f9cced8fd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(10933, 2, true);
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
