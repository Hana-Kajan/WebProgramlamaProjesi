#pragma checksum "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f34d0e39b5c19a024e50098033637dc1bc219d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__HomePartial1), @"mvc.1.0.view", @"/Views/Home/_HomePartial1.cshtml")]
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
#line 1 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
using WebProgramlamaProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f34d0e39b5c19a024e50098033637dc1bc219d0", @"/Views/Home/_HomePartial1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c31f05e611f09b9c1358f5250d638b05f7a2de1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__HomePartial1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
     foreach (var item in Model)
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
         if (item.ID < 3)

            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"left\">\r\n                <div class=\"bot-left\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 233, "\"", 254, 1);
#nullable restore
#line 10 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
WriteAttributeValue("", 239, item.BlogImage, 239, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px; height:150px;\"");
            BeginWriteAttribute("alt", " alt=\"", 290, "\"", 296, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"left-text\">\r\n                    <h4>");
#nullable restore
#line 13 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
                   Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <span class=\"doller\">");
#nullable restore
#line 14 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
                                    Write(item.Tarih.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <p>");
#nullable restore
#line 15 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
                  Write(item.Aciklama.Substring(0,120));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><a");
            BeginWriteAttribute("href", " href=\"", 579, "\"", 610, 2);
            WriteAttributeValue("", 586, "/Home/BlogDetay/", 586, 16, true);
#nullable restore
#line 16 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
WriteAttributeValue("", 602, item.ID, 602, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"read\">Devamini oku</span></a></p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial1.cshtml"
        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n   \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
