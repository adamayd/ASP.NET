#pragma checksum "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "069cd579de8b1249525c587e3d66d2d6693a8730"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MonthlySpecials_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MonthlySpecials/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MonthlySpecials/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MonthlySpecials_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069cd579de8b1249525c587e3d66d2d6693a8730", @"/Views/Shared/Components/MonthlySpecials/Default.cshtml")]
    public class Views_Shared_Components_MonthlySpecials_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExploreCalifornia.Models.Special>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 29, true);
            WriteLiteral("<h1>Monthly Specials</h1>\r\n\r\n");
            EndContext();
#line 4 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
 foreach (var special in Model)
{

#line default
#line hidden
            BeginContext(119, 24, true);
            WriteLiteral("    <h2 class=\"top\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 143, "\"", 179, 3);
            WriteAttributeValue("", 149, "/images/", 149, 8, true);
#line 6 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 157, special.Key, 157, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 171, "_bug.gif", 171, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 180, "\"", 199, 1);
#line 6 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 186, special.Name, 186, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(200, 24, true);
            WriteLiteral(" width=\"75\" height=\"75\">");
            EndContext();
            BeginContext(225, 12, false);
#line 6 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
                                                                                                    Write(special.Name);

#line default
#line hidden
            EndContext();
            BeginContext(237, 24, true);
            WriteLiteral("</h2>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(262, 12, false);
#line 8 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
   Write(special.Type);

#line default
#line hidden
            EndContext();
            BeginContext(274, 16, true);
            WriteLiteral("<br>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 290, "\"", 322, 3);
            WriteAttributeValue("", 297, "/tours/", 297, 7, true);
#line 9 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 304, special.Key, 304, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 318, ".htm", 318, 4, true);
            EndWriteAttribute();
            BeginContext(323, 2, true);
            WriteLiteral(">$");
            EndContext();
            BeginContext(326, 13, false);
#line 9 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"
                                        Write(special.Price);

#line default
#line hidden
            EndContext();
            BeginContext(339, 16, true);
            WriteLiteral("</a>\r\n    </p>\r\n");
            EndContext();
#line 11 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\Components\MonthlySpecials\Default.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExploreCalifornia.Models.Special>> Html { get; private set; }
    }
}
#pragma warning restore 1591