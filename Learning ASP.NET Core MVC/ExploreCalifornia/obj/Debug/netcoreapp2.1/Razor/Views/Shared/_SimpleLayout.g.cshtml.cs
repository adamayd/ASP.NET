#pragma checksum "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_SimpleLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d29c0d1158031f8ed3d9456ee6e912ceb99f63d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SimpleLayout), @"mvc.1.0.view", @"/Views/Shared/_SimpleLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SimpleLayout.cshtml", typeof(AspNetCore.Views_Shared__SimpleLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29c0d1158031f8ed3d9456ee6e912ceb99f63d7", @"/Views/Shared/_SimpleLayout.cshtml")]
    public class Views_Shared__SimpleLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_SimpleLayout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("secondaryContent", async() => {
                BeginContext(61, 22, true);
                WriteLiteral("\r\n    <!-- EMPTY -->\r\n");
                EndContext();
            }
            );
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(89, 12, false);
#line 9 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_SimpleLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
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