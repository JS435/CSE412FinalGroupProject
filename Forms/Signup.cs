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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDatabase.Users);
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string emailAddress = emailTextbox.Text;
            string fname = fnameTextbox.Text;
            string lname = lnameTextbox.Text;
            string hometown = hometownTextbox.Text;
            string password = passwordTextbox.Text;
            string birthday = birthdayTextbox.Text;
            string gender = genderTextbox.Text;

            if (emailAddress == "" || password == "")
            {
                MessageBox.Show("Please make sure to enter an email and password");
            }
            else
            {
                if (Convert.ToBoolean(this.usersTableAdapter.FillBy(this.userDatabase.Users, emailAddress)))
                {
                    MessageBox.Show("An account under that email already exists. Please input a different email");
                }
                else
                {
                    /*
                    userDatabase.UsersRow newUserRow;
                    newUserRow = userDatabase.Users.NewUsersRow();
                    newUserRow.email = emailAddress;
                    newUserRow.password = password;
                    newUserRow.birthday = birthday;
                    newUserRow.firstname = fname;
                    newUserRow.lastname = lname;
                    newUserRow.gender = gender;
                    newUserRow.hometown = hometown;
                    this.userDatabase.Users.Rows.Add(newUserRow);
                    this.userDatabase.AcceptChanges();
                    this.usersTableAdapter.Update(this.userDatabase.Users);
                    */

                    //this.usersTableAdapter.Insert(emailAddress, password, birthday, fname, gender, hometown, lname);
                    this.usersTableAdapter.InsertUser(emailAddress, password, birthday, fname, gender, hometown, lname, 0);
                    this.userDatabase.AcceptChanges();
                    this.usersTableAdapter.Update(this.userDatabase);

                    MessageBox.Show("Account Created");
                    Form1 loginPage = new Form1();
                    loginPage.Show();
                    this.Close();
                    Visible = false;
                }
            }         
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Visible = false;
        }
    }
}
