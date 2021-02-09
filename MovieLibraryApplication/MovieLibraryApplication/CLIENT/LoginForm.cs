using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieLibraryApplication.CLIENT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((this.textBoxUser.Text == "admin") && (this.textBoxPassword.Text == "123" ))
            {
                MovieLibraryForm myMovieLibraryForm = new MovieLibraryForm();
                myMovieLibraryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Your User or Password is wrong", "Please try again");
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach ( Control myControl in Controls)
            {
                if (myControl is TextBox)
                {
                    myControl.Text = "";
                }
            }
            this.textBoxUser.Focus();
        }

        private void buttonExitLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
