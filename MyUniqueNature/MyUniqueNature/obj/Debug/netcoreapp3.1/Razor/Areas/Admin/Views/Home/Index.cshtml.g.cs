#pragma checksum "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0da3d91d672068ca7e8ffa6d49051da06c851af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Home\Index.cshtml"
using MyUniqueNature.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0da3d91d672068ca7e8ffa6d49051da06c851af5", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 align=""cnter"">ADMIN</h1>

<br />
<br />

<table class=""table-striped"">
    <tr>
        <td>
            <label>Lokacije</label>
        </td>
        <td>
            <a class=""btn btn-primary"" href=""/Admin/Lokacija/Index"">Prikaz</a>
        </td>
    </tr>
    <tr>
        <td>
            <label>Uloge</label>
        </td>
        <td>
            <a class=""btn btn-primary"" href=""/Admin/Uloga/Index"">Prikaz</a>
        </td>
    </tr>
    <tr>
        <td>
            <label>Korisnici</label>
        </td>
        <td>
            <a class=""btn btn-primary"" href=""/Admin/Korisnik/Index"">Prikaz</a>
        </td>
    </tr>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
