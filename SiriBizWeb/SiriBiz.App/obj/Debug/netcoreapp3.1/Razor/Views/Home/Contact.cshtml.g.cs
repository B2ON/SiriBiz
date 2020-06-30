#pragma checksum "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68e42ca066f8a248b5e0483ad769169655621ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#nullable restore
#line 1 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\_ViewImports.cshtml"
using SiriBiz.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\_ViewImports.cshtml"
using SiriBiz.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68e42ca066f8a248b5e0483ad769169655621ac", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc585eeaf7308658e2a79d95c55d0a94bd74cf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("48"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/contacts/marker.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Map marker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
    ViewBag.NavStyle = "navbar-light navbar-box-shadow bg-light navbar-sticky";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page title-->
<section class=""jarallax bg-gradient pt-5 pb-7 pt-md-7"" data-jarallax data-speed=""0.25"">
    <span class=""bg-overlay bg-gradient"" style=""opacity: .8;""></span>
    <div class=""jarallax-img"" style=""background-image: url(../images/contacts/page-title-bg.jpg);""></div>
    <div class=""container bg-overlay-content pt-3 pb-7 pt-md-0"">
        <div class=""row justify-content-center py-md-5"">
            <div class=""col-lg-6 col-md-8 text-center pt-2 mb-n3"">
                <h1 class=""text-light"">Contacts</h1>
                <p class=""text-light"">Get in touch with by completing the contact form or call us now. We normally respond within 2 business days.</p>
            </div>
        </div>
    </div>
