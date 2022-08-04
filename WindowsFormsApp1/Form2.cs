using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text; 
            if (username == "admin" && password == "admin")
            {
                Form1 home = new Form1(username, this);
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                txtUsername.Clear();
                txtPassword.Clear();

            }
        }
    }
}
