#pragma checksum "C:\Users\Section3\source\repos\CourseApp\CourseApp\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df02dfda9cd351ff0ae585ce864693f8c6281826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
#line 1 "C:\Users\Section3\source\repos\CourseApp\CourseApp\Views\_ViewImports.cshtml"
using CourseApp;

#line default
#line hidden
#line 2 "C:\Users\Section3\source\repos\CourseApp\CourseApp\Views\_ViewImports.cshtml"
using CourseApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df02dfda9cd351ff0ae585ce864693f8c6281826", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25cf362a2d98b62e6d9b6eae7eb847a1039383a", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Section3\source\repos\CourseApp\CourseApp\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 18, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
            EndContext();
#line 7 "C:\Users\Section3\source\repos\CourseApp\CourseApp\Views\Contact\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(121, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(129, 10, false);
#line 9 "C:\Users\Section3\source\repos\CourseApp\CourseApp\Views\Contact\Index.cshtml"
  Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(139, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(153, 10, false);
#line 10 "C:\Users\Section3\source\repos\CourseApp\CourseApp\Views\Contact\Index.cshtml"
  Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(163, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\Section3\source\repos\CourseApp\CourseApp\Views\Contact\Index.cshtml"
}

#line default
#line hidden
            BeginContext(172, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
