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
    public partial class EditTournament : Form
    {
        Tournament tournament;
        TournamentManager tournamentManager = new TournamentManager(new TournamentRepository());
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
                cmbxSportType.SelectedItem = tournament.SportType.ToString();
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
            string sportType = cmbxSportType.Text;
            string tournamentSystem = cmbxTournamentSystem.Text;
            string description = tbxDescription.Text;
            DateTime startDate = dateTimeStartDate.Value;
            DateTime endDate = dateTimeEndDate.Value;
            string location = tbxLocation.Text;
            int minimumPlayers = 0;
            int maximumPlayers = 0;
            try
            {
                minimumPlayers = Convert.ToInt32(txbMinPlayers.Text);
                maximumPlayers = Convert.ToInt32(txbMaxPlayers.Text);          
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input for field: Minimum Players, Maximum Players");
            }

            if (sportType != "Badminton")
            {
                MessageBox.Show("Sport Type field is incorrect");
            }
            else if (tournamentSystem != "Round-Robin" && tournamentSystem != "Double Round-Robin")
            {
                MessageBox.Show("Tournament System field is incorrect");
            }
            else if (description == string.Empty)
            {
                MessageBox.Show("Description field cannot be empty");
            }

            else if (startDate < DateTime.Today)
            {
                MessageBox.Show("Start Date cannot be past date");
            }
            else if (startDate.Day == DateTime.Today.Day && startDate.Month == DateTime.Today.Month)
            {
                MessageBox.Show("Start Date cannot be today");
            }
            else if (startDate == endDate)
            {
                MessageBox.Show("End date and Start Date cannot be the same");
            }
            else if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be before start date");
            }
            else if (minimumPlayers <= 1)
            {
                MessageBox.Show("Minimum Players cannot less than 1 or 1");
            }
            else if (maximumPlayers <= 1)
            {
                MessageBox.Show("Maximum Players cannot be less than 1 or 1");
            }
            else if (maximumPlayers < minimumPlayers)
            {
                MessageBox.Show("Maximum Players cannot be less that minimum players");
            }
            else if (location == string.Empty)
            {
                MessageBox.Show("Location field cannot be empty");
            }
            else
            {
                try
                {
                    if (btnEditCreate.Text == "Edit")
                    {
                        tournamentManager.UpdateTournament(tournament.Id, sportType, tournamentSystem, description, startDate, endDate, minimumPlayers, maximumPlayers, location);
                        MessageBox.Show("Tournament is updated successfully");
                        this.Close();
                    }
                    else
                    {

                        tournamentManager.CreateTournament(sportType, tournamentSystem, description, startDate, endDate, minimumPlayers, maximumPlayers, location);
                        MessageBox.Show("Tournament is created successfully");
                        this.Close();
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
        }
    }
}