</section>
<!-- Contact cards (details)-->
<section class=""container-fluid bg-overlay-content mb-5 mb-md-6"" style=""margin-top: -120px;"">
    <div class=""row"">
        <div class=""col-lg-3 col-sm-6 mb-grid-gutter"">
            <div class=""card h-100 border-0 box-shadow-lg py-4"">
   ");
            WriteLiteral(@"             <div class=""card-body text-center"">
                    <i class=""siribiz-map-pin mb-4 text-primary"" style=""font-size: 2.25rem;""></i>
                    <h3 class=""h6 mb-2"">Address, Location</h3>
                    <p class=""font-size-sm mb-2"">396 Lillian Blvd, Holbrook, NY 11741, USA</p><a class=""cs-fancy-link font-size-sm"" href=""#map"" data-scroll>See on the map</a>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6 mb-grid-gutter"">
            <div class=""card h-100 border-0 box-shadow-lg py-4"">
                <div class=""card-body text-center"">
                    <i class=""siribiz-clock mb-4 text-danger"" style=""font-size: 2.25rem;""></i>
                    <h3 class=""h6 mb-2"">Working hours</h3>
                    <ul class=""list-unstyled font-size-sm mb-0"">
                        <li>Mon - Fri: 9.30AM - 5.30PM </li>
");
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6 mb-grid-gutter"">
            <div class=""card h-100 border-0 box-shadow-lg py-4"">
                <div class=""card-body text-center"">
                    <i class=""siribiz-phone mb-4 text-success"" style=""font-size: 2.25rem;""></i>
                    <h3 class=""h6 mb-2"">Phone numbers</h3>
                    <ul class=""list-unstyled font-size-sm mb-0"">
                        <li><span class=""mr-1"">Customer service:</span><a class=""nav-link-style"" href=""tel:+108044357260"">+1 (080) 44 357 260</a></li>
                        <li><span class=""mr-1"">Tech support:</span><a class=""nav-link-style"" href=""tel:+100331697720"">+1 00 33 169 7720</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6 mb-grid-gutter"">
            <div class=""card h-100 border-0 box-shadow-lg py-4"">
                <div class=""card");
            WriteLiteral(@"-body text-center"">
                    <i class=""siribiz-mail mb-4 text-warning"" style=""font-size: 2.25rem;""></i>
                    <h3 class=""h6 mb-2"">Email addresses</h3>
                    <ul class=""list-unstyled font-size-sm mb-0"">
                        <li><span class=""mr-1"">Customer service:</span><a class=""nav-link-style"" href=""mailto:customer@siri-biz.com"">customer@siri-biz.com</a></li>
                        <li><span class=""mr-1"">Tech support:</span><a class=""nav-link-style"" href=""mailto:support@siri-biz.com"">support@siri-biz.com</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Contact cards (offices)-->
");
            WriteLiteral(@"<!-- Map + Contact form-->
<section class=""border-top"" id=""map"">
    <div class=""row no-gutters cs-gallery"">
        <a class=""col-lg-6 cs-gallery-item cs-map-popup d-flex flex-columnt justify-content-center align-items-center bg-position-center bg-size-cover py-7 text-center"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d193595.91476818218!2d-74.11976253858133!3d40.69740344296443!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew%20York%2C%20NY%2C%20USA!5e0!3m2!1sen!2sua!4v1568574342685!5m2!1sen!2sua"" data-iframe=""true"" data-sub-html=""&lt;h6 class=&quot;font-size-sm text-light&quot;&gt;396 Lillian Blvd, Holbrook, NY 11741&lt;/h6&gt;"" style=""background-image:url(../images/contacts/map02.jpg);"">
            <span class=""cs-gallery-caption""><i class=""siribiz-maximize-2 font-size-xl mt-n1 mr-2""></i>Expand the map</span>
            <div class=""d-inline-block py-4 py-md-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d68e42ca066f8a248b5e0483ad769169655621ac10050", async() => {
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
            WriteLiteral("\r\n            </div>\r\n        </a>\r\n        <div class=\"col-lg-6 px-3 px-lg-5\">\r\n            <div class=\"pt-5 pb-6 pt-md-6 mx-auto\" style=\"max-width: 720px;\">\r\n                <h2 class=\"h3 pb-4\">Drop us a line</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d68e42ca066f8a248b5e0483ad769169655621ac11496", async() => {
                WriteLiteral(@"
                    <div class=""col-sm-6 form-group"">
                        <label class=""form-label"" for=""cont-fn"">Full name<sup class=""text-danger ml-1"">*</sup></label>
                        <input class=""form-control"" type=""text"" id=""cont-fn"" placeholder=""John Doe"" required>
                        <div class=""invalid-feedback"">Please enter your full name!</div>
                    </div>
                    <div class=""col-sm-6 form-group"">
                        <label class=""form-label"" for=""cont-email"">Email address<sup class=""text-danger ml-1"">*</sup></label>
                        <input class=""form-control"" type=""email"" id=""cont-email"" placeholder=""j.doe@example.com"" required>
                        <div class=""invalid-feedback"">Please enter a valid email address!</div>
                    </div>
                    <div class=""col-sm-6 form-group"">
                        <label class=""form-label"" for=""cont-phone"">Phone number</label>
                        <input class=""form-");
                WriteLiteral(@"control bg-image-0"" type=""text"" id=""cont-phone"" data-format=""custom"" data-delimiter=""-"" data-blocks=""2 4 2 2"" placeholder=""00-0000-00-00"">
                    </div>
                    <div class=""col-sm-6 form-group"">
                        <label class=""form-label"" for=""cont-subject"">Subject</label>
                        <input class=""form-control bg-image-0"" type=""text"" id=""cont-subject"" placeholder=""Title of your message"">
                    </div>
                    <div class=""col-12 form-group"">
                        <label class=""form-label"" for=""cont-message"">Message<sup class=""text-danger ml-1"">*</sup></label>
                        <textarea class=""form-control"" id=""cont-message"" rows=""4"" placeholder=""Write your message here"" required></textarea>
                        <div class=""invalid-feedback"">Please write a message!</div>
                    </div>
                    <div class=""col-12 pt-2"">
                        <button class=""btn btn-primary"" type=""submit"">Send Mes");
                WriteLiteral("sage</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
