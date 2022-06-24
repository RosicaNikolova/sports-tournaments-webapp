#pragma checksum "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010e07ef548f279923172eebd65f767a9bb4284b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TournamentsWebApp.Pages.Pages_Home), @"mvc.1.0.razor-page", @"/Pages/Home.cshtml")]
namespace TournamentsWebApp.Pages
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
#line 1 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\_ViewImports.cshtml"
using TournamentsWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"010e07ef548f279923172eebd65f767a9bb4284b", @"/Pages/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3851ab4f0456207173c20f2ef9b8ea01c87362c5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Tournament", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
  
    if (User.Identity.IsAuthenticated)
    {
        Layout = "_Layout1";
    }
    else
    {
        Layout = "_Layout";
    }

    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"list-container\">\r\n    <ul>\r\n");
#nullable restore
#line 20 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
           if (Model.tournaments.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3>No tournaments</h3>\r\n");
#nullable restore
#line 23 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
            }
            else
            {
                foreach (var tournament in Model.tournaments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010e07ef548f279923172eebd65f767a9bb4284b4450", async() => {
                WriteLiteral(@"
                            <div class=""item-container"">

                                <img src=""pic/download.jpg"" alt=""tournamentPicture"">
                                <div class=""item-content"">
                                    <h4> Sport: ");
#nullable restore
#line 34 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
                                           Write(tournament.SportType.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                    <p>Tournament System: ");
#nullable restore
#line 35 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
                                                     Write(tournament.TournamentSystem.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>Start Date: ");
#nullable restore
#line 36 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
                                              Write(tournament.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>End Date: ");
#nullable restore
#line 37 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
                                            Write(tournament.EndDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>Location: ");
#nullable restore
#line 38 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
                                            Write(tournament.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n");
                WriteLiteral("\r\n                                    <div");
                BeginWriteAttribute("class", " class=\"", 1436, "\"", 1473, 1);
#nullable restore
#line 42 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
WriteAttributeValue("", 1444, tournament.Status.ToString(), 1444, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <p>Status: \r\n                                           \r\n                                                ");
#nullable restore
#line 45 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
                                           Write(tournament.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                           \r\n                                        </p>\r\n                                    </div>\r\n\r\n                                </div>\r\n\r\n\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"
                                                    WriteLiteral(tournament.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </li>\r\n");
#nullable restore
#line 57 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\Home.cshtml"


                }

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TournamentsWebApp.Pages.HomeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TournamentsWebApp.Pages.HomeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TournamentsWebApp.Pages.HomeModel>)PageContext?.ViewData;
        public TournamentsWebApp.Pages.HomeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591