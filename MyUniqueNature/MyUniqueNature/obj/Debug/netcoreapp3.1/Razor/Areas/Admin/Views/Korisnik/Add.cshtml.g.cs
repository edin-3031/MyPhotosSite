#pragma checksum "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "701869c43a9049177c1b5ea371acdf0053e487b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Korisnik_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Korisnik/Add.cshtml")]
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
#line 1 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
using MyUniqueNature.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701869c43a9049177c1b5ea371acdf0053e487b0", @"/Areas/Admin/Views/Korisnik/Add.cshtml")]
    public class Areas_Admin_Views_Korisnik_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

    List<Uloga> u = (List<Uloga>)ViewData["uloge"];
    List<Lokacija> l = (List<Lokacija>)ViewData["lokacije"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <form method=""post"" action=""/Admin/Korisnik/AddSave"">
        <table>
            <tr>
                <td>
                    <label>
                        Ime
                    </label>
                </td>
                <td>
                    <input name=""ime"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Prezime
                    </label>
                </td>
                <td>
                    <input name=""prezime"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Lozinka
                    </label>
                </td>
                <td>
                    <input type=""password"" name=""lozinka"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Confirm password
                    </la");
            WriteLiteral(@"bel>
                </td>
                <td>
                    <input type=""password"" name=""lozinka2"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Birth Date
                    </label>
                </td>
                <td>
                    <input name=""datum"" type=""datetime-local"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        e-Mail
                    </label>
                </td>
                <td>
                    <input name=""mail"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Location
                    </label>
                </td>
                <td>
                    <select name=""lokacija"">
                        <option value=""0"">---Choose---</option>
");
#nullable restore
#line 81 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
                         foreach(var x in l)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 2330, "\"", 2351, 1);
#nullable restore
#line 83 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
WriteAttributeValue("", 2338, x.LokacijaID, 2338, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
                                                     Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 84 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Role
                    </label>
                </td>
                <td>
                    <select name=""uloga"">
                        <option value=""0"">---Choose---</option>
");
#nullable restore
#line 97 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
                         foreach (var x in u)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 2863, "\"", 2881, 1);
#nullable restore
#line 99 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
WriteAttributeValue("", 2871, x.UlogaID, 2871, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 99 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
                                                  Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 100 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Areas\Admin\Views\Korisnik\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <button class=\"btn btn-success\" type=\"submit\">Save</button>\r\n    </form>\r\n</center>");
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
