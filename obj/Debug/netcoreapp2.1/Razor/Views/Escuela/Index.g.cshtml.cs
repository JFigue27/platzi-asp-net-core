#pragma checksum "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca01a5ffb2daa904567084c3d66b151ec5db4b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core;

#line default
#line hidden
#line 2 "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca01a5ffb2daa904567084c3d66b151ec5db4b5", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9c994c8a9f955e5ac98e742f2356b1925f342d", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Información Escuela";
    Layout ="Simple";

#line default
#line hidden
            BeginContext(96, 15, true);
            WriteLiteral("\r\n<h1>Escuela  ");
            EndContext();
            BeginContext(112, 17, false);
#line 8 "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\Escuela\Index.cshtml"
        Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(129, 19, true);
            WriteLiteral("</h1>\r\n<h2>Nombre: ");
            EndContext();
            BeginContext(149, 12, false);
#line 9 "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(161, 36, true);
            WriteLiteral("</h2>\r\n<p><strong>Año de fundación: ");
            EndContext();
            BeginContext(198, 18, false);
#line 10 "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\Escuela\Index.cshtml"
                        Write(Model.AñoFundación);

#line default
#line hidden
            EndContext();
            BeginContext(216, 24, true);
            WriteLiteral(" </strong></p>\r\n\r\n<p><i>");
            EndContext();
            BeginContext(241, 20, false);
#line 12 "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\Escuela\Index.cshtml"
 Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(261, 16, true);
            WriteLiteral("</i></p>\r\n<p><i>");
            EndContext();
            BeginContext(278, 24, false);
#line 13 "C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\gitRepositories\Platzi\platzi-asp-net-core\Views\Escuela\Index.cshtml"
 Write(ViewData["CosaDinamica"]);

#line default
#line hidden
            EndContext();
            BeginContext(302, 10, true);
            WriteLiteral("</i></p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
