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
    public partial class Main : Form
    {
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);
        }

        Boolean likeFlag = false;
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Likes' table. You can move, or remove it, as needed.
            this.likesTableAdapter.Fill(this.userDatabase.Likes);
            // TODO: This line of code loads data into the 'userDatabase.Comments' table. You can move, or remove it, as needed.
            this.commentsTableAdapter.Fill(this.userDatabase.Comments);
            // TODO: This line of code loads data into the 'userDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDatabase.Users);

            var commentDataTable = this.commentsTableAdapter.GetDataByPhotoId(15);
            string comments = "";
               
            for (int i = 0; i < commentDataTable.Count; i++)
            {           
                comments = comments + "User " + commentDataTable[i].commentUserId + ": " + commentDataTable[i].commentText + Environment.NewLine;
            }
            commentTextbox.Text = comments;

            int likeCount = (int)this.likesTableAdapter.countLikes(2);
            likeLabel.Text = likeCount.ToString();

            if(Convert.ToBoolean(this.likesTableAdapter.FillBylikeUserId(userDatabase.Likes, id)))
            {
                likeButton.BackgroundImage = System.Drawing.Image.FromFile(location + "instaAfterLike.png");
                likeFlag = true;
            }
        }

        int id = 0;
        public Main(string userId)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(userId);
            userLabel.Text = userId;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var dataTable = this.usersTableAdapter.getSearchUserID(id);
            string fname = dataTable[0].firstname;
            string lname = dataTable[0].lastname;

            MessageBox.Show("Goodbye " + fname + " " + lname);
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Visible = false;
        }
        
        string location = @"C:\Users\jswen\source\repos\CSE412_FinalGroupProject\CSE412_FinalGroupProject\Resources\";
        private void likeButton_Click(object sender, EventArgs e)
        {
            if(likeFlag == false)
            {
                likeButton.BackgroundImage = System.Drawing.Image.FromFile(location + "instaAfterLike.png");
                likeFlag = true;
                this.likesTableAdapter.addLike(id, 2);
                int likeCount = (int)this.likesTableAdapter.countLikes(2);
                likeLabel.Text = likeCount.ToString();
            }
            else
            {
                likeButton.BackgroundImage = System.Drawing.Image.FromFile(location + "instaLike.png");
                likeFlag = false;
                this.likesTableAdapter.deleteLike(id);
                int likeCount = (int)this.likesTableAdapter.countLikes(2);
                likeLabel.Text = likeCount.ToString();
            }
        }

        private void viewFriendsButton_Click(object sender, EventArgs e)
        {
            FriendsList friendsListPage = new FriendsList(id.ToString());
            friendsListPage.Show();
            this.Visible = false;
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            Profile profilePage = new Profile(id.ToString());
            profilePage.Show();
            this.Visible = false;
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            Comment commentPage = new Comment(id.ToString());
            commentPage.Show();
            this.Visible = false;
        }
    }
}
