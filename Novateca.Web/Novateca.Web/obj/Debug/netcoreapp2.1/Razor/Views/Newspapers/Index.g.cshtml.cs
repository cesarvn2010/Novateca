#pragma checksum "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad094406633edf4f2ec8ac04252adc51a566f98f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Newspapers_Index), @"mvc.1.0.view", @"/Views/Newspapers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Newspapers/Index.cshtml", typeof(AspNetCore.Views_Newspapers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad094406633edf4f2ec8ac04252adc51a566f98f", @"/Views/Newspapers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e134d16ee1eff6868b6c84b1f6af932186d464", @"/Views/_ViewImports.cshtml")]
    public class Views_Newspapers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Novateca.Web.Models.Newspaper>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserPagesLayout.cshtml";

#line default
#line hidden
#line 7 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
 if (User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(183, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(200, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd2516880b949c5be148d718f8c0a21", async() => {
                BeginContext(223, 24, true);
                WriteLiteral("Catalogar novo periódico");
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
            BeginContext(251, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 12 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
}

#line default
#line hidden
            BeginContext(266, 84, true);
            WriteLiteral("<div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\" style=\"margin-bottom: 100px\">\r\n");
            EndContext();
#line 14 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(391, 209, true);
            WriteLiteral("        <div class=\"col-xs-4 col-sm-4 col-md-4 col-lg-4\">\r\n            <div class=\"card\" style=\"width: 250px; border: solid; border-color: aliceblue; border-radius: 5px; margin-bottom: 30px\">\r\n                ");
            EndContext();
            BeginContext(600, 553, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7bcf0282a744721930da1f41135a2e1", async() => {
                BeginContext(657, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                      
                        var imgSrc = "/images/sem imagem.jpg";
                        if (item.AvatarImage != null)
                        {
                            var base64 = Convert.ToBase64String(item.AvatarImage);
                            imgSrc = String.Format("data:image/gif;base64,{0}", base64);
                        }
                    

#line default
#line hidden
                BeginContext(1053, 24, true);
                WriteLiteral("                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1077, "\"", 1090, 1);
#line 27 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
WriteAttributeValue("", 1083, imgSrc, 1083, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1091, 58, true);
                WriteLiteral(" style=\"width: 200px; height: 200px;\" />\r\n                ");
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
#line 18 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                                          WriteLiteral(item.NewspaperID);

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
            BeginContext(1153, 121, true);
            WriteLiteral("\r\n                <div class=\"card-body\" style=\"margin:5px;\">\r\n                    <h5 class=\"card-title text-center\"><b>");
            EndContext();
            BeginContext(1275, 44, false);
#line 30 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.TitleMain));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 90, true);
            WriteLiteral("</b></h5>\r\n                    <p class=\"card-author text-center\" style=\"font-size: 12px\">");
            EndContext();
            BeginContext(1410, 52, false);
#line 31 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.PublishingCompany));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 87, true);
            WriteLiteral("</p>\r\n                    <p class=\"card-abstract text-center\" style=\"font-size: 10px\">");
            EndContext();
            BeginContext(1550, 42, false);
#line 32 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 66, true);
            WriteLiteral("</p>\r\n                    <div class=\"card-options text-center\">\r\n");
            EndContext();
#line 34 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
            BeginContext(1739, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1767, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85133c6c35b646e4b51437e9eca383f0", async() => {
                BeginContext(1821, 62, true);
                WriteLiteral("<i class=\"fa fa-pencil-square-o fa-2x\" aria-hidden=\"true\"></i>");
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
#line 36 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                                                   WriteLiteral(item.NewspaperID);

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
            BeginContext(1887, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1916, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("newspaperId", " newspaperId=\"", 1944, "\"", 1975, 1);
#line 38 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
WriteAttributeValue("", 1958, item.NewspaperID, 1958, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1976, 64, true);
            WriteLiteral(" class=\"btnLike\" style=\"display: inline-block;cursor:pointer\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2040, "\"", 2136, 3);
            WriteAttributeValue("", 2048, "fa", 2048, 2, true);
#line 38 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
WriteAttributeValue(" ", 2050, ViewBag.NewspaperLikes.Contains(item.NewspaperID) ? "fa-heart": "fa-heart-o", 2051, 79, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2130, "fa-2x", 2131, 6, true);
            EndWriteAttribute();
            BeginContext(2137, 79, true);
            WriteLiteral(" aria-hidden=\"true\" style=\"color: red\"></i></div>\r\n                        <div");
            EndContext();
            BeginWriteAttribute("newspaperId", " newspaperId=\"", 2216, "\"", 2247, 1);
#line 39 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
WriteAttributeValue("", 2230, item.NewspaperID, 2230, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2248, 68, true);
            WriteLiteral(" class=\"btnFavorite\" style=\"display: inline-block;cursor:pointer\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2316, "\"", 2414, 3);
            WriteAttributeValue("", 2324, "fa", 2324, 2, true);
#line 39 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
WriteAttributeValue(" ", 2326, ViewBag.FavoriteNewspapers.Contains(item.NewspaperID) ? "fa-star": "fa-star-o", 2327, 81, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2408, "fa-2x", 2409, 6, true);
            EndWriteAttribute();
            BeginContext(2415, 56, true);
            WriteLiteral(" aria-hidden=\"true\" style=\"color: #2097a8;\"></i></div>\r\n");
            EndContext();
#line 40 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
            BeginContext(2552, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2580, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47a9597d240849758ae7ea8a22f945c8", async() => {
                BeginContext(2636, 54, true);
                WriteLiteral("<i class=\"fa fa-trash-o fa-2x\" aria-hidden=\"true\"></i>");
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
#line 42 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                                                     WriteLiteral(item.NewspaperID);

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
            BeginContext(2694, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2723, 88, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 48 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2818, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2845, 150, true);
                WriteLiteral("\r\n    <script>\r\n    $(\".btnLike\").on(\"click\", function () {\r\n        obj = $(this);\r\n        $.ajax({\r\n            method: \"POST\",\r\n            url: \"");
                EndContext();
                BeginContext(2996, 35, false);
#line 57 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
             Write(Url.Action("Like","NewspaperLikes"));

#line default
#line hidden
                EndContext();
                BeginContext(3031, 387, true);
                WriteLiteral(@""",
            dataType: ""json"",
            data: { id: obj.attr(""newspaperId"") },
            success: function (data) {
                //$.notify(data, ""success"");
                location.reload();
            }
        });
    });

     $("".btnFavorite"").on(""click"", function () {
        obj = $(this);
        $.ajax({
            method: ""POST"",
            url: """);
                EndContext();
                BeginContext(3419, 43, false);
#line 71 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Newspapers\Index.cshtml"
             Write(Url.Action("Favorite","FavoriteNewspapers"));

#line default
#line hidden
                EndContext();
                BeginContext(3462, 263, true);
                WriteLiteral(@""",
            dataType: ""json"",
            data: { id: obj.attr(""newspaperId"") },
            success: function (data) {
                //$.notify(data, ""success"");
                location.reload();
            }
        });
    });

    </script>
");
                EndContext();
            }
            );
            BeginContext(3728, 94, true);
            WriteLiteral("\r\n<style>\r\n    .fa-2x {\r\n        font-size: 1.7em;\r\n        color: #02223e;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Novateca.Web.Models.Newspaper>> Html { get; private set; }
    }
}
#pragma warning restore 1591
