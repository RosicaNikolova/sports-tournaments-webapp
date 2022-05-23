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
        }

        public EditTournament(Tournament tournament)
        {
            InitializeComponent();
            this.tournament = tournament;
        }

    }
}
