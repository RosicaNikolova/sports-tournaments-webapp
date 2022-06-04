using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class HomeForm : Form
    {
        TournamentManager tournamentManager = new TournamentManager(new TournamentRepository());
        GameManager gameManager = new GameManager(new GameRepository());
        User user;
        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(User user)
        {
            InitializeComponent();
            this.user = user;
            lblWelcome.Text = $"Hello, {user.FirstName} {user.LastName}";
            tournamentManager.CheckStatusesOfTournaments();
            UpdateTournamentOverview();
        }


        private void btnManageTournaments_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = ManageTournaments;
        }

        private void btnGenerateGames_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = GenerateSchedule;
        }

        private void btnAddResults_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = AddResults;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Home;
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Home;
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Home;
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            EditTournament editTournament = new EditTournament();
            editTournament.Show();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == ManageTournaments)
            {
                lbxTournaments.Items.Clear();
                try
                {
                    //open tournaments for CRUID 
                    List<Tournament> tournaments = tournamentManager.GetAllOpenTournaments();
                    foreach (Tournament tournament in tournaments)
                    {
                        lbxTournaments.Items.Add(tournament);
                    }
                }
                catch (DataBaseException)
                {
                    MessageBox.Show("There is a problem with our databse at the moment. Please, try again later");
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while processing you request.Please, try again later");
                }
            }
            else if (tabControl.SelectedTab == GenerateSchedule)
            {
                try
                {
                    //pending tournaments for generating schedule
                    cmbxTournaments.Items.Clear();
                    List<Tournament> tournaments = tournamentManager.GetAllPendingTournaments();

                    foreach (Tournament tournament in tournaments)
                    {
                        cmbxTournaments.Items.Add(tournament);
                    }
                }
                catch (DataBaseException)
                {
                    MessageBox.Show("There is a problem with our databse at the moment. Please, try again later");
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while processing you request.Please, try again later");
                }
            }
            else if (tabControl.SelectedTab == AddResults)
            {

                UpdateTournamentsListResultsTab();
            }
            else if (tabControl.SelectedTab == Home)
            {
                UpdateTournamentOverview();
            }
        }

        private void UpdateTournamentOverview()
        {
            dataGridViewOverview.Rows.Clear();
            List<Tournament> tournaments = tournamentManager.GetAllTournaments();
            foreach (Tournament tournament in tournaments)
            {
                dataGridViewOverview.Rows.Add(tournament.Id, tournament.SportType, tournament.TournamentSystem, tournament.Status, tournament.StartDate, tournament.EndDate, tournament.RegistrationCloses, tournament.MinPlayers, tournament.MaxPlayers, tournament.Description, tournament.Location); 
            }
        }

        private void UpdateTournamentsListResultsTab()
        {
            try
            {
                //ongoing tournaments for adding results
                cmbxTournamentsResults.Items.Clear();
                List<Tournament> tournaments = tournamentManager.GetAllOngoingTournaments();

                foreach (Tournament tournament in tournaments)
                {
                    cmbxTournamentsResults.Items.Add(tournament);
                }
            }
            catch (DataBaseException)
            {
                MessageBox.Show("There is a problem with our databse at the moment. Please, try again later");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while processing you request.Please, try again later");
            }

        }


        private void btnEditTournament_Click(object sender, EventArgs e)
        {
            object selectedTournament = lbxTournaments.SelectedItem;
            Tournament tournament = ((Tournament)selectedTournament);
            EditTournament editTournament = new EditTournament(tournament);
            editTournament.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbxTournaments.Items.Clear();
            try
            {
                List<Tournament> tournaments = tournamentManager.GetAllTournaments();
                foreach (Tournament tournament in tournaments)
                {
                    lbxTournaments.Items.Add(tournament);
                }
            }
            catch (DataBaseException)
            {
                MessageBox.Show("There is a problem with our databse at the moment. Please, try again later");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while processing you request.Please, try again later");
            }
        }

        private void btnDeleteTournament_Click(object sender, EventArgs e)
        {
            object selectedTournament = lbxTournaments.SelectedItem;
            Tournament tournament = ((Tournament)selectedTournament);
            tournamentManager.DeleteTournament(tournament.Id);
            MessageBox.Show("Tournament is deleted successfully");
        }


        private void btnGenerateMatches_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            object selectedTournament = cmbxTournaments.SelectedItem;
            Tournament tournament = ((Tournament)selectedTournament);
            List<Game> games = gameManager.GenerateGames(tournament);
            foreach (Game game in games)
            {
                dataGridView1.Rows.Add(game.Player1Id, game.Player2Id);
            }
            tournamentManager.SetStatusToOngoing(tournament.Id);
        }

        private void cmbxTournamentsResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            object selectedTournament = cmbxTournamentsResults.SelectedItem;
            Tournament tournament = ((Tournament)selectedTournament);

            List<Game> games = gameManager.GetGamesForTournament(tournament.Id);
            foreach (Game game in games)
            {
                dataGridView2.Rows.Add(game.GameId, game.Player1Id, game.Player2Id, game.Result1, game.Result2);
            }
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            List<Game> games = new List<Game>();
            object selectedTournament = cmbxTournamentsResults.SelectedItem;
            Tournament tournament = ((Tournament)selectedTournament);
            for (int rows = 0; rows < dataGridView2.Rows.Count; rows++)
            {
                int resultPlayer1 = Convert.ToInt32(dataGridView2.Rows[rows].Cells[3].Value.ToString());
                int resultPlayer2 = Convert.ToInt32(dataGridView2.Rows[rows].Cells[4].Value.ToString());

                //if (resultPlayer1 != 0 && resultPlayer2 != 0)
                //{
                    int gameId = Convert.ToInt32(dataGridView2.Rows[rows].Cells[0].Value.ToString());
                    int player1Id = Convert.ToInt32(dataGridView2.Rows[rows].Cells[1].Value.ToString());
                    int player2Id = Convert.ToInt32(dataGridView2.Rows[rows].Cells[2].Value.ToString());
                    Game game = new Game();
                    game.SportType = tournament.SportType;
                    game.GameId = gameId;
                    game.Result1 = resultPlayer1;
                    game.Result2 = resultPlayer2;
                    game.Player1Id = player1Id;
                    game.Player2Id = player2Id;
                    //2 fields - Sport Type in tournaments and game  
                    //if (game.CheckResults());
                    if (game.SportType.CheckResults(game))
                    {
                        games.Add(game);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid results for game with Id - {game.GameId} {game.SportType.GetErrorMessage()}");
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Points cannot be zero");
                //}
            }
            gameManager.SaveResults(games);
            if (gameManager.CheckIfAllResultsAreEntered(tournament.Id))
            {
                tournamentManager.SetStatusToFinished(tournament.Id);
                MessageBox.Show("All results entered successfully");
                UpdateTournamentsListResultsTab();
            }
        }
    }
}
