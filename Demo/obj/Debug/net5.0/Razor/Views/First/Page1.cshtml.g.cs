#pragma checksum "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89f746cdf861c3b8de928bc49ff24d44264fd0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_First_Page1), @"mvc.1.0.view", @"/Views/First/Page1.cshtml")]
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
#line 1 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\_ViewImports.cshtml"
using Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\_ViewImports.cshtml"
using Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89f746cdf861c3b8de928bc49ff24d44264fd0f", @"/Views/First/Page1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18407c5b9dabc62761fc6cdd8f67817f22bc556", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_First_Page1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Hello FRom View :)</h1>\r\n<script>\r\n    //alert(\"hello\");\r\n</script>\r\n<style>\r\n    .class1{color:red}\r\n</style>\r\n");
#nullable restore
#line 9 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
  
    int x = 7;
    int y = 9;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 12 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
    Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 15 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
 if(x>y){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div> x=");
#nullable restore
#line 16 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
       Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" greater than y=");
#nullable restore
#line 16 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
                         Write(y);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 17 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div> x=");
#nullable restore
#line 19 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
       Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Less than y=");
#nullable restore
#line 19 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
                      Write(y);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 20 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
 for (int i = 0; i < 5; i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 22 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 23 "E:\ITI Courses\MVC\Day1\Day1\Demo\Demo\Views\First\Page1.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591