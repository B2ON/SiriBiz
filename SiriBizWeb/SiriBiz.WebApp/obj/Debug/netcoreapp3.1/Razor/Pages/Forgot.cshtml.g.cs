#pragma checksum "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.WebApp\Pages\Forgot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebd67a17e5dba983b30aaddbf5f91d7fc75b6f9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SiriBiz.WebApp.Pages.Pages_Forgot), @"mvc.1.0.razor-page", @"/Pages/Forgot.cshtml")]
namespace SiriBiz.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.WebApp\Pages\_ViewImports.cshtml"
using SiriBiz.WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebd67a17e5dba983b30aaddbf5f91d7fc75b6f9b", @"/Pages/Forgot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f465c3c4c403580f825899a03184ea6304be739a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forgot : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.WebApp\Pages\Forgot.cshtml"
  
    ViewData["Title"] = "Forgot Password";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container py-5 py-sm-6 py-md-7"">
    <div class=""row justify-content-center pt-4"">
        <div class=""col-lg-7 col-md-9 col-sm-11"">
            <h1 class=""h2 pb-3"">Forgot your password?</h1>
            <p class=""font-size-sm"">Change your password in three easy steps. This helps to keep your new password secure.</p>
            <ul class=""list-unstyled font-size-sm pb-1 mb-4"">
                <li><span class=""text-primary font-weight-semibold mr-1"">1.</span>Fill in your email address below.</li>
                <li><span class=""text-primary font-weight-semibold mr-1"">2.</span>We'll email you a temporary code.</li>
                <li><span class=""text-primary font-weight-semibold mr-1"">3.</span>Use the code to change your password on our secure website.</li>
            </ul>
            <div class=""bg-secondary rounded-lg px-3 py-4 p-sm-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd67a17e5dba983b30aaddbf5f91d7fc75b6f9b4570", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""form-label"" for=""recovery-email"">Enter your email address</label>
                        <input class=""form-control"" type=""email"" required id=""recovery-email"">
                        <div class=""invalid-feedback"">Please provide a valid email address!</div>
                    </div>
                    <button class=""btn btn-primary"" type=""submit"">Get new password</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiriBiz.WebApp.Pages.ForgotModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SiriBiz.WebApp.Pages.ForgotModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SiriBiz.WebApp.Pages.ForgotModel>)PageContext?.ViewData;
        public SiriBiz.WebApp.Pages.ForgotModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
