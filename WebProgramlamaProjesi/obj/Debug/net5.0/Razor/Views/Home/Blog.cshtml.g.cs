#pragma checksum "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f72f176b32546335a7cc351141a219cc856663ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
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
#line 1 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\_ViewImports.cshtml"
using WebProgramlamaProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\_ViewImports.cshtml"
using WebProgramlamaProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72f176b32546335a7cc351141a219cc856663ff", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c31f05e611f09b9c1358f5250d638b05f7a2de1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProgramlamaProjesi.Models.BlogYorum>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-8 content-main\">\r\n    <div class=\"content-grid\">\r\n        <div class=\"content-grid-info\">\r\n");
#nullable restore
#line 9 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
             foreach (var item in Model.Deger1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"single-grid\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 322, "\"", 343, 1);
#nullable restore
#line 12 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
WriteAttributeValue("", 328, item.BlogImage, 328, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 344, "\"", 350, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"post-info\">\r\n                <h4><a");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 446, 2);
            WriteAttributeValue("", 422, "/Home/BlogDetay/", 422, 16, true);
#nullable restore
#line 14 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
WriteAttributeValue("", 438, item.ID, 438, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
                                                  Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                <p>");
#nullable restore
#line 15 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
              Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>                \r\n            </div>\r\n                    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>        \r\n    </div>\r\n</div>\r\n<div class=\"col-md-4 content-right\">\r\n    <div class=\"recent\">\r\n        <h3>SON BLOGLAR</h3>\r\n");
#nullable restore
#line 25 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
         foreach (var x in Model.Deger3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 812, "\"", 840, 2);
            WriteAttributeValue("", 819, "/Home/BlogDetay/", 819, 16, true);
#nullable restore
#line 28 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
WriteAttributeValue("", 835, x.ID, 835, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
                                           Write(x.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>            \r\n        </ul>\r\n");
#nullable restore
#line 30 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Blog.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    \r\n    <div class=\"clearfix\"></div>\r\n    <div class=\"clearfix\"></div>\r\n</div>\r\n<div class=\"clearfix\"></div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProgramlamaProjesi.Models.BlogYorum> Html { get; private set; }
    }
}
#pragma warning restore 1591
