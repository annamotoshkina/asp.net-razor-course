#pragma checksum "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Shared\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf0ba0e017fe2d5d40e06cba52017213983ba34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SparkAuto.Pages.Shared.Pages_Shared__StatusMessage), @"mvc.1.0.view", @"/Pages/Shared/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_StatusMessage.cshtml", typeof(SparkAuto.Pages.Shared.Pages_Shared__StatusMessage))]
namespace SparkAuto.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf0ba0e017fe2d5d40e06cba52017213983ba34", @"/Pages/Shared/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47c6e9be6d81a789d3680fae9ed89376b343ede", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Shared\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(136, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#line 6 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Shared\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            BeginContext(202, 158, true);
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            EndContext();
            BeginContext(361, 5, false);
#line 8 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Shared\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(366, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 10 "C:\Users\Anna.P4B\Documents\asp.net-razor-course\SparkAuto\SparkAuto\SparkAuto\Pages\Shared\_StatusMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
