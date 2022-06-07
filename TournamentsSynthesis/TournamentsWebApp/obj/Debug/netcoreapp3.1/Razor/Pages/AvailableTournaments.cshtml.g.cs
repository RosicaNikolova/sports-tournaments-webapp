#pragma checksum "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ddca27eb2fee5a51404be3b01cd18944bf5bba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TournamentsWebApp.Pages.Pages_AvailableTournaments), @"mvc.1.0.razor-page", @"/Pages/AvailableTournaments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ddca27eb2fee5a51404be3b01cd18944bf5bba7", @"/Pages/AvailableTournaments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3851ab4f0456207173c20f2ef9b8ea01c87362c5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AvailableTournaments : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/SignUpForTournament", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
  
    if (User.Identity.IsAuthenticated)
    {
        Layout = "_Layout1";
    }
    else
    {
        Layout = "_Layout";
    }
    ViewData["Title"] = "Available Tournaments";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-content-grid\">\r\n    <div class=\"grid-container\">\r\n");
#nullable restore
#line 19 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
           if (Model.tournaments == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3>No available tournaments at the moment.</h3>\r\n");
#nullable restore
#line 22 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
            }
            else
            {
                foreach (var tournament in Model.tournaments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""grid-item"">
                        <div class=""flex-container-grid-content"">
                            <div class=""container-left"">
                                <div class=""picture-container"">
                                    <img src=""pic/download.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 889, "\"", 895, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"container-left-text\">\r\n                                    <p>Location: ");
#nullable restore
#line 34 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                            Write(tournament.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>Description: ");
#nullable restore
#line 35 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                               Write(tournament.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>

                            </div>

                            <div class=""container-right"">
                                <h4>Tournament Infromation:</h4>
                                <p>Sport Type: ");
#nullable restore
#line 42 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                          Write(tournament.SportType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Tournament system:  ");
#nullable restore
#line 43 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                                  Write(tournament.TournamentSystem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Start Date: ");
#nullable restore
#line 44 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                          Write(tournament.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>End Date: ");
#nullable restore
#line 45 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                        Write(tournament.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Minumum Players: ");
#nullable restore
#line 46 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                               Write(tournament.MinPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Maximum Players: ");
#nullable restore
#line 47 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                               Write(tournament.MaxPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Available Places: ");
#nullable restore
#line 48 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                                                Write(Model.availablePlaces[tournament.Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"register-container\">\r\n                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ddca27eb2fee5a51404be3b01cd18944bf5bba78982", async() => {
                WriteLiteral("Register");
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
#line 52 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
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
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 56 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\AvailableTournaments.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TournamentsWebApp.Pages.AvailableTournamentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TournamentsWebApp.Pages.AvailableTournamentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TournamentsWebApp.Pages.AvailableTournamentsModel>)PageContext?.ViewData;
        public TournamentsWebApp.Pages.AvailableTournamentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591