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
        public HomeForm()
        {
            InitializeComponent();
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
        }
    }
}
