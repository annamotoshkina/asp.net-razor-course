#pragma checksum "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b24348679bf515fd7b304b2e7ccde73cd1e579b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SparkAuto.Pages.Services.Pages_Services_History), @"mvc.1.0.razor-page", @"/Pages/Services/History.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Services/History.cshtml", typeof(SparkAuto.Pages.Services.Pages_Services_History), null)]
namespace SparkAuto.Pages.Services
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto;

#line default
#line hidden
#line 3 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b24348679bf515fd7b304b2e7ccde73cd1e579b", @"/Pages/Services/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47c6e9be6d81a789d3680fae9ed89376b343ede", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Services_History : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Cars/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
  
    ViewData["Title"] = "History";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 193, true);
            WriteLiteral("\r\n<div class=\"container pt-4 pb-2 row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info py-2\">Service History</h2>\r\n    </div>\r\n    <div class=\"col-3 offset-3 text-right py-2\">\r\n        ");
            EndContext();
            BeginContext(336, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b24348679bf515fd7b304b2e7ccde73cd1e579b5316", async() => {
                BeginContext(442, 36, true);
                WriteLiteral("\r\n            Back to List\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                          WriteLiteral(Model.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(482, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
 if (Model.ServiceHeader.Count == 0)
{

#line default
#line hidden
            BeginContext(547, 90, true);
            WriteLiteral("    <div class=\"backgroundWhite\">\r\n        <p>No Service Record Found...</p>\r\n    </div>\r\n");
            EndContext();
#line 24 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(649, 379, true);
            WriteLiteral(@"    <div class=""container backgroundWhite"">
        <div class=""card"">
            <div class=""card-header bg-dark text-light ml-0 row container"">
                <div class=""col-1 text-center pt-3 text-white-50"">
                    <i class=""fas fa-user fa-2x""></i>
                </div>
                <div class=""col-5"">
                    <label class=""text-info"">");
            EndContext();
            BeginContext(1029, 47, false);
#line 34 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                        Write(Model.ServiceHeader[0].Car.ApplicationUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 61, true);
            WriteLiteral("</label><br />\r\n                    <label class=\"text-info\">");
            EndContext();
            BeginContext(1138, 48, false);
#line 35 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                        Write(Model.ServiceHeader[0].Car.ApplicationUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(1190, 54, false);
#line 35 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                                                                            Write(Model.ServiceHeader[0].Car.ApplicationUser.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 134, true);
            WriteLiteral(" </label><br />\r\n                </div>\r\n                <div class=\"col-5 text-right\">\r\n                    <label class=\"text-info\">");
            EndContext();
            BeginContext(1379, 31, false);
#line 38 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                        Write(Model.ServiceHeader[0].Car.Make);

#line default
#line hidden
            EndContext();
            BeginContext(1410, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1412, 32, false);
#line 38 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                                                         Write(Model.ServiceHeader[0].Car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1446, 32, false);
#line 38 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                                                                                           Write(Model.ServiceHeader[0].Car.Style);

#line default
#line hidden
            EndContext();
            BeginContext(1478, 61, true);
            WriteLiteral("</label><br />\r\n                    <label class=\"text-info\">");
            EndContext();
            BeginContext(1540, 31, false);
#line 39 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                        Write(Model.ServiceHeader[0].Car.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 383, true);
            WriteLiteral(@"</label><br />
                </div>
                <div class=""col-1 text-center pt-3 text-white-50"">
                    <i class=""fas fa-car fa-2x""></i>
                </div>
            </div>

            <div class=""card-body"">
                <table class=""table table-striped border"">
                    <tr class=""table-secondary"">
                        <th>");
            EndContext();
            BeginContext(1955, 68, false);
#line 49 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                       Write(Html.DisplayNameFor(m => Model.ServiceHeader.FirstOrDefault().Miles));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(2059, 73, false);
#line 50 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                       Write(Html.DisplayNameFor(m => Model.ServiceHeader.FirstOrDefault().TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(2168, 70, false);
#line 51 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                       Write(Html.DisplayNameFor(m => Model.ServiceHeader.FirstOrDefault().Details));

#line default
#line hidden
            EndContext();
            BeginContext(2238, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(2274, 72, false);
#line 52 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                       Write(Html.DisplayNameFor(m => Model.ServiceHeader.FirstOrDefault().DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(2346, 69, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                     foreach (var item in Model.ServiceHeader)
                    {

#line default
#line hidden
            BeginContext(2502, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2565, 32, false);
#line 58 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                           Write(Html.DisplayFor(m => item.Miles));

#line default
#line hidden
            EndContext();
            BeginContext(2597, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2637, 37, false);
#line 59 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                           Write(Html.DisplayFor(m => item.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2674, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2714, 34, false);
#line 60 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                           Write(Html.DisplayFor(m => item.Details));

#line default
#line hidden
            EndContext();
            BeginContext(2748, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2788, 36, false);
#line 61 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                           Write(Html.DisplayFor(m => item.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(2824, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2897, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b24348679bf515fd7b304b2e7ccde73cd1e579b16692", async() => {
                BeginContext(2984, 111, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-list-alt\"></i> Details\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-serviceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-serviceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3099, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 68 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
                    }

#line default
#line hidden
            BeginContext(3190, 74, true);
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 73 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Services\History.cshtml"
}

#line default
#line hidden
            BeginContext(3267, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SparkAuto.Pages.Services.HistoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.Services.HistoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.Services.HistoryModel>)PageContext?.ViewData;
        public SparkAuto.Pages.Services.HistoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591