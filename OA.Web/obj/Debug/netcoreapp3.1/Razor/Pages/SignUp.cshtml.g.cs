#pragma checksum "C:\Users\Sajal gmpcs\source\repos\Onion Architechture\OA.Web\Pages\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73536738ff936ca28933a80303ec40e114d54201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_SignUp), @"mvc.1.0.razor-page", @"/Pages/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73536738ff936ca28933a80303ec40e114d54201", @"/Pages/SignUp.cshtml")]
    public class Pages_SignUp : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sajal gmpcs\source\repos\Onion Architechture\OA.Web\Pages\SignUp.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73536738ff936ca28933a80303ec40e114d542012882", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>SignUp</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73536738ff936ca28933a80303ec40e114d542013942", async() => {
                WriteLiteral("\r\n    <h3>Sign Up</h3>\r\n    <form method=\"post\" asp-page=\"signup\">\r\n        <table>\r\n            <tr>\r\n                <td>Username</td>\r\n                <td>\r\n                    <input");
                BeginWriteAttribute("asp-for", " asp-for=\"", 391, "\"", 424, 1);
#nullable restore
#line 21 "C:\Users\Sajal gmpcs\source\repos\Onion Architechture\OA.Web\Pages\SignUp.cshtml"
WriteAttributeValue("", 401, Model.account.Username, 401, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Password</td>\r\n                <td>\r\n                    <input type=\"password\"");
                BeginWriteAttribute("asp-for", " asp-for=\"", 589, "\"", 622, 1);
#nullable restore
#line 27 "C:\Users\Sajal gmpcs\source\repos\Onion Architechture\OA.Web\Pages\SignUp.cshtml"
WriteAttributeValue("", 599, Model.account.Password, 599, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Full Name</td>\r\n                <td>\r\n                    <input");
                BeginWriteAttribute("asp-for", " asp-for=\"", 772, "\"", 805, 1);
#nullable restore
#line 33 "C:\Users\Sajal gmpcs\source\repos\Onion Architechture\OA.Web\Pages\SignUp.cshtml"
WriteAttributeValue("", 782, Model.account.FullName, 782, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Email</td>\r\n                <td>\r\n                    <input type=\"email\"");
                BeginWriteAttribute("asp-for", " asp-for=\"", 964, "\"", 994, 1);
#nullable restore
#line 39 "C:\Users\Sajal gmpcs\source\repos\Onion Architechture\OA.Web\Pages\SignUp.cshtml"
WriteAttributeValue("", 974, Model.account.Email, 974, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <input type=""submit"" value=""Save"" />
                    <br />
                    <a asp-page=""login"">Sign In</a>
                </td>
            </tr>
        </table>
    </form>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OA.Web.Pages.SignUpModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OA.Web.Pages.SignUpModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OA.Web.Pages.SignUpModel>)PageContext?.ViewData;
        public OA.Web.Pages.SignUpModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591