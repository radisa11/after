#pragma checksum "C:\Users\Radisa\Desktop\MyCSharp\day5\after\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54f44e41d195fdfacbacb1d6466f9fefefb9cae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "C:\Users\Radisa\Desktop\MyCSharp\day5\after\Views\_ViewImports.cshtml"
using after;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Radisa\Desktop\MyCSharp\day5\after\Views\_ViewImports.cshtml"
using after.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54f44e41d195fdfacbacb1d6466f9fefefb9cae", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1401c22dde9113f0d637d154b5d8ed3a4718568b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Here is your Game</h1>\r\n<h2>Game Name: ");
#nullable restore
#line 4 "C:\Users\Radisa\Desktop\MyCSharp\day5\after\Views\Home\Results.cshtml"
          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Game Genre: ");
#nullable restore
#line 5 "C:\Users\Radisa\Desktop\MyCSharp\day5\after\Views\Home\Results.cshtml"
           Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Game Price: $");
#nullable restore
#line 6 "C:\Users\Radisa\Desktop\MyCSharp\day5\after\Views\Home\Results.cshtml"
            Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
