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
        TournamentsStatusManager statusManager = new TournamentsStatusManager(new TournamentStatusRepository());
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
            List<Tournament> tournaments = tournamentManager.GetAllTournamentsWithStatus(Status.open);
            statusManager.CheckStatusesOfTournaments(tournaments);
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

        private void DisplayOpenTournaments()
        {
            lbxTournaments.Items.Clear();
            try
            {
                List<Tournament> tournaments = tournamentManager.GetAllOpenOrCancelledTournaments();
                if (tournaments.Count != 0)
                {
                    foreach (Tournament tournament in tournaments)
                    {
                        lbxTournaments.Items.Add(tournament);
                    }
                }
                else
                {
                    lbxTournaments.Items.Add("No open or cancelled tournaments at the moment");
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == ManageTournaments)
            {
                DisplayOpenTournaments();
            }
            else if (tabControl.SelectedTab == GenerateSchedule)
            {
                try
                {
                    //pending tournaments for generating schedule
                    cmbxTournaments.Items.Clear();
                    List<Tournament> tournaments = tournamentManager.GetAllTournamentsWithStatus(Status.pending);
                    if (tournaments.Count != 0)
                    {
                        foreach (Tournament tournament in tournaments)
                        {
                            cmbxTournaments.Items.Add(tournament);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tournamnets for generating schedule at the moment");
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
            try
            {
                dataGridViewOverview.Rows.Clear();
                List<Tournament> tournaments = tournamentManager.GetAllTournaments();
                foreach (Tournament tournament in tournaments)
                {
                    dataGridViewOverview.Rows.Add(tournament.Id, tournament.SportType, tournament.TournamentSystem, tournament.Status, tournament.StartDate, tournament.EndDate, tournament.RegistrationCloses, tournament.MinPlayers, tournament.MaxPlayers, tournament.Description, tournament.Location);
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

        private void UpdateTournamentsListResultsTab()
        {
            try
            {
                //ongoing tournaments for adding results
                dataGridView2.Rows.Clear();
                cmbxTournamentsResults.Items.Clear();
                List<Tournament> tournaments = tournamentManager.GetAllTournamentsWithStatus(Status.ongoing);
                if (tournaments.Count != 0)
                {
                    foreach (Tournament tournament in tournaments)
                    {
                        cmbxTournamentsResults.Items.Add(tournament);
                    }
                }
                else
                {
                    MessageBox.Show("No tournaments for adding results at the moment");
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
            if (lbxTournaments.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select a tournament to be eddited");
            }
            else
            {
                object selectedTournament = lbxTournaments.SelectedItem;
                Tournament tournament = ((Tournament)selectedTournament);
                EditTournament editTournament = new EditTournament(tournament);
                editTournament.Show();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayOpenTournaments();
        }

        private void btnDeleteTournament_Click(object sender, EventArgs e)
        {
            if (lbxTournaments.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select a tournament to be deleted");
            }
            else
            {
                object selectedTournament = lbxTournaments.SelectedItem;
                Tournament tournament = ((Tournament)selectedTournament);
                tournamentManager.DeleteTournament(tournament.Id);
                MessageBox.Show("Tournament is deleted successfully");
                DisplayOpenTournaments();
            }
        }


        private void btnGenerateMatches_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(cmbxTournaments.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select a tournament to generate matches for");
            }
            else
            {
                try
                {
                    object selectedTournament = cmbxTournaments.SelectedItem;
                    Tournament tournament = ((Tournament)selectedTournament);
                    List<Game> games = gameManager.GenerateGames(tournament);
                    foreach (Game game in games)
                    {
                        dataGridView1.Rows.Add(game.Player1Id, game.Player2Id);
                    }
                    statusManager.ChangeTournamentStatus(tournament.Id, Status.ongoing);
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
           
        }

        private void cmbxTournamentsResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (DataBaseException)
            {
                MessageBox.Show("There is a problem with our databse at the moment. Please, try again later");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while processing you request.Please, try again later");
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
                statusManager.ChangeTournamentStatus(tournament.Id, Status.finished);
                MessageBox.Show("All results entered successfully");
                UpdateTournamentsListResultsTab();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
