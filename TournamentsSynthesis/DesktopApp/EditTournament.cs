using ClassLibraryTournaments.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class EditTournament : Form
    {
        Tournament tournament;
        public EditTournament()
        {
            InitializeComponent();
            btnEditCreate.Text = "Create";
        }

        public EditTournament(Tournament tournament)
        {
            InitializeComponent();
            this.tournament = tournament;
            btnEditCreate.Text = "Edit";
            DisplayTournamentInfo();
        }


        private void DisplayTournamentInfo()
        {
            try
            {
                cmbxSportType.SelectedItem = tournament.SportType;
                cmbxTournamentSystem.SelectedItem = tournament.TournamentSystem.ToString();
                tbxDescription.Text = tournament.Description;
                dateTimeStartDate.Value = tournament.StartDate;
                dateTimeEndDate.Value = tournament.EndDate;
                txbMinPlayers.Text = tournament.MinPlayers.ToString();
                txbMaxPlayers.Text = tournament.MaxPlayers.ToString();
                tbxLocation.Text = tournament.Location;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while processing you request.Please, try again later");
            }
        }

        private void btnEditCreate_Click(object sender, EventArgs e)
        {
            if(btnEditCreate.Text == "Edit")
            {

            }
            else
            {

            }
        }
    }
}
