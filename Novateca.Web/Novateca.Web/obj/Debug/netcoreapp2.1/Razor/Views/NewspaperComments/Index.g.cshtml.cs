#pragma checksum "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ea0bcb8f4338b1738cf846a7bf958761a8d4c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewspaperComments_Index), @"mvc.1.0.view", @"/Views/NewspaperComments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewspaperComments/Index.cshtml", typeof(AspNetCore.Views_NewspaperComments_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ea0bcb8f4338b1738cf846a7bf958761a8d4c87", @"/Views/NewspaperComments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e134d16ee1eff6868b6c84b1f6af932186d464", @"/Views/_ViewImports.cshtml")]
    public class Views_NewspaperComments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Novateca.Web.Models.NewspaperComment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserPagesLayout.cshtml";

#line default
#line hidden
            BeginContext(157, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(186, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c79416f8079f48d5b2be9833c5c4656d", async() => {
                BeginContext(209, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(316, 51, false);
#line 17 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ApplicationUser));

#line default
#line hidden
            EndContext();
            BeginContext(367, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(423, 45, false);
#line 20 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Newspaper));

#line default
#line hidden
            EndContext();
            BeginContext(468, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(524, 43, false);
#line 23 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(567, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(623, 47, false);
#line 26 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommentDate));

#line default
#line hidden
            EndContext();
            BeginContext(670, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(726, 50, false);
#line 29 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommentEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(776, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(894, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(943, 60, false);
#line 38 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ApplicationUser.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1059, 63, false);
#line 41 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Newspaper.CurrentPeriodicity));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1178, 42, false);
#line 44 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1276, 46, false);
#line 47 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CommentDate));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1378, 49, false);
#line 50 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CommentEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1482, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cae5a461bc9471ab2bc1c11f886ffaa", async() => {
                BeginContext(1543, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
                                       WriteLiteral(item.NewspaperCommentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1551, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1571, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f3f5500ad14789b90d0a81af48e860", async() => {
                BeginContext(1635, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
                                          WriteLiteral(item.NewspaperCommentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1646, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1666, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0428c741984173a74c2f6a3135d92e", async() => {
                BeginContext(1729, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
                                         WriteLiteral(item.NewspaperCommentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1739, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\NewspaperComments\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1778, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Novateca.Web.Models.NewspaperComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
