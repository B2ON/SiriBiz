#pragma checksum "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f35ff5be206bb5f73bb3534ff3214aeed93e27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f35ff5be206bb5f73bb3534ff3214aeed93e27", @"/Views/Shared/Components/BlogMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc585eeaf7308658e2a79d95c55d0a94bd74cf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SiriBiz.Core.Models.MenuItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item dropdown dropdown-mega\">\r\n        <a class=\"nav-link dropdown-toggle\" href=\"#\" data-toggle=\"dropdown\">Blog</a>\r\n        <div class=\"dropdown-menu\">\r\n");
#nullable restore
#line 7 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
             foreach (var group in Model.Select(s => s.Group).Distinct())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"dropdown-column mb-2 mb-lg-0\">\r\n                    <h5 class=\"dropdown-header\">");
#nullable restore
#line 10 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
                                           Write(group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 11 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
                     foreach (var subMenu in Model.Where(w => w.Group.Equals(group)))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 611, "\"", 630, 1);
#nullable restore
#line 13 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
WriteAttributeValue("", 618, subMenu.Url, 618, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
                                                                Write(subMenu.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 14 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 16 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </li>\r\n");
#nullable restore
#line 19 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Components\BlogMenu\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SiriBiz.Core.Models.MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591