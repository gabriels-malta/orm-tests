#pragma checksum "C:\Users\gabri\source\github\ObjectModelRelationship\Dapper\DapperSample\DapperSample\Views\Home\Authors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f002803f9931967c36e7d01249c2034d45685830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Authors), @"mvc.1.0.view", @"/Views/Home/Authors.cshtml")]
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
#line 1 "C:\Users\gabri\source\github\ObjectModelRelationship\Dapper\DapperSample\DapperSample\Views\_ViewImports.cshtml"
using DapperSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\source\github\ObjectModelRelationship\Dapper\DapperSample\DapperSample\Views\_ViewImports.cshtml"
using DapperSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f002803f9931967c36e7d01249c2034d45685830", @"/Views/Home/Authors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"911e009c2933a0b16de1a4ab21560cf7635b0f50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Authors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DapperSample.Models.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Authors list</h1>\r\n<div class=\"table table-responsive\">\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n            <td>Id</td>\r\n            <td>Name</td>\r\n            <td>E-mail</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\gabri\source\github\ObjectModelRelationship\Dapper\DapperSample\DapperSample\Views\Home\Authors.cshtml"
             foreach (Author item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\gabri\source\github\ObjectModelRelationship\Dapper\DapperSample\DapperSample\Views\Home\Authors.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\gabri\source\github\ObjectModelRelationship\Dapper\DapperSample\DapperSample\Views\Home\Authors.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\gabri\source\github\ObjectModelRelationship\Dapper\DapperSample\DapperSample\Views\Home\Authors.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\gabri\source\github\ObjectModelRelationship\Dapper\DapperSample\DapperSample\Views\Home\Authors.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DapperSample.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
