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
            if(tabControl.SelectedTab == ManageTournaments)
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
            else if (tabControl.SelectedTab == GenerateSchedule)
            {
                cmbxTournaments.Items.Clear();
                List<Tournament> tournaments = tournamentManager.GetAllTournaments();
                foreach (Tournament tournament in tournaments)
                {
                    cmbxTournaments.Items.Add(tournament);
                }
            }
            else if(tabControl.SelectedTab == AddResults)
            {

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
            object selectedTournament = cmbxTournaments.SelectedItem;
            Tournament tournament = ((Tournament)selectedTournament);
            List<Game> games = gameManager.GenerateGames(tournament);
            foreach (Game game in games)
            {
                dataGridView1.Rows.Add(game.Player1Id, game.Player2Id);
            }
            
        }
    }
}
