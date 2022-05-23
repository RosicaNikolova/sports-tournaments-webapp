
namespace DesktopApp
{
    partial class EditTournament
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
            this.cmbxSportType = new System.Windows.Forms.ComboBox();
            this.lblSportType = new System.Windows.Forms.Label();
            this.lblTournamentSystem = new System.Windows.Forms.Label();
            this.cmbxTournamentSystem = new System.Windows.Forms.ComboBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblMinPlayers = new System.Windows.Forms.Label();
            this.lblMaxPlayers = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.txbMinPlayers = new System.Windows.Forms.TextBox();
            this.txbMaxPlayers = new System.Windows.Forms.TextBox();
            this.tbxLocation = new System.Windows.Forms.TextBox();
            this.btnEditCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbxSportType
            // 
            this.cmbxSportType.FormattingEnabled = true;
            this.cmbxSportType.Items.AddRange(new object[] {
            "Badminton"});
            this.cmbxSportType.Location = new System.Drawing.Point(243, 53);
            this.cmbxSportType.Name = "cmbxSportType";
            this.cmbxSportType.Size = new System.Drawing.Size(177, 28);
            this.cmbxSportType.TabIndex = 0;
            // 
            // lblSportType
            // 
            this.lblSportType.AutoSize = true;
            this.lblSportType.Location = new System.Drawing.Point(140, 53);
            this.lblSportType.Name = "lblSportType";
            this.lblSportType.Size = new System.Drawing.Size(80, 20);
            this.lblSportType.TabIndex = 1;
            this.lblSportType.Text = "Sport Type";
            // 
            // lblTournamentSystem
            // 
            this.lblTournamentSystem.AutoSize = true;
            this.lblTournamentSystem.Location = new System.Drawing.Point(81, 128);
            this.lblTournamentSystem.Name = "lblTournamentSystem";
            this.lblTournamentSystem.Size = new System.Drawing.Size(139, 20);
            this.lblTournamentSystem.TabIndex = 2;
            this.lblTournamentSystem.Text = "Tournament System";
            // 
            // cmbxTournamentSystem
            // 
            this.cmbxTournamentSystem.FormattingEnabled = true;
            this.cmbxTournamentSystem.Items.AddRange(new object[] {
            "Round-Robin",
            "Double Round-Robin"});
            this.cmbxTournamentSystem.Location = new System.Drawing.Point(243, 125);
            this.cmbxTournamentSystem.Name = "cmbxTournamentSystem";
            this.cmbxTournamentSystem.Size = new System.Drawing.Size(177, 28);
            this.cmbxTournamentSystem.TabIndex = 3;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(243, 199);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(250, 27);
            this.tbxDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(135, 202);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(140, 263);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 20);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(140, 323);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 20);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date";
            // 
            // lblMinPlayers
            // 
            this.lblMinPlayers.AutoSize = true;
            this.lblMinPlayers.Location = new System.Drawing.Point(98, 376);
            this.lblMinPlayers.Name = "lblMinPlayers";
            this.lblMinPlayers.Size = new System.Drawing.Size(122, 20);
            this.lblMinPlayers.TabIndex = 8;
            this.lblMinPlayers.Text = "Minimum Players";
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.Location = new System.Drawing.Point(94, 438);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(125, 20);
            this.lblMaxPlayers.TabIndex = 9;
            this.lblMaxPlayers.Text = "Maximum Players";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(154, 499);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 20);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location";
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.Location = new System.Drawing.Point(243, 263);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimeStartDate.TabIndex = 11;
            // 
            // dateTimeEndDate
            // 
            this.dateTimeEndDate.Location = new System.Drawing.Point(243, 318);
            this.dateTimeEndDate.Name = "dateTimeEndDate";
            this.dateTimeEndDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimeEndDate.TabIndex = 12;
            // 
            // txbMinPlayers
            // 
            this.txbMinPlayers.Location = new System.Drawing.Point(243, 376);
            this.txbMinPlayers.Name = "txbMinPlayers";
            this.txbMinPlayers.Size = new System.Drawing.Size(125, 27);
            this.txbMinPlayers.TabIndex = 13;
            // 
            // txbMaxPlayers
            // 
            this.txbMaxPlayers.Location = new System.Drawing.Point(243, 435);
            this.txbMaxPlayers.Name = "txbMaxPlayers";
            this.txbMaxPlayers.Size = new System.Drawing.Size(125, 27);
            this.txbMaxPlayers.TabIndex = 14;
            // 
            // tbxLocation
            // 
            this.tbxLocation.Location = new System.Drawing.Point(243, 496);
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.Size = new System.Drawing.Size(250, 27);
            this.tbxLocation.TabIndex = 15;
            // 
            // btnEditCreate
            // 
            this.btnEditCreate.Location = new System.Drawing.Point(312, 554);
            this.btnEditCreate.Name = "btnEditCreate";
            this.btnEditCreate.Size = new System.Drawing.Size(108, 53);
            this.btnEditCreate.TabIndex = 16;
            this.btnEditCreate.Text = "Create";
            this.btnEditCreate.UseVisualStyleBackColor = true;
            // 
            // EditTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.btnEditCreate);
            this.Controls.Add(this.tbxLocation);
            this.Controls.Add(this.txbMaxPlayers);
            this.Controls.Add(this.txbMinPlayers);
            this.Controls.Add(this.dateTimeEndDate);
            this.Controls.Add(this.dateTimeStartDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblMaxPlayers);
            this.Controls.Add(this.lblMinPlayers);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.cmbxTournamentSystem);
            this.Controls.Add(this.lblTournamentSystem);
            this.Controls.Add(this.lblSportType);
            this.Controls.Add(this.cmbxSportType);
            this.Name = "EditTournament";
            this.Text = "EditTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxSportType;
        private System.Windows.Forms.Label lblSportType;
        private System.Windows.Forms.Label lblTournamentSystem;
        private System.Windows.Forms.ComboBox cmbxTournamentSystem;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblMinPlayers;
        private System.Windows.Forms.Label lblMaxPlayers;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.DateTimePicker dateTimeEndDate;
        private System.Windows.Forms.TextBox txbMinPlayers;
        private System.Windows.Forms.TextBox txbMaxPlayers;
        private System.Windows.Forms.TextBox tbxLocation;
        private System.Windows.Forms.Button btnEditCreate;
    }
}