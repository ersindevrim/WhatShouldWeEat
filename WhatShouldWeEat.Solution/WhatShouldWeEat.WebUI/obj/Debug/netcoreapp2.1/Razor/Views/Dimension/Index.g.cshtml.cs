#pragma checksum "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c05b23537dd49dfe1120d4fae9c3b948b16aff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dimension_Index), @"mvc.1.0.view", @"/Views/Dimension/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dimension/Index.cshtml", typeof(AspNetCore.Views_Dimension_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c05b23537dd49dfe1120d4fae9c3b948b16aff0", @"/Views/Dimension/Index.cshtml")]
    public class Views_Dimension_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WhatShouldWeEat.Entities.dimensions>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(116, 383, true);
            WriteLiteral(@"
<div class=""card mb-4 wow fadeIn"">
    <div class=""card-body d-sm-flex justify-content-between"">
        <h4 class=""mb-2 mb-sm-0 pt-1"">
            <a href=""/Admin/Index"">Admin</a>
            <span>/</span>
            <span>Ölçüler</span>
        </h4>
    </div>
</div>
<div class=""col-md-12 mb-4"">
    <div class=""card"">
        <div class=""card-body"">
            ");
            EndContext();
            BeginContext(500, 89, false);
#line 18 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
       Write(Html.ActionLink("Yeni Kategori Ekle", "Create", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(589, 181, true);
            WriteLiteral("\r\n            <table class=\"table table-hover\">\r\n                <thead class=\"blue lighten-4\">\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(771, 22, false);
#line 23 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                       Write(Html.DisplayName("ID"));

#line default
#line hidden
            EndContext();
            BeginContext(793, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(885, 33, false);
#line 26 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                       Write(Html.DisplayName("Dimension Key"));

#line default
#line hidden
            EndContext();
            BeginContext(918, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1010, 34, false);
#line 29 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                       Write(Html.DisplayName("Dimension Name"));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 168, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th style=\"width: 300px;\"></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 35 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1285, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1382, 37, false);
#line 39 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1523, 41, false);
#line 42 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.dimkey));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1668, 42, false);
#line 45 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.dimname));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1814, 99, false);
#line 48 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                           Write(Html.ActionLink("Duzenle", "Edit", new { id = item.id }, new { @class = "btn btn-success btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1948, 96, false);
#line 49 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                           Write(Html.ActionLink("Sil", "Delete", new { id = item.id }, new { @class = "btn btn-danger btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(2044, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 52 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Dimension/Index.cshtml"
                    }   

#line default
#line hidden
            BeginContext(2138, 92, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WhatShouldWeEat.Entities.dimensions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
