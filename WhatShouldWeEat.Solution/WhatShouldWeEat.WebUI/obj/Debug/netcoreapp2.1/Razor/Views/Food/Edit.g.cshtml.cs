#pragma checksum "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba3d0e18bf771f98bb1a6674dd44c874c56320ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Edit), @"mvc.1.0.view", @"/Views/Food/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/Edit.cshtml", typeof(AspNetCore.Views_Food_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba3d0e18bf771f98bb1a6674dd44c874c56320ce", @"/Views/Food/Edit.cshtml")]
    public class Views_Food_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WhatShouldWeEat.Entities.foods>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(98, 539, true);
            WriteLiteral(@"
<div class=""card mb-4 wow fadeIn"">
    <!--Card content-->
    <div class=""card-body d-sm-flex justify-content-between"">
        <h4 class=""mb-2 mb-sm-0 pt-1"">
            <a href=""/Admin/Index"">Admin</a>
            <span>/</span>
            <span>
                <a href=""/Category/Index"">Yemekler</a>
            </span>
            <span>/</span>
            <span>Yemek Düzenle</span>
        </h4>
    </div>
</div>
<div class=""card"">
    <div class=""card-header"">Yemek Düzenle</div>
    <div class=""card-body"">
");
            EndContext();
#line 23 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(696, 23, false);
#line 25 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(723, 124, true);
            WriteLiteral("            <div class=\"form-horizontal\">\r\n                <div class=\"alert alert-info\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(848, 14, false);
#line 29 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
               Write(Model.foodname);

#line default
#line hidden
            EndContext();
            BeginContext(862, 83, true);
            WriteLiteral(" düzenliyorsunuz.\r\n                </div>\r\n                <hr />\r\n                ");
            EndContext();
            BeginContext(946, 64, false);
#line 32 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 66, true);
            WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1077, 96, false);
#line 35 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
               Write(Html.LabelFor(model => model.foodkey, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(1245, 96, false);
#line 37 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                   Write(Html.EditorFor(model => model.foodkey, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1368, 85, false);
#line 38 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.foodkey, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1572, 97, false);
#line 43 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
               Write(Html.LabelFor(model => model.foodname, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(1741, 97, false);
#line 45 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                   Write(Html.EditorFor(model => model.foodname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1865, 86, false);
#line 46 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.foodname, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2070, 100, false);
#line 51 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
               Write(Html.LabelFor(model => model.categorykey, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(2242, 99, false);
#line 53 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                   Write(Html.DropDownList("categorykey", new SelectList(ViewBag.Categories, "categorykey", "categoryname")));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2368, 86, false);
#line 54 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.foodname, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2573, 99, false);
#line 59 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
               Write(Html.LabelFor(model => model.isapproved, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 123, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        <div class=\"checkbox\">\r\n                            ");
            EndContext();
            BeginContext(2796, 41, false);
#line 62 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                       Write(Html.EditorFor(model => model.isapproved));

#line default
#line hidden
            EndContext();
            BeginContext(2837, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2868, 88, false);
#line 63 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.isapproved, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2956, 305, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>


                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Kaydet"" class=""btn btn-success"" />
                        ");
            EndContext();
            BeginContext(3262, 82, false);
#line 72 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
                   Write(Html.ActionLink("İptal", "Index", "Food", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3344, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 76 "/Users/ersindevrim/Projects/WhatShouldWeEat.Solution/WhatShouldWeEat.WebUI/Views/Food/Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(3429, 18, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WhatShouldWeEat.Entities.foods> Html { get; private set; }
    }
}
#pragma warning restore 1591
