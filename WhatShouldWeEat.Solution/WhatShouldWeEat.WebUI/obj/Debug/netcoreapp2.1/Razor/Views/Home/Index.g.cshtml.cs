#pragma checksum "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed072efa7e65580293b91fb9fb5f904e481a073e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed072efa7e65580293b91fb9fb5f904e481a073e", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WhatShouldWeEat.Entities.categories>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Home/Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(113, 35, true);
            WriteLiteral("\r\n<!Doctype html>\r\n\r\n<html>\r\n<ul>\r\n");
            EndContext();
#line 11 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Home/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(189, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(202, 16, false);
#line 13 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Home/Index.cshtml"
       Write(item.categorykey);

#line default
#line hidden
            EndContext();
            BeginContext(218, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(222, 17, false);
#line 13 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Home/Index.cshtml"
                           Write(item.categoryname);

#line default
#line hidden
            EndContext();
            BeginContext(239, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(243, 17, false);
#line 13 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Home/Index.cshtml"
                                                Write(item.categorydesc);

#line default
#line hidden
            EndContext();
            BeginContext(260, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(274, 14, true);
            WriteLiteral("</ul>\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WhatShouldWeEat.Entities.categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
