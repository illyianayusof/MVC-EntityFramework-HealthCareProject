#pragma checksum "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8510dfe91d3afee083b095d5a1eed623a8b4eaf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClientReview_Index), @"mvc.1.0.view", @"/Views/ClientReview/Index.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\_ViewImports.cshtml"
using HealthCareProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\_ViewImports.cshtml"
using HealthCareProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8510dfe91d3afee083b095d5a1eed623a8b4eaf6", @"/Views/ClientReview/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4fc26877fe15be3fa6158cf54ef3c36398e656b", @"/Views/_ViewImports.cshtml")]
    public class Views_ClientReview_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HealthCareProject.Models.HealthCareContext>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HospitalService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
   ViewData["Title"] = "Client";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-fluid\" align=\"center\" justify-content=\"center\" style=\"background-color:white;\">\r\n    <h1>Reviews from other Clients</h1>\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8510dfe91d3afee083b095d5a1eed623a8b4eaf64878", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <br />
    <br />

    <table class=""table-striped table-bordered"" align=""center"" justify-content=""center"">
        <thead align=""center"" justify-content=""center"">
            <tr align=""center"" justify-content=""center"">
                <th>
                    Id
                </th>
                <th>
                    Client Id
                </th>
                <th>
                    Doctor Id
                </th>
                <th>
                    Wait Time Rating
                </th>
                <th>
                    Doctor Rating
                </th>
                <th>
                    Review
                </th>
                <th>
                    Is doctor recommened? (Yes/No)
                </th>
                <th>
                    Review Date
                </th>
                <th style=""width:150px"">
                    Actions
                </th>


            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 54 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
             foreach (var item in (IEnumerable<HealthCareProject.Models.ClientReview>)ViewBag.ClientReview)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr align=\"center\" justify-content=\"center\">\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ClientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DoctorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.WaitTimeRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DoctorRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Review));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsDoctorRecommended));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 81 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ReviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-warning\"> ");
#nullable restore
#line 84 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                                                    Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        <button class=\"btn btn-danger\"> ");
#nullable restore
#line 85 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
                                                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n\r\n\r\n\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 93 "C:\Users\admin\source\repos\HealthCareProject\HealthCareProject\Views\ClientReview\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <br />\r\n\r\n\r\n\r\n\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HealthCareProject.Models.HealthCareContext>> Html { get; private set; }
    }
}
#pragma warning restore 1591
