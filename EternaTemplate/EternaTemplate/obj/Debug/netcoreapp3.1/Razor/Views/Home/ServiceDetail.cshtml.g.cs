#pragma checksum "C:\Users\ibrahimaliyevv\Desktop\HometasksASPnetMVCandLayout\EternaTemplate\EternaTemplate\Views\Home\ServiceDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0bd415c951dfb66f9b3a88b78776c6fa9ccffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ServiceDetail), @"mvc.1.0.view", @"/Views/Home/ServiceDetail.cshtml")]
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
#line 1 "C:\Users\ibrahimaliyevv\Desktop\HometasksASPnetMVCandLayout\EternaTemplate\EternaTemplate\Views\_ViewImports.cshtml"
using EternaTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ibrahimaliyevv\Desktop\HometasksASPnetMVCandLayout\EternaTemplate\EternaTemplate\Views\Home\ServiceDetail.cshtml"
using EternaTemplate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0bd415c951dfb66f9b3a88b78776c6fa9ccffa", @"/Views/Home/ServiceDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe47e955b28b64ce9e79a4c01632e7030cafbb51", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ServiceDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ibrahimaliyevv\Desktop\HometasksASPnetMVCandLayout\EternaTemplate\EternaTemplate\Views\Home\ServiceDetail.cshtml"
  
    ViewData["Title"] = "ServiceDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\ibrahimaliyevv\Desktop\HometasksASPnetMVCandLayout\EternaTemplate\EternaTemplate\Views\Home\ServiceDetail.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\ibrahimaliyevv\Desktop\HometasksASPnetMVCandLayout\EternaTemplate\EternaTemplate\Views\Home\ServiceDetail.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h4>");
#nullable restore
#line 8 "C:\Users\ibrahimaliyevv\Desktop\HometasksASPnetMVCandLayout\EternaTemplate\EternaTemplate\Views\Home\ServiceDetail.cshtml"
Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
