#pragma checksum "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ASPNET/ASP1/dojoSurvey/dojoSurvey/Views/Home/Submitted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7cb4b79282e8c9d9d614810f9169cf0cf353a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Submitted), @"mvc.1.0.view", @"/Views/Home/Submitted.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Submitted.cshtml", typeof(AspNetCore.Views_Home_Submitted))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7cb4b79282e8c9d9d614810f9169cf0cf353a0d", @"/Views/Home/Submitted.cshtml")]
    public class Views_Home_Submitted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            EndContext();
            BeginContext(34, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7cb4b79282e8c9d9d614810f9169cf0cf353a0d2904", async() => {
                BeginContext(40, 202, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Dojo Survey Submitted</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(249, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(251, 251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7cb4b79282e8c9d9d614810f9169cf0cf353a0d4279", async() => {
                BeginContext(257, 71, true);
                WriteLiteral("\n    <h1>Show Page</h1>\n    <h3>Info Submitted:</h3>\n    <p>Full Name: ");
                EndContext();
                BeginContext(329, 12, false);
#line 14 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ASPNET/ASP1/dojoSurvey/dojoSurvey/Views/Home/Submitted.cshtml"
             Write(ViewBag.name);

#line default
#line hidden
                EndContext();
                BeginContext(341, 27, true);
                WriteLiteral("</p>\n    <p>Dojo Location: ");
                EndContext();
                BeginContext(369, 21, false);
#line 15 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ASPNET/ASP1/dojoSurvey/dojoSurvey/Views/Home/Submitted.cshtml"
                 Write(ViewBag.dojo_location);

#line default
#line hidden
                EndContext();
                BeginContext(390, 32, true);
                WriteLiteral("</<p>\n    <p>Favorite Language: ");
                EndContext();
                BeginContext(423, 26, false);
#line 16 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ASPNET/ASP1/dojoSurvey/dojoSurvey/Views/Home/Submitted.cshtml"
                     Write(ViewBag.favorite_languages);

#line default
#line hidden
                EndContext();
                BeginContext(449, 22, true);
                WriteLiteral("</p>\n    <p>Comments: ");
                EndContext();
                BeginContext(472, 16, false);
#line 17 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ASPNET/ASP1/dojoSurvey/dojoSurvey/Views/Home/Submitted.cshtml"
            Write(ViewBag.comments);

#line default
#line hidden
                EndContext();
                BeginContext(488, 7, true);
                WriteLiteral(" </p>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(502, 9, true);
            WriteLiteral("\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
