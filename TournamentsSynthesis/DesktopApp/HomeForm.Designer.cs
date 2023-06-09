﻿
namespace DesktopApp
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnManageTournaments = new System.Windows.Forms.Button();
            this.btnGenerateGames = new System.Windows.Forms.Button();
            this.btnAddResults = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataGridViewOverview = new System.Windows.Forms.DataGridView();
            this.TournamentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentSystemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterClosedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPlayersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPlayersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ManageTournaments = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnEditTournament = new System.Windows.Forms.Button();
            this.btnDeleteTournament = new System.Windows.Forms.Button();
            this.lbxTournaments = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.GenerateSchedule = new System.Windows.Forms.TabPage();
            this.btnGenerateMatches = new System.Windows.Forms.Button();
            this.cmbxTournaments = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Player1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.AddResults = new System.Windows.Forms.TabPage();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player1Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result1Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result2Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbxTournamentsResults = new System.Windows.Forms.ComboBox();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).BeginInit();
            this.ManageTournaments.SuspendLayout();
            this.GenerateSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AddResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageTournaments
            // 
            this.btnManageTournaments.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageTournaments.ForeColor = System.Drawing.Color.Black;
            this.btnManageTournaments.Location = new System.Drawing.Point(259, 50);
            this.btnManageTournaments.Name = "btnManageTournaments";
            this.btnManageTournaments.Size = new System.Drawing.Size(129, 68);
            this.btnManageTournaments.TabIndex = 0;
            this.btnManageTournaments.Text = "Manage Tournaments";
            this.btnManageTournaments.UseVisualStyleBackColor = true;
            this.btnManageTournaments.Click += new System.EventHandler(this.btnManageTournaments_Click);
            // 
            // btnGenerateGames
            // 
            this.btnGenerateGames.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerateGames.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateGames.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerateGames.Location = new System.Drawing.Point(444, 50);
            this.btnGenerateGames.Name = "btnGenerateGames";
            this.btnGenerateGames.Size = new System.Drawing.Size(151, 68);
            this.btnGenerateGames.TabIndex = 1;
            this.btnGenerateGames.Text = "Generate Games";
            this.btnGenerateGames.UseVisualStyleBackColor = true;
            this.btnGenerateGames.Click += new System.EventHandler(this.btnGenerateGames_Click);
            // 
            // btnAddResults
            // 
            this.btnAddResults.BackColor = System.Drawing.Color.Transparent;
            this.btnAddResults.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddResults.ForeColor = System.Drawing.Color.Black;
            this.btnAddResults.Location = new System.Drawing.Point(643, 46);
            this.btnAddResults.Name = "btnAddResults";
            this.btnAddResults.Size = new System.Drawing.Size(127, 68);
            this.btnAddResults.TabIndex = 2;
            this.btnAddResults.Text = "Add Results";
            this.btnAddResults.UseVisualStyleBackColor = false;
            this.btnAddResults.Click += new System.EventHandler(this.btnAddResults_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Home);
            this.tabControl.Controls.Add(this.ManageTournaments);
            this.tabControl.Controls.Add(this.GenerateSchedule);
            this.tabControl.Controls.Add(this.AddResults);
            this.tabControl.Location = new System.Drawing.Point(-5, -30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1447, 697);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Home
            // 
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.Controls.Add(this.btnLogout);
            this.Home.Controls.Add(this.dataGridViewOverview);
            this.Home.Controls.Add(this.lblWelcome);
            this.Home.Controls.Add(this.btnGenerateGames);
            this.Home.Controls.Add(this.btnAddResults);
            this.Home.Controls.Add(this.btnManageTournaments);
            this.Home.Location = new System.Drawing.Point(4, 29);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1439, 664);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogout.Location = new System.Drawing.Point(1122, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataGridViewOverview
            // 
            this.dataGridViewOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TournamentIdColumn,
            this.SportTypeColumn,
            this.TournamentSystemColumn,
            this.StatusColumn,
            this.StartDateColumn,
            this.EndDateColumn,
            this.RegisterClosedDateColumn,
            this.MinPlayersColumn,
            this.MaxPlayersColumn,
            this.DescriptionColumn,
            this.LocationColumn});
            this.dataGridViewOverview.Location = new System.Drawing.Point(6, 165);
            this.dataGridViewOverview.Name = "dataGridViewOverview";
            this.dataGridViewOverview.RowHeadersWidth = 51;
            this.dataGridViewOverview.RowTemplate.Height = 29;
            this.dataGridViewOverview.Size = new System.Drawing.Size(1433, 392);
            this.dataGridViewOverview.TabIndex = 4;
            // 
            // TournamentIdColumn
            // 
            this.TournamentIdColumn.HeaderText = "Tournament Id";
            this.TournamentIdColumn.MinimumWidth = 6;
            this.TournamentIdColumn.Name = "TournamentIdColumn";
            this.TournamentIdColumn.ReadOnly = true;
            this.TournamentIdColumn.Width = 125;
            // 
            // SportTypeColumn
            // 
            this.SportTypeColumn.HeaderText = "Sport Type";
            this.SportTypeColumn.MinimumWidth = 6;
            this.SportTypeColumn.Name = "SportTypeColumn";
            this.SportTypeColumn.ReadOnly = true;
            this.SportTypeColumn.Width = 125;
            // 
            // TournamentSystemColumn
            // 
            this.TournamentSystemColumn.HeaderText = "Tournament System";
            this.TournamentSystemColumn.MinimumWidth = 6;
            this.TournamentSystemColumn.Name = "TournamentSystemColumn";
            this.TournamentSystemColumn.ReadOnly = true;
            this.TournamentSystemColumn.Width = 125;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 125;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.HeaderText = "Start Date";
            this.StartDateColumn.MinimumWidth = 6;
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.ReadOnly = true;
            this.StartDateColumn.Width = 125;
            // 
            // EndDateColumn
            // 
            this.EndDateColumn.HeaderText = "End Date";
            this.EndDateColumn.MinimumWidth = 6;
            this.EndDateColumn.Name = "EndDateColumn";
            this.EndDateColumn.ReadOnly = true;
            this.EndDateColumn.Width = 125;
            // 
            // RegisterClosedDateColumn
            // 
            this.RegisterClosedDateColumn.HeaderText = "Register Closed Date";
            this.RegisterClosedDateColumn.MinimumWidth = 6;
            this.RegisterClosedDateColumn.Name = "RegisterClosedDateColumn";
            this.RegisterClosedDateColumn.ReadOnly = true;
            this.RegisterClosedDateColumn.Width = 125;
            // 
            // MinPlayersColumn
            // 
            this.MinPlayersColumn.HeaderText = "Minimum Players";
            this.MinPlayersColumn.MinimumWidth = 6;
            this.MinPlayersColumn.Name = "MinPlayersColumn";
            this.MinPlayersColumn.ReadOnly = true;
            this.MinPlayersColumn.Width = 125;
            // 
            // MaxPlayersColumn
            // 
            this.MaxPlayersColumn.HeaderText = "Maximum Players";
            this.MaxPlayersColumn.MinimumWidth = 6;
            this.MaxPlayersColumn.Name = "MaxPlayersColumn";
            this.MaxPlayersColumn.ReadOnly = true;
            this.MaxPlayersColumn.Width = 125;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.MinimumWidth = 6;
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            this.DescriptionColumn.Width = 125;
            // 
            // LocationColumn
            // 
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.MinimumWidth = 6;
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            this.LocationColumn.Width = 125;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(306, 299);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 20);
            this.lblWelcome.TabIndex = 3;
            // 
            // ManageTournaments
            // 
            this.ManageTournaments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManageTournaments.BackgroundImage")));
            this.ManageTournaments.Controls.Add(this.btnRefresh);
            this.ManageTournaments.Controls.Add(this.btnCreateTournament);
            this.ManageTournaments.Controls.Add(this.btnEditTournament);
            this.ManageTournaments.Controls.Add(this.btnDeleteTournament);
            this.ManageTournaments.Controls.Add(this.lbxTournaments);
            this.ManageTournaments.Controls.Add(this.btnHome);
            this.ManageTournaments.Location = new System.Drawing.Point(4, 29);
            this.ManageTournaments.Name = "ManageTournaments";
            this.ManageTournaments.Padding = new System.Windows.Forms.Padding(3);
            this.ManageTournaments.Size = new System.Drawing.Size(1439, 622);
            this.ManageTournaments.TabIndex = 0;
            this.ManageTournaments.Text = "ManageTournaments";
            this.ManageTournaments.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(750, 116);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 58);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTournament.Location = new System.Drawing.Point(84, 159);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(105, 58);
            this.btnCreateTournament.TabIndex = 4;
            this.btnCreateTournament.Text = "Create";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // btnEditTournament
            // 
            this.btnEditTournament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTournament.Location = new System.Drawing.Point(84, 252);
            this.btnEditTournament.Name = "btnEditTournament";
            this.btnEditTournament.Size = new System.Drawing.Size(105, 53);
            this.btnEditTournament.TabIndex = 3;
            this.btnEditTournament.Text = "Edit";
            this.btnEditTournament.UseVisualStyleBackColor = true;
            this.btnEditTournament.Click += new System.EventHandler(this.btnEditTournament_Click);
            // 
            // btnDeleteTournament
            // 
            this.btnDeleteTournament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTournament.Location = new System.Drawing.Point(84, 341);
            this.btnDeleteTournament.Name = "btnDeleteTournament";
            this.btnDeleteTournament.Size = new System.Drawing.Size(105, 55);
            this.btnDeleteTournament.TabIndex = 2;
            this.btnDeleteTournament.Text = "Delete";
            this.btnDeleteTournament.UseVisualStyleBackColor = true;
            this.btnDeleteTournament.Click += new System.EventHandler(this.btnDeleteTournament_Click);
            // 
            // lbxTournaments
            // 
            this.lbxTournaments.FormattingEnabled = true;
            this.lbxTournaments.ItemHeight = 20;
            this.lbxTournaments.Location = new System.Drawing.Point(245, 20);
            this.lbxTournaments.Name = "lbxTournaments";
            this.lbxTournaments.Size = new System.Drawing.Size(485, 544);
            this.lbxTournaments.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(750, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(118, 56);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // GenerateSchedule
            // 
            this.GenerateSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GenerateSchedule.BackgroundImage")));
            this.GenerateSchedule.Controls.Add(this.btnGenerateMatches);
            this.GenerateSchedule.Controls.Add(this.cmbxTournaments);
            this.GenerateSchedule.Controls.Add(this.dataGridView1);
            this.GenerateSchedule.Controls.Add(this.btnHome1);
            this.GenerateSchedule.Location = new System.Drawing.Point(4, 29);
            this.GenerateSchedule.Name = "GenerateSchedule";
            this.GenerateSchedule.Size = new System.Drawing.Size(1439, 622);
            this.GenerateSchedule.TabIndex = 2;
            this.GenerateSchedule.Text = "GenerateGames";
            this.GenerateSchedule.UseVisualStyleBackColor = true;
            // 
            // btnGenerateMatches
            // 
            this.btnGenerateMatches.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateMatches.Location = new System.Drawing.Point(550, 154);
            this.btnGenerateMatches.Name = "btnGenerateMatches";
            this.btnGenerateMatches.Size = new System.Drawing.Size(166, 69);
            this.btnGenerateMatches.TabIndex = 3;
            this.btnGenerateMatches.Text = "Generate Schedule";
            this.btnGenerateMatches.UseVisualStyleBackColor = true;
            this.btnGenerateMatches.Click += new System.EventHandler(this.btnGenerateMatches_Click);
            // 
            // cmbxTournaments
            // 
            this.cmbxTournaments.FormattingEnabled = true;
            this.cmbxTournaments.Location = new System.Drawing.Point(116, 31);
            this.cmbxTournaments.Name = "cmbxTournaments";
            this.cmbxTournaments.Size = new System.Drawing.Size(399, 28);
            this.cmbxTournaments.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player1,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(116, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(308, 444);
            this.dataGridView1.TabIndex = 1;
            // 
            // Player1
            // 
            this.Player1.HeaderText = "Player 1";
            this.Player1.MinimumWidth = 6;
            this.Player1.Name = "Player1";
            this.Player1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Player 2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // btnHome1
            // 
            this.btnHome1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome1.Location = new System.Drawing.Point(625, 31);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(111, 53);
            this.btnHome1.TabIndex = 0;
            this.btnHome1.Text = "Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // AddResults
            // 
            this.AddResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddResults.BackgroundImage")));
            this.AddResults.Controls.Add(this.btnSaveResults);
            this.AddResults.Controls.Add(this.lblCheck);
            this.AddResults.Controls.Add(this.dataGridView2);
            this.AddResults.Controls.Add(this.cmbxTournamentsResults);
            this.AddResults.Controls.Add(this.btnHome2);
            this.AddResults.Location = new System.Drawing.Point(4, 29);
            this.AddResults.Name = "AddResults";
            this.AddResults.Size = new System.Drawing.Size(1439, 622);
            this.AddResults.TabIndex = 3;
            this.AddResults.Text = "Add Results";
            this.AddResults.UseVisualStyleBackColor = true;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveResults.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveResults.Location = new System.Drawing.Point(840, 126);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(143, 56);
            this.btnSaveResults.TabIndex = 6;
            this.btnSaveResults.Text = "Add Results";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(611, 214);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(0, 20);
            this.lblCheck.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameId,
            this.Player1Id,
            this.Player2Id,
            this.Result1Player,
            this.Result2Player});
            this.dataGridView2.Location = new System.Drawing.Point(32, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(776, 341);
            this.dataGridView2.TabIndex = 4;
            // 
            // GameId
            // 
            this.GameId.HeaderText = "Game Id";
            this.GameId.MinimumWidth = 6;
            this.GameId.Name = "GameId";
            this.GameId.ReadOnly = true;
            this.GameId.Width = 125;
            // 
            // Player1Id
            // 
            this.Player1Id.HeaderText = "Player 1";
            this.Player1Id.MinimumWidth = 6;
            this.Player1Id.Name = "Player1Id";
            this.Player1Id.ReadOnly = true;
            this.Player1Id.Width = 125;
            // 
            // Player2Id
            // 
            this.Player2Id.HeaderText = "Player 2";
            this.Player2Id.MinimumWidth = 6;
            this.Player2Id.Name = "Player2Id";
            this.Player2Id.ReadOnly = true;
            this.Player2Id.Width = 125;
            // 
            // Result1Player
            // 
            this.Result1Player.HeaderText = "Points Player 1";
            this.Result1Player.MinimumWidth = 6;
            this.Result1Player.Name = "Result1Player";
            this.Result1Player.Width = 125;
            // 
            // Result2Player
            // 
            this.Result2Player.HeaderText = "Points Player 2";
            this.Result2Player.MinimumWidth = 6;
            this.Result2Player.Name = "Result2Player";
            this.Result2Player.Width = 125;
            // 
            // cmbxTournamentsResults
            // 
            this.cmbxTournamentsResults.FormattingEnabled = true;
            this.cmbxTournamentsResults.Location = new System.Drawing.Point(124, 35);
            this.cmbxTournamentsResults.Name = "cmbxTournamentsResults";
            this.cmbxTournamentsResults.Size = new System.Drawing.Size(399, 28);
            this.cmbxTournamentsResults.TabIndex = 3;
            this.cmbxTournamentsResults.SelectedIndexChanged += new System.EventHandler(this.cmbxTournamentsResults_SelectedIndexChanged);
            // 
            // btnHome2
            // 
            this.btnHome2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome2.Location = new System.Drawing.Point(655, 35);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(111, 54);
            this.btnHome2.TabIndex = 0;
            this.btnHome2.Text = "Home";
            this.btnHome2.UseVisualStyleBackColor = true;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Player 1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 652);
            this.Controls.Add(this.tabControl);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.tabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).EndInit();
            this.ManageTournaments.ResumeLayout(false);
            this.GenerateSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AddResults.ResumeLayout(false);
            this.AddResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageTournaments;
        private System.Windows.Forms.Button btnGenerateGames;
        private System.Windows.Forms.Button btnAddResults;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage ManageTournaments;
        private System.Windows.Forms.TabPage GenerateSchedule;
        private System.Windows.Forms.TabPage AddResults;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.Button btnHome2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.Button btnEditTournament;
        private System.Windows.Forms.Button btnDeleteTournament;
        private System.Windows.Forms.ListBox lbxTournaments;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnGenerateMatches;
        private System.Windows.Forms.ComboBox cmbxTournaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cmbxTournamentsResults;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.DataGridView dataGridViewOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentSystemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterClosedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPlayersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPlayersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result1Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result2Player;
        private System.Windows.Forms.Button btnLogout;
    }
}