#pragma checksum "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/Select/SelectionResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "616b3cdda1b5b4a78c43ffdb6a8928481d1de4d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Select_SelectionResult), @"mvc.1.0.view", @"/Views/Select/SelectionResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Select/SelectionResult.cshtml", typeof(AspNetCore.Views_Select_SelectionResult))]
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
#line 1 "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/_ViewImports.cshtml"
using InstrumentSelector;

#line default
#line hidden
#line 2 "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/_ViewImports.cshtml"
using InstrumentSelector.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616b3cdda1b5b4a78c43ffdb6a8928481d1de4d3", @"/Views/Select/SelectionResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f276888c4dcfbc3712ed4724c261e09eb9ee7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Select_SelectionResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InstrumentSelector.Models.Instrument>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/Select/SelectionResult.cshtml"
   
    Layout = "_Layout_Select";
    ViewData["Title"] = "Selection Result";

#line default
#line hidden
            BeginContext(138, 27, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n    ");
            EndContext();
            BeginContext(165, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "616b3cdda1b5b4a78c43ffdb6a8928481d1de4d34584", async() => {
                BeginContext(171, 71, true);
                WriteLiteral("\n        <meta name=\"viewport\" content=\"width=device-width\" />\n        ");
                EndContext();
                BeginContext(242, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "616b3cdda1b5b4a78c43ffdb6a8928481d1de4d35034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(313, 5, true);
                WriteLiteral("\n    ");
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
            BeginContext(325, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(330, 407, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "616b3cdda1b5b4a78c43ffdb6a8928481d1de4d37132", async() => {
                BeginContext(336, 142, true);
                WriteLiteral("\n        <h1>Selection Results</h1>\n        <p>Below are your results. Navigate to the instrument pages for more information.</p>\n        <p>\n");
                EndContext();
#line 16 "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/Select/SelectionResult.cshtml"
             foreach (Instrument i in Model)
            {

#line default
#line hidden
                BeginContext(537, 32, true);
                WriteLiteral("                <h2>Instrument: ");
                EndContext();
                BeginContext(570, 17, false);
#line 18 "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/Select/SelectionResult.cshtml"
                           Write(i.DescriptionText);

#line default
#line hidden
                EndContext();
                BeginContext(587, 32, true);
                WriteLiteral("</h2>\n                <p>Range: ");
                EndContext();
                BeginContext(620, 18, false);
#line 19 "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/Select/SelectionResult.cshtml"
                     Write(i.RangeDescription);

#line default
#line hidden
                EndContext();
                BeginContext(638, 38, true);
                WriteLiteral("</p>\n                <p>Tone Quality: ");
                EndContext();
                BeginContext(677, 17, false);
#line 20 "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/Select/SelectionResult.cshtml"
                            Write(i.ToneDescription);

#line default
#line hidden
                EndContext();
                BeginContext(694, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 21 "/Users/amylese/Documents/ASP.NET/InstrumentSelector/InstrumentSelector/Views/Select/SelectionResult.cshtml"
            }

#line default
#line hidden
                BeginContext(713, 17, true);
                WriteLiteral("        </p>\n    ");
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
            BeginContext(737, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InstrumentSelector.Models.Instrument>> Html { get; private set; }
    }
}
#pragma warning restore 1591
