#pragma checksum "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54b557b51771009d6bb8e6d54183d823f60e5166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/Index.cshtml", typeof(AspNetCore.Views_Course_Index))]
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
#line 1 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\_ViewImports.cshtml"
using ClassTimeTable;

#line default
#line hidden
#line 2 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\_ViewImports.cshtml"
using ClassTimeTable.Models;

#line default
#line hidden
#line 1 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
using ClassTimeTable.Models.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b557b51771009d6bb8e6d54183d823f60e5166", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76218ca98ccd7f992b418bb5b373791ca5f0f88b", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 94, true);
            WriteLiteral("<br />\n<h2 class=\"text-primary text-center\">Courses</h2>\n<br />\n<div class=\"text-center\">\n    ");
            EndContext();
            BeginContext(195, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54b557b51771009d6bb8e6d54183d823f60e51664684", async() => {
                BeginContext(250, 10, true);
                WriteLiteral("Add New???");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(264, 627, true);
            WriteLiteral(@"
</div>
<br />
<div class=""row"">
    <div class=""col-sm-1"">
    </div>
    <div class=""col-sm-10"">
        <div>
            <table class=""table table-hover table-bordered"" id=""myTable"">
                <tr class=""table-primary"">
                    <th class=""text-center"">Course_Title</th>
                    <th class=""text-center"">Course_Code</th>
                    <th class=""text-center"">Number_Of_Students</th>
                    <th class=""text-center"">Instructor</th>
                    <th class=""text-center"">Batch</th>
                    <th class=""text-center text-danger"">Actions</th>
                </tr>
");
            EndContext();
#line 27 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(954, 73, true);
            WriteLiteral("                    <tr>\n                        <td class=\"text-center\">");
            EndContext();
            BeginContext(1028, 16, false);
#line 30 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
                                           Write(item.CourseTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 54, true);
            WriteLiteral("</td>\n                        <td class=\"text-center\">");
            EndContext();
            BeginContext(1099, 15, false);
#line 31 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
                                           Write(item.CourseCode);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 54, true);
            WriteLiteral("</td>\n                        <td class=\"text-center\">");
            EndContext();
            BeginContext(1169, 21, false);
#line 32 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
                                           Write(item.MaxNumOfStudents);

#line default
#line hidden
            EndContext();
            BeginContext(1190, 54, true);
            WriteLiteral("</td>\n                        <td class=\"text-center\">");
            EndContext();
            BeginContext(1245, 20, false);
#line 33 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
                                           Write(item.Instructor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1265, 54, true);
            WriteLiteral("</td>\n                        <td class=\"text-center\">");
            EndContext();
            BeginContext(1320, 15, false);
#line 34 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
                                           Write(item.Batch.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1335, 30, true);
            WriteLiteral("</td>\n                        ");
            EndContext();
            BeginContext(1365, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54b557b51771009d6bb8e6d54183d823f60e51669198", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 35 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1415, 27, true);
            WriteLiteral("\n                    </tr>\n");
            EndContext();
#line 37 "F:\Study\SixCrdt\ClassTimeTable\ClassTimeTable\Views\Course\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1460, 92, true);
            WriteLiteral("            </table>\n        </div>\n    </div>\n    <div class=\"col-sm-1\">\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
