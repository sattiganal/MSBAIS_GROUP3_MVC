#pragma checksum "C:\Users\Venkat\Source\Repos\sattiganal\MSBAIS_GROUP3_MVC\Group3MVCApp\Views\Input\Name.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa997d9e3997126796c0ce727f2532bf35c0866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Input_Name), @"mvc.1.0.view", @"/Views/Input/Name.cshtml")]
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
#line 1 "C:\Users\Venkat\Source\Repos\sattiganal\MSBAIS_GROUP3_MVC\Group3MVCApp\Views\_ViewImports.cshtml"
using Group3MVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Venkat\Source\Repos\sattiganal\MSBAIS_GROUP3_MVC\Group3MVCApp\Views\_ViewImports.cshtml"
using Group3MVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa997d9e3997126796c0ce727f2532bf35c0866", @"/Views/Input/Name.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402d1d1534850ad175a91aca9b766e79ccdfcf5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Input_Name : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Venkat\Source\Repos\sattiganal\MSBAIS_GROUP3_MVC\Group3MVCApp\Views\Input\Name.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Venkat\Source\Repos\sattiganal\MSBAIS_GROUP3_MVC\Group3MVCApp\Views\Input\Name.cshtml"
Write(Html.TextBox("id", null, new { placeholder = "Your Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 10 "C:\Users\Venkat\Source\Repos\sattiganal\MSBAIS_GROUP3_MVC\Group3MVCApp\Views\Input\Name.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
