#pragma checksum "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e5504518ac3c6794cafa1f8a5853fbd657db375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Views\_ViewImports.cshtml"
using MyUniqueNature;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Views\_ViewImports.cshtml"
using MyUniqueNature.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e5504518ac3c6794cafa1f8a5853fbd657db375", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87338ff827699ee2f793fbecbd0eaa2914ad88fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("slika_podloga"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Pictures/podloga.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyUniqueNature\MyUniqueNature\MyUniqueNature\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e5504518ac3c6794cafa1f8a5853fbd657db3754306", async() => {
                WriteLiteral(@"
    <link href=""//db.onlinewebfonts.com/c/4345cc7507f909b38498d8cff0f6d2f4?family=The+Abandoned+Treasure"" rel=""stylesheet"" type=""text/css"" />
    <script src=""jquery-3.5.1.min.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <style>
        html, body {
            margin: 0px;
        }

        body, html {
            height: 100%;
            width: 100%;
        }

        #container {
            height: 100%;
            width: 100%;
            /* border: 1px solid black; */
            font-family: ""The Abandoned Treasure"";
            margin: 0%;
        }

        #left, #right {
            position: relative;
            height: 100%;
            height: 100%;
            display: inline-block;
        }

        #left {
            /* background-color: red; */
            height: 90%;
            width: 50%;
            display: inline-block;
            float: left;
        }

        #right {
 ");
                WriteLiteral(@"           /* background-color: blue; */
            height: 100%;
            width: 50%;
            display: inline-block;
            float: right;
        }

        #header {
            position: relative;
            height: 100%;
            width: 100%;
            background-color: green;
        }

        #logo {
            position: relative;
            height: 100%;
            width: 10%;
            background-color: aqua;
        }

        #gost, #prijava, #registracija {
            position: relative;
            /* background-color: yellowgreen; */
            border: 3px solid white;
            height: 4.2vw;
            width: 25vw;
            text-align: center;
            font-size: 4vw;
            border-radius: 2vw;
            margin-left: 20%;
            cursor: pointer;
            transition: all ease 1s;
            color: white;
            /* -moz-transition-delay: 1s; */
            opacity:0.7;
        }

            #gost:hover");
                WriteLiteral(@", #prijava:hover, #registracija:hover {
                background-color: rgba(0, 0, 0, 0.7);
                color: white;
                transition: all ease 0.5s;
                -moz-transition-delay: 3s;
                font-weight: bold;
                text-decoration: underline;
                border: 5px solid gainsboro;
                opacity: 1;
            }

        #prijava {
            top: 13vw;
        }

        #registracija {
            top: 18vw;
        }

        #gost {
            top: 23vw;
        }

        #naslov {
            color: white;
            font-size: 9vw;
            text-align: center;
        }

        #naslov::selection, #prijava::selection, #gost::selection {
            margin: 0px;
            background-color: blue;
        }

        #slika_podloga {
            position: absolute;
            height: 100%;
            width: 100%;
        }
    </style>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e5504518ac3c6794cafa1f8a5853fbd657db3758371", async() => {
                WriteLiteral("\r\n    <div id=\"container\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e5504518ac3c6794cafa1f8a5853fbd657db3758667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


        <div id=""left"">
            <p id=""naslov"">
                MY<br /> UNIQUE<br /> NA TURE
            </p>

        </div>

        <div id=""right"">
            <div id=""prijava"">Log In</div>
            <div id=""registracija"">Sign In</div>
            <div id=""gost"">Guest</div>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            $(""#left"").hide().fadeIn(2000);
            $(""#right"").hide().delay(1000).fadeIn(2000);
        });
    </script>
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
