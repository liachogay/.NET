#pragma checksum "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b243dfbfbcb943510728650f006a69393f673aa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhoneVerification_Verification), @"mvc.1.0.view", @"/Views/PhoneVerification/Verification.cshtml")]
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
#line 1 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\_ViewImports.cshtml"
using TheAchEcom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\_ViewImports.cshtml"
using TheAchEcom.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml"
using TheAchEcom.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml"
using TheAchEcom.Models.Authy;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b243dfbfbcb943510728650f006a69393f673aa5", @"/Views/PhoneVerification/Verification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1f16a9ae5a71c965ddd53c26902e77b1a46f52d", @"/Views/_ViewImports.cshtml")]
    public class Views_PhoneVerification_Verification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/verification/verify"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex_col_center justify_content_center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;padding:6rem 25%;box-sizing:border-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml"
   TokenVerificationModel tokenModel = Model ?? new TokenVerificationModel(); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml"
   Dictionary<string, ModelStateError> errors = ViewBag.ModelErrors; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b243dfbfbcb943510728650f006a69393f673aa55534", async() => {
                WriteLiteral("\r\n\r\n   <h3 class=\"small_heading text_center\" style=\"font-weight: 500;font-size:3rem;margin: 2rem;\">\r\n      Nhập mã xác thực\r\n   </h3>\r\n\r\n");
#nullable restore
#line 12 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml"
    if (errors != null && errors.ContainsKey("Summary"))
   {

#line default
#line hidden
#nullable disable
                WriteLiteral("      <div class=\"text_center\" style=\"color:red;\"> ");
#nullable restore
#line 14 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml"
                                              Write(errors["Summary"].ErrorMessages);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n");
#nullable restore
#line 15 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml"
   }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n<div class=\"flex_center\">\r\n   <input class=\"primary_input\" type=\"text\" name=\"Token\"");
                BeginWriteAttribute("value", "\r\n          value=\"", 764, "\"", 800, 1);
#nullable restore
#line 19 "D:\VS\ecom-final-project-2020\TheAchEcom\Views\PhoneVerification\Verification.cshtml"
WriteAttributeValue("", 783, tokenModel.Token, 783, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n          placeholder=\"Mã xác thực là ... \"\r\n          style=\"margin: 2rem 2rem;\" />\r\n\r\n   <button class=\"small_btn\">\r\n      Xác thực\r\n   </button>\r\n</div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
