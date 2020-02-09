#pragma checksum "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\SubmitFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cccb17a3442d8c9a39542fe6f0c60acb05d8a1a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SubmitFeedback), @"mvc.1.0.view", @"/Views/Admin/SubmitFeedback.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/SubmitFeedback.cshtml", typeof(AspNetCore.Views_Admin_SubmitFeedback))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cccb17a3442d8c9a39542fe6f0c60acb05d8a1a2", @"/Views/Admin/SubmitFeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SubmitFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuriousDriveWebClient.SubmitFeedbackViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("feedbackForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\SubmitFeedback.cshtml"
  
    ViewBag.Title = "Submit Feedback - Curious Drive";

#line default
#line hidden
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\SubmitFeedback.cshtml"
 using (Html.BeginForm("SubmitFeedback", "Admin", FormMethod.Post, new { @class = "form-horizontal row card", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(259, 23, false);
#line 9 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\SubmitFeedback.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(286, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(290, 2103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025df04d70c04bf4be1a0d0e9db55693", async() => {
                BeginContext(363, 1139, true);
                WriteLiteral(@"
        <div class=""form-group col-lg-12 col-12"">

            <div class=""col-lg-12 col-12"">

                <div class=""col-lg-12 col-12"">
                    <br />
                </div>

                <div class=""col-lg-12 col-12"">
                    <p class=""bold-largest"">Give Us Feedback</p>
                    <p>
                        We welcome your suggestions and ideas. Feedback from community members like you helps us as we constantly improve our
                        features and services. Though we can't respond to everyone who submits feedback, we review many of the ideas people send us to improve the Curious Drive experience
                        for everyone. We may use feedback or suggestions submitted by the community without any restriction or obligation to provide compensation for them or keep them
                        confidential.
                        <br />
                        <br />
                        If you're not looking to give feedback");
                WriteLiteral(" but you need help with a specific issue, you can find answers to common questions in the\r\n                        ");
                EndContext();
                BeginContext(1503, 53, false);
#line 30 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\SubmitFeedback.cshtml"
                   Write(Html.ActionLink("Help center", "HelpCenter", "Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(1556, 170, true);
                WriteLiteral("\r\n                    </p>\r\n                    <hr />\r\n                </div>\r\n\r\n                <div class=\"col-lg-12 col-lg-12 col-sm-12 col-12\">\r\n                    ");
                EndContext();
                BeginContext(1727, 66, false);
#line 36 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\SubmitFeedback.cshtml"
               Write(Html.TextAreaFor(m => m.feedback, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1793, 593, true);
                WriteLiteral(@"
                </div>
                <div class=""col-lg-12 col-lg-12 col-sm-12 col-12"">
                    <br />
                </div>
                <div class=""col-lg-12 col-lg-12 col-sm-12 col-12"">
                    <button id=""submitFeedback"" class=""btn btn-primary"" type=""submit"">Submit</button>
                </div>
                <div class=""col-lg-12 col-lg-12 col-sm-12 col-12"">
                    <br />
                </div>
            </div>

            <div class=""col-lg-12 col-12"">
                <br />
            </div>

        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2393, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\SubmitFeedback.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuriousDriveWebClient.SubmitFeedbackViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591