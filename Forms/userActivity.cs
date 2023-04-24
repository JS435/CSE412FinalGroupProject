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
    public partial class userActivity : Form
    {
        int id = 0;
        public userActivity(string userId)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(userId);  
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);

        }

        private void userActivity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDatabase.Users);

            var usersActivityTable = this.usersTableAdapter.GetDataByUserActivity();

            string users = "";
            for (int i = 0; i < 10; i++)
            {
                var userDataTable = this.usersTableAdapter.getSearchUserID(usersActivityTable[i].Id);
                users = users + (i + 1).ToString() + ": " + userDataTable[0].firstname + " " + userDataTable[0].lastname
                    + " - Points: " + usersActivityTable[i].userActivity + Environment.NewLine;
            }
            activityTextbox.Text = users;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Profile profilePage = new Profile(id.ToString());
            profilePage.Show();
            this.Visible = false;
        }
    }
}
