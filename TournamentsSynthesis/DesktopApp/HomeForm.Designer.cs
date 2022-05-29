
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
            this.btnManageTournaments = new System.Windows.Forms.Button();
            this.btnGenerateGames = new System.Windows.Forms.Button();
            this.btnAddResults = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
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
            this.ManageTournaments.SuspendLayout();
            this.GenerateSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AddResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageTournaments
            // 
            this.btnManageTournaments.Location = new System.Drawing.Point(89, 122);
            this.btnManageTournaments.Name = "btnManageTournaments";
            this.btnManageTournaments.Size = new System.Drawing.Size(110, 61);
            this.btnManageTournaments.TabIndex = 0;
            this.btnManageTournaments.Text = "Manage Tournaments";
            this.btnManageTournaments.UseVisualStyleBackColor = true;
            this.btnManageTournaments.Click += new System.EventHandler(this.btnManageTournaments_Click);
            // 
            // btnGenerateGames
            // 
            this.btnGenerateGames.Location = new System.Drawing.Point(241, 122);
            this.btnGenerateGames.Name = "btnGenerateGames";
            this.btnGenerateGames.Size = new System.Drawing.Size(94, 61);
            this.btnGenerateGames.TabIndex = 1;
            this.btnGenerateGames.Text = "Generate Games";
            this.btnGenerateGames.UseVisualStyleBackColor = true;
            this.btnGenerateGames.Click += new System.EventHandler(this.btnGenerateGames_Click);
            // 
            // btnAddResults
            // 
            this.btnAddResults.Location = new System.Drawing.Point(370, 122);
            this.btnAddResults.Name = "btnAddResults";
            this.btnAddResults.Size = new System.Drawing.Size(110, 61);
            this.btnAddResults.TabIndex = 2;
            this.btnAddResults.Text = "Add Results";
            this.btnAddResults.UseVisualStyleBackColor = true;
            this.btnAddResults.Click += new System.EventHandler(this.btnAddResults_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Home);
            this.tabControl.Controls.Add(this.ManageTournaments);
            this.tabControl.Controls.Add(this.GenerateSchedule);
            this.tabControl.Controls.Add(this.AddResults);
            this.tabControl.Location = new System.Drawing.Point(-5, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(956, 500);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.lblWelcome);
            this.Home.Controls.Add(this.btnGenerateGames);
            this.Home.Controls.Add(this.btnAddResults);
            this.Home.Controls.Add(this.btnManageTournaments);
            this.Home.Location = new System.Drawing.Point(4, 29);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(948, 467);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
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
            this.ManageTournaments.Controls.Add(this.btnRefresh);
            this.ManageTournaments.Controls.Add(this.btnCreateTournament);
            this.ManageTournaments.Controls.Add(this.btnEditTournament);
            this.ManageTournaments.Controls.Add(this.btnDeleteTournament);
            this.ManageTournaments.Controls.Add(this.lbxTournaments);
            this.ManageTournaments.Controls.Add(this.btnHome);
            this.ManageTournaments.Location = new System.Drawing.Point(4, 29);
            this.ManageTournaments.Name = "ManageTournaments";
            this.ManageTournaments.Padding = new System.Windows.Forms.Padding(3);
            this.ManageTournaments.Size = new System.Drawing.Size(948, 467);
            this.ManageTournaments.TabIndex = 0;
            this.ManageTournaments.Text = "ManageTournaments";
            this.ManageTournaments.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(84, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 29);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(73, 220);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(94, 29);
            this.btnCreateTournament.TabIndex = 4;
            this.btnCreateTournament.Text = "Create";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // btnEditTournament
            // 
            this.btnEditTournament.Location = new System.Drawing.Point(73, 284);
            this.btnEditTournament.Name = "btnEditTournament";
            this.btnEditTournament.Size = new System.Drawing.Size(94, 29);
            this.btnEditTournament.TabIndex = 3;
            this.btnEditTournament.Text = "Edit";
            this.btnEditTournament.UseVisualStyleBackColor = true;
            this.btnEditTournament.Click += new System.EventHandler(this.btnEditTournament_Click);
            // 
            // btnDeleteTournament
            // 
            this.btnDeleteTournament.Location = new System.Drawing.Point(73, 355);
            this.btnDeleteTournament.Name = "btnDeleteTournament";
            this.btnDeleteTournament.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteTournament.TabIndex = 2;
            this.btnDeleteTournament.Text = "Delete";
            this.btnDeleteTournament.UseVisualStyleBackColor = true;
            this.btnDeleteTournament.Click += new System.EventHandler(this.btnDeleteTournament_Click);
            // 
            // lbxTournaments
            // 
            this.lbxTournaments.FormattingEnabled = true;
            this.lbxTournaments.ItemHeight = 20;
            this.lbxTournaments.Location = new System.Drawing.Point(270, 20);
            this.lbxTournaments.Name = "lbxTournaments";
            this.lbxTournaments.Size = new System.Drawing.Size(389, 364);
            this.lbxTournaments.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(681, 18);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 29);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // GenerateSchedule
            // 
            this.GenerateSchedule.Controls.Add(this.btnGenerateMatches);
            this.GenerateSchedule.Controls.Add(this.cmbxTournaments);
            this.GenerateSchedule.Controls.Add(this.dataGridView1);
            this.GenerateSchedule.Controls.Add(this.btnHome1);
            this.GenerateSchedule.Location = new System.Drawing.Point(4, 29);
            this.GenerateSchedule.Name = "GenerateSchedule";
            this.GenerateSchedule.Size = new System.Drawing.Size(948, 467);
            this.GenerateSchedule.TabIndex = 2;
            this.GenerateSchedule.Text = "GenerateGames";
            this.GenerateSchedule.UseVisualStyleBackColor = true;
            // 
            // btnGenerateMatches
            // 
            this.btnGenerateMatches.Location = new System.Drawing.Point(606, 76);
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
            this.dataGridView1.Location = new System.Drawing.Point(52, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(476, 188);
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
            this.btnHome1.Location = new System.Drawing.Point(678, 30);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(94, 29);
            this.btnHome1.TabIndex = 0;
            this.btnHome1.Text = "Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // AddResults
            // 
            this.AddResults.Controls.Add(this.btnSaveResults);
            this.AddResults.Controls.Add(this.lblCheck);
            this.AddResults.Controls.Add(this.dataGridView2);
            this.AddResults.Controls.Add(this.cmbxTournamentsResults);
            this.AddResults.Controls.Add(this.btnHome2);
            this.AddResults.Location = new System.Drawing.Point(4, 29);
            this.AddResults.Name = "AddResults";
            this.AddResults.Size = new System.Drawing.Size(948, 467);
            this.AddResults.TabIndex = 3;
            this.AddResults.Text = "Add Results";
            this.AddResults.UseVisualStyleBackColor = true;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Location = new System.Drawing.Point(781, 257);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(109, 39);
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
            this.dataGridView2.Size = new System.Drawing.Size(694, 341);
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
            this.Result1Player.HeaderText = "Points ";
            this.Result1Player.MinimumWidth = 6;
            this.Result1Player.Name = "Result1Player";
            this.Result1Player.Width = 125;
            // 
            // Result2Player
            // 
            this.Result2Player.HeaderText = "Points";
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
            this.btnHome2.Location = new System.Drawing.Point(655, 35);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(94, 29);
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
            this.ClientSize = new System.Drawing.Size(941, 583);
            this.Controls.Add(this.tabControl);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.tabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn GameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result1Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result2Player;
    }
}