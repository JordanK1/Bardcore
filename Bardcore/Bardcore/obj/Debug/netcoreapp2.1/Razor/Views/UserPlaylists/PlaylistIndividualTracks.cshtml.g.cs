#pragma checksum "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "822df519550c8c8b9c2f2dc106b41da506c764ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserPlaylists_PlaylistIndividualTracks), @"mvc.1.0.view", @"/Views/UserPlaylists/PlaylistIndividualTracks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserPlaylists/PlaylistIndividualTracks.cshtml", typeof(AspNetCore.Views_UserPlaylists_PlaylistIndividualTracks))]
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
#line 1 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\_ViewImports.cshtml"
using Bardcore;

#line default
#line hidden
#line 2 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\_ViewImports.cshtml"
using Bardcore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"822df519550c8c8b9c2f2dc106b41da506c764ed", @"/Views/UserPlaylists/PlaylistIndividualTracks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613efd83176867dd6925d79fa4a9cb7cc79e1f78", @"/Views/_ViewImports.cshtml")]
    public class Views_UserPlaylists_PlaylistIndividualTracks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bardcore.ViewModels.PlaylistIndividualTracksVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("audio/mpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("audio/ogg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml"
  
    ViewData["Title"] = "PlaylistIndividualTracks";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(163, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(170, 31, false);
#line 7 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml"
Write(Model.userPlaylist.PlaylistName);

#line default
#line hidden
            EndContext();
            BeginContext(201, 15, true);
            WriteLiteral("</h2>\r\n\r\n<ol>\r\n");
            EndContext();
#line 10 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml"
     foreach (var track in Model.userPlaylistTracks)
    {

#line default
#line hidden
            BeginContext(277, 26, true);
            WriteLiteral("        <li>\r\n            ");
            EndContext();
            BeginContext(304, 35, false);
#line 13 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml"
       Write(Html.DisplayFor(t => track.TrackId));

#line default
#line hidden
            EndContext();
            BeginContext(339, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(341, 19, false);
#line 13 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml"
                                            Write(Model.songInfo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(360, 48, true);
            WriteLiteral("\r\n            <audio controls>\r\n                ");
            EndContext();
            BeginContext(408, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d14177550bc5418dbd7e8462b858dcf0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 421, "~/uploads/", 421, 10, true);
#line 15 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml"
AddHtmlAttributeValue("", 431, Model.songInfo.FileLocation, 431, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(481, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(499, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3289f86ab51d45279bb19c75d31470fd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 512, "~/uploads/", 512, 10, true);
#line 16 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml"
AddHtmlAttributeValue("", 522, Model.songInfo.FileLocation, 522, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(571, 39, true);
            WriteLiteral("\r\n            </audio>\r\n        </li>\r\n");
            EndContext();
#line 19 "C:\Users\Jordan\source\Bardcore\Bardcore\Bardcore\Views\UserPlaylists\PlaylistIndividualTracks.cshtml"
    }

#line default
#line hidden
            BeginContext(617, 5, true);
            WriteLiteral("</ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bardcore.ViewModels.PlaylistIndividualTracksVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
