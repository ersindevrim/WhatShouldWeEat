#pragma checksum "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14cfa97cce9ae469a093a0ffb91da25045e1fd86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Edit), @"mvc.1.0.view", @"/Views/Category/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Edit.cshtml", typeof(AspNetCore.Views_Category_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14cfa97cce9ae469a093a0ffb91da25045e1fd86", @"/Views/Category/Edit.cshtml")]
    public class Views_Category_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WhatShouldWeEat.Entities.categories>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(103, 556, true);
            WriteLiteral(@"

<div class=""card mb-4 wow fadeIn"">

    <!--Card content-->
    <div class=""card-body d-sm-flex justify-content-between"">

        <h4 class=""mb-2 mb-sm-0 pt-1"">
            <a href=""/Admin/Index"">Admin</a>
            <span>/</span>
            <span>
                <a href=""/Category/Index"">Kategoriler</a>
            </span>
            <span>/</span>
            <span>Kategori Düzenle</span>
        </h4>
    </div>

</div>
<div class=""card"">
    <div class=""card-header"">Kategori Düzenle</div>
    <div class=""card-body"">
");
            EndContext();
#line 27 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(718, 23, false);
#line 29 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(745, 124, true);
            WriteLiteral("            <div class=\"form-horizontal\">\r\n                <div class=\"alert alert-info\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(870, 18, false);
#line 33 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
               Write(Model.categoryname);

#line default
#line hidden
            EndContext();
            BeginContext(888, 86, true);
            WriteLiteral("\'i düzenliyorsunuz..\r\n                </div>\r\n                <hr />\r\n                ");
            EndContext();
            BeginContext(975, 64, false);
#line 36 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1058, 33, false);
#line 37 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
           Write(Html.HiddenFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 66, true);
            WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1158, 100, false);
#line 40 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
               Write(Html.LabelFor(model => model.categorykey, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(1330, 100, false);
#line 42 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
                   Write(Html.EditorFor(model => model.categorykey, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1457, 89, false);
#line 43 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.categorykey, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1665, 101, false);
#line 48 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
               Write(Html.LabelFor(model => model.categoryname, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(1838, 101, false);
#line 50 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
                   Write(Html.EditorFor(model => model.categoryname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1939, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1966, 90, false);
#line 51 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.categoryname, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2056, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2175, 101, false);
#line 56 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
               Write(Html.LabelFor(model => model.categorydesc, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(2348, 101, false);
#line 58 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
                   Write(Html.EditorFor(model => model.categorydesc, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2449, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2476, 90, false);
#line 59 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.categorydesc, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2566, 271, true);
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Kaydet"" class=""btn btn-success"" />
                        ");
            EndContext();
            BeginContext(2838, 86, false);
#line 66 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
                   Write(Html.ActionLink("İptal", "Index", "Category", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2924, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 70 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Category/Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(3009, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WhatShouldWeEat.Entities.categories> Html { get; private set; }
    }
}
#pragma warning restore 1591