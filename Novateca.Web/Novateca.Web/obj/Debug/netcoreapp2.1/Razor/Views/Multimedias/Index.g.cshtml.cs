#pragma checksum "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91b40477f4ea8f687339b9548be12fe394472639"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Multimedias_Index), @"mvc.1.0.view", @"/Views/Multimedias/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Multimedias/Index.cshtml", typeof(AspNetCore.Views_Multimedias_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b40477f4ea8f687339b9548be12fe394472639", @"/Views/Multimedias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e134d16ee1eff6868b6c84b1f6af932186d464", @"/Views/_ViewImports.cshtml")]
    public class Views_Multimedias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Novateca.Web.Models.Multimedia>>
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserPagesLayout.cshtml";

#line default
#line hidden
            BeginContext(151, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(162, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48886dda4e54e7f92f451176c1b474b", async() => {
                BeginContext(185, 25, true);
                WriteLiteral("Catalogar nova multimídia");
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
            BeginContext(214, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(4053, 55, true);
            WriteLiteral("<div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\r\n");
            EndContext();
#line 120 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(4149, 189, true);
            WriteLiteral("        <div class=\"col-xs-4 col-sm-4 col-md-4 col-lg-4\">\r\n            <div class=\"card\" style=\"width: 250px; border: solid; border-color: aliceblue; border-radius: 5px;\">\r\n                ");
            EndContext();
            BeginContext(4338, 280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bdacb913ff24f35a2aefa100413db26", async() => {
                BeginContext(4396, 47, true);
                WriteLiteral("\r\n                    <img class=\"card-img-top\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4443, "\"", 4493, 1);
#line 125 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
WriteAttributeValue("", 4449, Html.DisplayFor(modelItem => item.URLImage), 4449, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4494, 120, true);
                WriteLiteral(" alt=\"Card image cap\"\r\n                         style=\"width:230px; height:200px; margin: 5px;\"><br />\r\n                ");
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
#line 124 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
                                          WriteLiteral(item.MultimediaID);

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
            BeginContext(4618, 121, true);
            WriteLiteral("\r\n                <div class=\"card-body\" style=\"margin:5px;\">\r\n                    <h5 class=\"card-title text-center\"><b>");
            EndContext();
            BeginContext(4740, 44, false);
#line 129 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.TitleMain));

#line default
#line hidden
            EndContext();
            BeginContext(4784, 90, true);
            WriteLiteral("</b></h5>\r\n                    <p class=\"card-author text-center\" style=\"font-size: 12px\">");
            EndContext();
            BeginContext(4875, 43, false);
#line 130 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
            EndContext();
            BeginContext(4918, 348, true);
            WriteLiteral(@"</p>
                    <button class=""collapsible""><p class=""text-center"">Ver sinopse</p></button>

                    <div class=""content"" style=""padding: 0 18px; display: none; overflow: hidden; background-color: #f1f1f1;"">
                        <p> <p class=""card-abstract text-capitalize center"" style=""height: 100px; font-size: 10px"">");
            EndContext();
            BeginContext(5267, 43, false);
#line 134 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
                                                                                                              Write(Html.DisplayFor(modelItem => item.Abstract));

#line default
#line hidden
            EndContext();
            BeginContext(5310, 118, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"card-options text-center\">\r\n                        ");
            EndContext();
            BeginContext(5428, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdbc0bdb8b6144fab961dc31be0a74a2", async() => {
                BeginContext(5483, 62, true);
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
#line 137 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
                                               WriteLiteral(item.MultimediaID);

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
            BeginContext(5549, 30, true);
            WriteLiteral("\r\n                        <div");
            EndContext();
            BeginWriteAttribute("multimediaId", " multimediaId=\"", 5579, "\"", 5612, 1);
#line 138 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
WriteAttributeValue("", 5594, item.MultimediaID, 5594, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5613, 64, true);
            WriteLiteral(" class=\"btnLike\" style=\"display: inline-block;cursor:pointer\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5677, "\"", 5775, 3);
            WriteAttributeValue("", 5685, "fa", 5685, 2, true);
#line 138 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
WriteAttributeValue(" ", 5687, ViewBag.MultimediaLikes.Contains(item.MultimediaID) ? "fa-heart": "fa-heart-o", 5688, 81, false);

#line default
#line hidden
            WriteAttributeValue(" ", 5769, "fa-2x", 5770, 6, true);
            EndWriteAttribute();
            BeginContext(5776, 75, true);
            WriteLiteral(" aria-hidden=\"true\" style=\"color: red\"></i></div>\r\n                        ");
            EndContext();
            BeginContext(5851, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bc0469969f043389d8007da9068f662", async() => {
                BeginContext(5908, 57, true);
                WriteLiteral("<i class=\"fa fa-commenting fa-2x\" aria-hidden=\"true\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 139 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
                                                 WriteLiteral(item.MultimediaID);

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
            BeginContext(5969, 30, true);
            WriteLiteral("\r\n                        <div");
            EndContext();
            BeginWriteAttribute("multimediaId", " multimediaId=\"", 5999, "\"", 6032, 1);
#line 140 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
WriteAttributeValue("", 6014, item.MultimediaID, 6014, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6033, 68, true);
            WriteLiteral(" class=\"btnFavorite\" style=\"display: inline-block;cursor:pointer\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6101, "\"", 6201, 3);
            WriteAttributeValue("", 6109, "fa", 6109, 2, true);
#line 140 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
WriteAttributeValue(" ", 6111, ViewBag.FavoriteMultimedias.Contains(item.MultimediaID) ? "fa-star": "fa-star-o", 6112, 83, false);

#line default
#line hidden
            WriteAttributeValue(" ", 6195, "fa-2x", 6196, 6, true);
            EndWriteAttribute();
            BeginContext(6202, 78, true);
            WriteLiteral(" aria-hidden=\"true\" style=\"color: yellow\"></i></div>\r\n                        ");
            EndContext();
            BeginContext(6280, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94d81d229b34043b94b6e7196142582", async() => {
                BeginContext(6337, 54, true);
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
#line 141 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
                                                 WriteLiteral(item.MultimediaID);

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
            BeginContext(6395, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 146 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(6492, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6519, 150, true);
                WriteLiteral("\r\n    <script>\r\n    $(\".btnLike\").on(\"click\", function () {\r\n        obj = $(this);\r\n        $.ajax({\r\n            method: \"POST\",\r\n            url: \"");
                EndContext();
                BeginContext(6670, 36, false);
#line 155 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
             Write(Url.Action("Like","MultimediaLikes"));

#line default
#line hidden
                EndContext();
                BeginContext(6706, 433, true);
                WriteLiteral(@""",
            dataType: ""json"",
            data: { id: obj.attr(""multimediaId"") },
            success: function (data) {
                //$.notify(data, ""success"");
                obj.css({ ""color"": ""red"" })
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
                BeginContext(7140, 44, false);
#line 170 "C:\Users\cesar\Documents\GitHub\Novateca\Novateca.Web\Novateca.Web\Views\Multimedias\Index.cshtml"
             Write(Url.Action("Favorite","FavoriteMultimedias"));

#line default
#line hidden
                EndContext();
                BeginContext(7184, 312, true);
                WriteLiteral(@""",
            dataType: ""json"",
            data: { id: obj.attr(""multimediaId"") },
            success: function (data) {
                //$.notify(data, ""success"");
                obj.css({ ""color"": ""yellow"" })
                location.reload();
            }
        });
    });

    </script>
");
                EndContext();
            }
            );
            BeginContext(7499, 96, true);
            WriteLiteral("\r\n<style>\r\n    .fa-2x {\r\n        font-size: 1.7em;\r\n        color: #02223e;\r\n    }\r\n</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Novateca.Web.Models.Multimedia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
