#pragma checksum "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Notes\Views\Home\PostNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1af74e48d9f65c7c0ae204d5c885e3162648adb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PostNote), @"mvc.1.0.view", @"/Views/Home/PostNote.cshtml")]
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
#line 1 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Notes\Views\_ViewImports.cshtml"
using Notes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Notes\Views\_ViewImports.cshtml"
using Notes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1af74e48d9f65c7c0ae204d5c885e3162648adb", @"/Views/Home/PostNote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e57c90144c392f01e58fa7fe512fe55d3cc85a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PostNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Notes.Models.Note>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Notes\Views\Home\PostNote.cshtml"
  
    ViewData["Title"] = "Note";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n\r\n\r\n    <div class=\"card-body mb-3\">\r\n        <h4 class=\"card-title text-center\">");
#nullable restore
#line 12 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Notes\Views\Home\PostNote.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h6 class=\"card-subtitle mb-2 text-muted text-center\">");
#nullable restore
#line 13 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Notes\Views\Home\PostNote.cshtml"
                                                         Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n    </div>\r\n    <div class=\"container\">\r\n        <article>\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-8 col-md-10 mx-auto\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Notes\Views\Home\PostNote.cshtml"
                   Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </article>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Notes.Models.Note> Html { get; private set; }
    }
}
#pragma warning restore 1591
