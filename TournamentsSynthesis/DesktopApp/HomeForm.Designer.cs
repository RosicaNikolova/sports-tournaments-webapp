
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
            this.ManageTournaments = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnEditTournament = new System.Windows.Forms.Button();
            this.btnDeleteTournament = new System.Windows.Forms.Button();
            this.lbxTournaments = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.GenerateSchedule = new System.Windows.Forms.TabPage();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.AddResults = new System.Windows.Forms.TabPage();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Home.SuspendLayout();
            this.ManageTournaments.SuspendLayout();
            this.GenerateSchedule.SuspendLayout();
            this.AddResults.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(814, 448);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.btnGenerateGames);
            this.Home.Controls.Add(this.btnAddResults);
            this.Home.Controls.Add(this.btnManageTournaments);
            this.Home.Location = new System.Drawing.Point(4, 29);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(806, 415);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
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
            this.ManageTournaments.Size = new System.Drawing.Size(806, 415);
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
            this.GenerateSchedule.Controls.Add(this.btnHome1);
            this.GenerateSchedule.Location = new System.Drawing.Point(4, 29);
            this.GenerateSchedule.Name = "GenerateSchedule";
            this.GenerateSchedule.Size = new System.Drawing.Size(806, 415);
            this.GenerateSchedule.TabIndex = 2;
            this.GenerateSchedule.Text = "GenerateGames";
            this.GenerateSchedule.UseVisualStyleBackColor = true;
            // 
            // btnHome1
            // 
            this.btnHome1.Location = new System.Drawing.Point(519, 73);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(94, 29);
            this.btnHome1.TabIndex = 0;
            this.btnHome1.Text = "Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // AddResults
            // 
            this.AddResults.Controls.Add(this.btnHome2);
            this.AddResults.Location = new System.Drawing.Point(4, 29);
            this.AddResults.Name = "AddResults";
            this.AddResults.Size = new System.Drawing.Size(806, 415);
            this.AddResults.TabIndex = 3;
            this.AddResults.Text = "Add Results";
            this.AddResults.UseVisualStyleBackColor = true;
            // 
            // btnHome2
            // 
            this.btnHome2.Location = new System.Drawing.Point(572, 54);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(94, 29);
            this.btnHome2.TabIndex = 0;
            this.btnHome2.Text = "Home";
            this.btnHome2.UseVisualStyleBackColor = true;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.tabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.ManageTournaments.ResumeLayout(false);
            this.GenerateSchedule.ResumeLayout(false);
            this.AddResults.ResumeLayout(false);
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
    }
}