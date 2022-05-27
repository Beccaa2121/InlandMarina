#pragma checksum "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ae4664b2e20a2466369b2bb4fd1998723c57b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Slip_Index), @"mvc.1.0.view", @"/Views/Slip/Index.cshtml")]
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
#line 1 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\_ViewImports.cshtml"
using InlandMarinaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\_ViewImports.cshtml"
using InlandMarinaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae4664b2e20a2466369b2bb4fd1998723c57b3f", @"/Views/Slip/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fef231f29a414e6bcf915f5743de44a710e5e4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Slip_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InlandMarinaData.Slip>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--/*\r\n * Author: Rebecca Allan\r\n * Date: February 2022\r\n * Purpose: Slip page HTML\r\n */-->\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
  
    ViewData["Title"] = "Lease";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Available Slips</h1>\r\n\r\n<h4><br />Select by Dock Name</h4>\r\n\r\n<!--Links for each dock name-->\r\n<p>\r\n    ");
#nullable restore
#line 18 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
Write(Html.ActionLink("Show records for Dock A", "Index", "Slip", new { dockID = "1" }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 21 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
Write(Html.ActionLink("Show records for Dock B", "Index", "Slip", new { dockID = "2" }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 24 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
Write(Html.ActionLink("Show records for Dock C", "Index", "Slip", new { dockID = "3" }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<h3><br />Select by Dock Number</h3>\r\n\r\n<!--Dropdown list for dock numbers-->\r\n<p>\r\n");
#nullable restore
#line 31 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
     using (Html.BeginForm("Index", "Slip", FormMethod.Get))
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("Dock  ");
#nullable restore
#line 33 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
                      Write(Html.DropDownList("dockID", new SelectList(ViewBag.DockID)));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 35 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n</p>\r\n\r\n<!--List view of slips-->\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DockID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 59 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DockID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 78 "C:\Users\allan\source\repos\InlandMarinaRebecca\InlandMarinaMVC\Views\Slip\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InlandMarinaData.Slip>> Html { get; private set; }
    }
}
#pragma warning restore 1591
