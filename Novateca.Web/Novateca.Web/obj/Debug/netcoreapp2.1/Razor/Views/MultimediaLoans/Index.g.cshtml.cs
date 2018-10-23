#pragma checksum "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8972f339dae5c762540d29a0706005e82419dc5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MultimediaLoans_Index), @"mvc.1.0.view", @"/Views/MultimediaLoans/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MultimediaLoans/Index.cshtml", typeof(AspNetCore.Views_MultimediaLoans_Index))]
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
#line 1 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\_ViewImports.cshtml"
using Novateca.Web;

#line default
#line hidden
#line 3 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\_ViewImports.cshtml"
using Novateca.Web.Models;

#line default
#line hidden
#line 4 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\_ViewImports.cshtml"
using Novateca.Web.Models.AccountViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8972f339dae5c762540d29a0706005e82419dc5e", @"/Views/MultimediaLoans/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e134d16ee1eff6868b6c84b1f6af932186d464", @"/Views/_ViewImports.cshtml")]
    public class Views_MultimediaLoans_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Novateca.Web.Models.MultimediaLoan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserPagesLayout.cshtml";

#line default
#line hidden
            BeginContext(155, 516, true);
            WriteLiteral(@"
<h2>Multimídias emprestadas</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Data do empréstimo
            </th>
            <th>
                Data de devolução efetivada
            </th>
            <th>
                Data de devolução esperada
            </th>
            <th>
                Usuário
            </th>
            <th>
                Multimídia
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 32 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(720, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(769, 43, false);
#line 36 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanDate));

#line default
#line hidden
            EndContext();
            BeginContext(812, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 39 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
                 if (Equals(item.DevolutionDate.ToString(), "01/01/0001 00:00:00") == true)
                {

#line default
#line hidden
            BeginContext(963, 59, true);
            WriteLiteral("                    <p>Devolução ainda não efetivada.</p>\r\n");
            EndContext();
#line 42 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1103, 49, false);
#line 45 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DevolutionDate));

#line default
#line hidden
            EndContext();
#line 45 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
                                                                      
                }

#line default
#line hidden
            BeginContext(1173, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1227, 53, false);
#line 49 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DevolutionDateMade));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1336, 59, false);
#line 52 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ApplicationUser.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1451, 55, false);
#line 55 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Multimedia.TitleMain));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1821, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\MultimediaLoans\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1847, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Novateca.Web.Models.MultimediaLoan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
