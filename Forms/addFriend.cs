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
    public partial class addFriend : Form
    {
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);
        }

        private void addFriend_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Friends' table. You can move, or remove it, as needed.
            this.friendsTableAdapter.Fill(this.userDatabase.Friends);
            // TODO: This line of code loads data into the 'userDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDatabase.Users);
        }

        int id = 0;
        public addFriend(string userId)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(userId);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FriendsList friendsListPage = new FriendsList(id.ToString());
            friendsListPage.Show();
            this.Visible = false;
        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            var usersDataTable = this.usersTableAdapter.GetDataByEmailSearch(email);
            if(Convert.ToBoolean(this.usersTableAdapter.FillByEmailSearch(this.userDatabase.Users, email)))
            {
                if(Convert.ToBoolean(this.friendsTableAdapter.FillByFindFriendship(this.userDatabase.Friends, id, usersDataTable[0].Id)))
                {
                    MessageBox.Show("You already have this friend added. Please enter a different email");
                }
                else
                {
                    this.friendsTableAdapter.addFriend(id, usersDataTable[0].Id, DateTime.Today.ToString());
                    MessageBox.Show("Friend added!");
                }
            }
            else
            {
                MessageBox.Show("A user under that email was not found, please enter a different email");
            }        
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            var usersDataTable = this.usersTableAdapter.GetDataByEmailSearch(email);
            if (Convert.ToBoolean(this.usersTableAdapter.FillByEmailSearch(this.userDatabase.Users, email)))
            {
                if (Convert.ToBoolean(this.friendsTableAdapter.FillByFindFriendship(this.userDatabase.Friends, id, usersDataTable[0].Id)))
                {
                    this.friendsTableAdapter.deleteFriend(id, usersDataTable[0].Id);
                    MessageBox.Show("Friend deleted succesfully");
                }
                else
                {
                    MessageBox.Show("You do not have this friend added");
                }
            }
            else
            {
                MessageBox.Show("A user under that email was not found, please enter a different email");
            }
        }

        private void recommendFriends_Click(object sender, EventArgs e)
        {
            var friendsDataTable = this.friendsTableAdapter.GetDataFriends(id);
            string friends = "";

            for(int i = 0; i < friendsDataTable.Count; i++)
            {
                var friendsOfFriends = this.friendsTableAdapter.GetDataFriends(friendsDataTable[i].friendOfUserId);
                for(int j = 0; j < friendsOfFriends.Count; j++)
                {
                    var userTable = this.usersTableAdapter.getSearchUserID(friendsOfFriends[j].friendOfUserId);
                    friends = friends + "Name: " + userTable[0].firstname + " " + userTable[0].lastname + " - Email: " +
                    userTable[0].email + Environment.NewLine;
                }                              
            }
            MessageBox.Show(friends);
        }
    }
}
