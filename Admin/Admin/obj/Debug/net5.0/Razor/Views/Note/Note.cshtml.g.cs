#pragma checksum "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Admin\Views\Note\Note.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8659ea01ec510829bd306688037166b0d379426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Note), @"mvc.1.0.view", @"/Views/Note/Note.cshtml")]
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
#line 1 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8659ea01ec510829bd306688037166b0d379426", @"/Views/Note/Note.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Note : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8659ea01ec510829bd306688037166b0d3794263869", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <input type=""text"" class=""form-control"" id=""title"" placeholder=""Title"" />

    </div>
    <div class=""form-group"">
        <input type=""text"" class=""form-control"" id=""subtitle"" placeholder=""Subtitle"" />
    </div>
    <div id=""summernote"">

    </div>
    ");
#nullable restore
#line 15 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Admin\Views\Note\Note.cshtml"
Write(Html.DropDownList("Categories", null, "Select Category!", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 17 "C:\Users\uluca\OneDrive\Masaüstü\DEĞERLENDİRME 08.06\Admin\Admin\Views\Note\Note.cshtml"
Write(Html.DropDownList("Tags", null, "Select Tag!", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <button type=\"button\" onclick=\"save()\" class=\"btn btn-primary\">Save</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote.min.js""></script>
    <script>
  $(document).ready(function() {
  $('#summernote').summernote();
});

     function save() {
        var title = document.getElementById(""title"");
        var subtitle = document.getElementById(""subtitle"");
        var content = $('#summernote').summernote('code');
         var category = document.getElementById(""Categories"");
         var tag = document.getElementById(""Tags"");
        var form = document.getElementById(""form"");

       var formData = new FormData(form);

        formData.append(""title"", title.value);
        formData.append(""subtitle"", subtitle.value);
        formData.append(""content"", content);
         formData.append(""categoryid"", category.value);
         formData.append(""tagid"", tag.value);

        var url = '/Note/SaveNote';

        fetch(url, {
                method: 'POST',
                body: formData
            }).then(res => res.json()");
                WriteLiteral(")\r\n            .then(result => {\r\n                alert(\"Note Saved!\");\r\n            })\r\n    }\r\n\r\n    </script>\r\n\r\n");
            }
            );
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
