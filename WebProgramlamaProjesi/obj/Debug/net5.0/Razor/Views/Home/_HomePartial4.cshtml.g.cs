#pragma checksum "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58fcf8e53f3eb97d4dc327526f66c9420900d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__HomePartial4), @"mvc.1.0.view", @"/Views/Home/_HomePartial4.cshtml")]
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
#line 1 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
using WebProgramlamaProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58fcf8e53f3eb97d4dc327526f66c9420900d00", @"/Views/Home/_HomePartial4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c31f05e611f09b9c1358f5250d638b05f7a2de1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__HomePartial4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"padding1\">\r\n    <h4>Gezilecek Yerler</h4>\r\n    \r\n    <div class=\"box-left\">\r\n");
#nullable restore
#line 7 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
         foreach (var item in Model)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
             if (item.ID == 4 || item.ID == 5 || item.ID == 6)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"bot-img\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 326, "\"", 347, 1);
#nullable restore
#line 11 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
WriteAttributeValue("", 332, item.BlogImage, 332, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:120px; height:65px;\"");
            BeginWriteAttribute("alt", " alt=\"", 382, "\"", 388, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"bot-desc\">\r\n                    <p>");
#nullable restore
#line 14 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
                  Write(item.Aciklama.Substring(0, 60));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"clear\"></div>\r\n");
#nullable restore
#line 17 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n        \r\n    <div class=\"box1-left\">\r\n");
#nullable restore
#line 23 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
         foreach (var item in Model)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
             if (item.ID == 7 || item.ID == 8 || item.ID == 9)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"bot-img\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 847, "\"", 868, 1);
#nullable restore
#line 27 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
WriteAttributeValue("", 853, item.BlogImage, 853, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:120px; height:65px;\"");
            BeginWriteAttribute("alt", " alt=\"", 903, "\"", 909, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"bot-desc1\">\r\n                    <p>");
#nullable restore
#line 30 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
                  Write(item.Aciklama.Substring(0, 60));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"clear\"></div>\r\n");
#nullable restore
#line 33 "C:\Users\Hana\source\repos\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\_HomePartial4.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        \r\n    </div>\r\n\r\n\r\n\r\n");
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