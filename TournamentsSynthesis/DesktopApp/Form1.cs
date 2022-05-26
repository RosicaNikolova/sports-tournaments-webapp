using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        LoginManager loginManager = new LoginManager(new UserRepository());

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txbEmail.Text;
                string password = txbPassword.Text;

                if (email == string.Empty)
                {
                    MessageBox.Show("Email field is empty");
                }
                else if (password == string.Empty)
                {
                    MessageBox.Show("Password field is empty");
                }
                else
                {
                    User user = loginManager.Login(email, password);
                    if (user == null)
                    {
                        MessageBox.Show("User with these credentials does not exist");
                    }
                    else
                    {
                        HomeForm homeForm = new HomeForm(user);
                        homeForm.Show();
                    }
                }
            }
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while processing you request.Please, try again later");
            }
            catch (Exception)
            {
                MessageBox.Show("The entered information is ivalid");
            }

        }
    }
}
