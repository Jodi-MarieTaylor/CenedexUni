#pragma checksum "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6f0c6d0dc2a47142ab2b9c0621bda0d8c4350e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseLecturers_Index), @"mvc.1.0.view", @"/Views/CourseLecturers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CourseLecturers/Index.cshtml", typeof(AspNetCore.Views_CourseLecturers_Index))]
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
#line 1 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\_ViewImports.cshtml"
using CenedexUniversity;

#line default
#line hidden
#line 2 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\_ViewImports.cshtml"
using CenedexUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6f0c6d0dc2a47142ab2b9c0621bda0d8c4350e", @"/Views/CourseLecturers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c70c055866b84f7fc504b9081236db40f35295", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseLecturers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CenedexUniversity.Model.CourseLecturer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(103, 358, true);
            WriteLiteral(@"



<div class=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""#"">Courses and Lecturers Link</a>

            </li>
        </ol>
        <div class=""searchdiv "">
            <b>Search By Name : </b>
            ");
            EndContext();
            BeginContext(462, 22, false);
#line 21 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
       Write(Html.TextBox("Search"));

#line default
#line hidden
            EndContext();
            BeginContext(484, 310, true);
            WriteLiteral(@"<input type=""submit"" id=""searchbtn"" value=""Search"" /><br /><br />
        </div>
        <div class=""row"">
            <div class=""col-md-8"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(795, 42, false);
#line 29 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
            EndContext();
            BeginContext(837, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(941, 44, false);
#line 32 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Lecturer));

#line default
#line hidden
            EndContext();
            BeginContext(985, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1232, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1341, 46, false);
#line 42 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Course.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1503, 48, false);
#line 45 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Lecturer.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1667, 65, false);
#line 48 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(1773, 71, false);
#line 49 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(1885, 69, false);
#line 50 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 53 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2057, 129, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2186, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6f0c6d0dc2a47142ab2b9c0621bda0d8c4350e9896", async() => {
                BeginContext(2208, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2224, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2254, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 68 "C:\Users\jodim\source\repos\CenedexUniversity\CenedexUniversity\Views\CourseLecturers\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
            BeginContext(2327, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2329, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6f0c6d0dc2a47142ab2b9c0621bda0d8c4350e11801", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2380, 2340, true);
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        $(""#searchbtn"").click(function () {
            var input = $(""#Search"").val();
            var SetData = $(""#searchresults"");
            SetData.html("""");
            $.ajax({
                type: ""post"",
                url: ""/CourseLecturers/Search?Input="" + input,
                contentType: ""html"",
                success: function (result) {
                    console.log(""result"", result.status);
                    if (result.status == 200) {
                        if (result.length == 0) {
                            SetData.append('<tr style=""color:red""><td colspan=""3"">No Match Data</td></tr>')
                        } else {
                            $.each(result.values, function (index, value) {
                                console.log(""Value - "", value);
                                var Data = ""<tr>"" +
                                    ""<td>"" + value.Name + ""</td>"" +
                                 
  ");
            WriteLiteral(@"                                  ""</tr>"";
                                SetData.append(Data);
                            });

                        }
                    }
                    //if (result.length == 0) {
                    //    SetData.append('<tr style=""color:red""><td colspan=""3"">No Match Data</td></tr>')
                    //}
                    //else {
                    //    $.each(result, function (index, results) {
                    //        console.log(""Results - "", results)
                    //        if (results.status == 200) {
                    //            var value = results.values;
                    //            var Data = ""<tr>"" +
                    //                ""<td>"" + value.FirstName + ""</td>"" +
                    //                ""<td>"" + value.LastName + ""</td>"" +
                    //                ""<td>"" + value.DateOfBirth + ""</td>"" +
                    //                ""</tr>"";
                    //            SetD");
            WriteLiteral(@"ata.append(Data);
                    //        } else {
                    //            console.log(""Error - "", result.message)
                    //        }

                    //    });
                    //}
                }
            });
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CenedexUniversity.Model.CourseLecturer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
