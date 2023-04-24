using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE412_FinalGroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'userDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDatabase.Users);
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userEmail = usernameTextbox.Text;
            string userPassword = passwordTextbox.Text;

            if (Convert.ToBoolean(this.usersTableAdapter.FillLoginInfo(this.userDatabase.Users, userEmail, userPassword)))
            {
                MessageBox.Show("Login Successful");       
                var dataTable = this.usersTableAdapter.GetDataUserId(userEmail, userPassword);
                string userId = dataTable[0].Id.ToString();

                Main mainPage = new Main(userId);
                mainPage.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("There was no login with that username or password found.");
            }           
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Signup signupPage = new Signup();
            signupPage.Show();
            Visible = false;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
