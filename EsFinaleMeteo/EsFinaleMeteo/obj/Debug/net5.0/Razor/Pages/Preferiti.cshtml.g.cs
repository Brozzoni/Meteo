#pragma checksum "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1402baccee49ddc7a20d221a6ba7534ff4fc077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EsFinaleMeteo.Pages.Pages_Preferiti), @"mvc.1.0.razor-page", @"/Pages/Preferiti.cshtml")]
namespace EsFinaleMeteo.Pages
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
#line 1 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\_ViewImports.cshtml"
using EsFinaleMeteo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\_ViewImports.cshtml"
using EsFinaleMeteo.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1402baccee49ddc7a20d221a6ba7534ff4fc077", @"/Pages/Preferiti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df348b44dd128ad64f9ec0d2fd8e5351b03ea91", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Preferiti : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml"
  
    ViewData["Title"] = "Preferiti";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    body, html {\r\n        height: 100%;\r\n        background-image: url(\"../images/sole.jpg\");\r\n        background-position: center;\r\n        background-repeat: no-repeat;\r\n        background-size: cover;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1402baccee49ddc7a20d221a6ba7534ff4fc0774273", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <br />\r\n        <br />\r\n        <h1 class=\"text-white\" align=\"center\" style=\"font-size: 50px\"><i>Preferiti di ");
#nullable restore
#line 20 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml"
                                                                                 Write(Model.User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</i></h1>
        <br />
        <br />
    </div>
    <table class=""table text-black"" align=""center"">
        <thead>
            <tr style=""font-size: 20px"">
                <th>Città</th>
                <th>Stato</th>
                <th>Longitudine</th>
                <th>Latitudine</th>
                <th>Cerca Ora</th>
                <th>Rimuovi</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 36 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml"
             foreach (var item in Model.eleCittaUte)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml"
                   Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml"
                   Write(item.state);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml"
                   Write(item.lon);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml"
                   Write(item.lat);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\brozzoni.17118\Documents\GitHub\Meteo\EsFinaleMeteo\EsFinaleMeteo\Pages\Preferiti.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsFinaleMeteo.Pages.PreferitiModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsFinaleMeteo.Pages.PreferitiModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsFinaleMeteo.Pages.PreferitiModel>)PageContext?.ViewData;
        public EsFinaleMeteo.Pages.PreferitiModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
