using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth;

namespace TOGETHERCULTURECRM.Classes.MembersDashboard.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            lblWelcomeFirstName.Text = $"{LoggedInUser.FirstName}!";
        }

        private void lblWelcomeFirstName_Click(object sender, EventArgs e)
        {

        }

        private void linkMyProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkBookSpace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
