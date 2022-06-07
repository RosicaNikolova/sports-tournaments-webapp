#pragma checksum "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a61081ffad25d807b1eba3d0e09e572e5d629cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TournamentsWebApp.Pages.Pages_MyProfile), @"mvc.1.0.razor-page", @"/Pages/MyProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61081ffad25d807b1eba3d0e09e572e5d629cbe", @"/Pages/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3851ab4f0456207173c20f2ef9b8ea01c87362c5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
  
    Layout = "_Layout1";
    ViewData["Title"] = "MyProfile";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-content-info\">\r\n    <section class=\"container-personal-info\">\r\n\r\n        <h2>Personal Information</h2>\r\n        <p>Email: ");
#nullable restore
#line 13 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
             Write(Model.user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>First Name: ");
#nullable restore
#line 14 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                  Write(Model.user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Last Name: ");
#nullable restore
#line 15 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                 Write(Model.user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </section>\r\n\r\n    <section class=\"container-participations\">\r\n        <h2> Participations: ");
#nullable restore
#line 19 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                        Write(Model.tournaments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 21 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
          
            if (Model.tournaments.Count != 0)
            {
                foreach (var tournament in Model.tournaments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""flex-continer-player-tournament"">
                        <div class=""container-player-tournament"">
                            <div class=""container-tourn-info"">
                                <h3>Tournament Information</h3>
                                <p>Sport: ");
#nullable restore
#line 30 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                     Write(tournament.SportType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>System: ");
#nullable restore
#line 31 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                      Write(tournament.TournamentSystem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Location: ");
#nullable restore
#line 32 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                        Write(tournament.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Start Date: ");
#nullable restore
#line 33 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                          Write(tournament.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Stauts: ");
#nullable restore
#line 34 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                      Write(tournament.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"container-player-games\">\r\n                                <h3>Your Games</h3>\r\n");
#nullable restore
#line 39 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                 if (Model.games.Count != 0 && Model.games.ContainsKey(tournament.Id))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""flex-container-table"">
                                        <table>
                                            <tr>
                                                <th>Game</th>
                                                <th>Result</th>
                                            </tr>
");
#nullable restore
#line 47 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                              
                                                foreach (var game in Model.games[tournament.Id])
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 51 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                                       Write(Model.names[game.Player1Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 51 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                                                                      Write(Model.names[game.Player2Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 52 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                                       Write(game.Result1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 52 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                                                       Write(game.Result2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 54 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </table>\r\n                                    </div>\r\n");
#nullable restore
#line 58 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h3>No games yet.</h3>\r\n");
#nullable restore
#line 62 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"container-player-rank\">\r\n                                <h3>Your ranking: </h3>\r\n");
#nullable restore
#line 68 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                  if (Model.ranking.Count != 0 && Model.ranking.ContainsKey(tournament.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h3>Rank: ");
#nullable restore
#line 70 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                             Write(Model.ranking[tournament.Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 71 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h3>No ranking present yet.</h3>\r\n");
#nullable restore
#line 75 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n\r\n\r\n                       \r\n\r\n                    </div>\r\n");
#nullable restore
#line 84 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3>No participations yet.</h3>\r\n");
#nullable restore
#line 89 "D:\OneDrive\Работен плот\Synthesis\Repo\tournaments_synthesis\TournamentsSynthesis\TournamentsWebApp\Pages\MyProfile.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </section>\r\n\r\n    <div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TournamentsWebApp.Pages.MyProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TournamentsWebApp.Pages.MyProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TournamentsWebApp.Pages.MyProfileModel>)PageContext?.ViewData;
        public TournamentsWebApp.Pages.MyProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
