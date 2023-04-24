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
    public partial class FriendsList : Form
    {
        int id = 0;
        public FriendsList(string userId)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(userId);
        }

        private void friendsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.friendsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);

        }

        private void FriendsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDatabase.Users);
            // TODO: This line of code loads data into the 'userDatabase.Friends' table. You can move, or remove it, as needed.
            this.friendsTableAdapter.Fill(this.userDatabase.Friends);

            var friendsDataTable = this.friendsTableAdapter.GetDataFriends(id);

            string friends = "";
            for(int i = 0; i < friendsDataTable.Count; i++)
            {
                var userDataTable = this.usersTableAdapter.getSearchUserID(friendsDataTable[i].friendOfUserId);
                friends = friends + userDataTable[0].firstname + " " + userDataTable[0].lastname 
                    + " - Since: " + friendsDataTable[i].friendshipDate + Environment.NewLine;
            }
            friendTextBox.Text = friends;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main(id.ToString());
            mainPage.Show();
            this.Visible = false;
        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            addFriend addFriendPage = new addFriend(id.ToString());
            addFriendPage.Show();
            this.Visible = false;
        }
    }
}
