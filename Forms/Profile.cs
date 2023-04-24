using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CSE412_FinalGroupProject
{
    public partial class Profile : Form
    {
        int id = 0;
        public Profile(string userId)
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

        private void Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Tags' table. You can move, or remove it, as needed.
            this.tagsTableAdapter.Fill(this.userDatabase.Tags);
            // TODO: This line of code loads data into the 'userDatabase.Photos' table. You can move, or remove it, as needed.
            this.photosTableAdapter.Fill(this.userDatabase.Photos);
            // TODO: This line of code loads data into the 'userDatabase.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.userDatabase.Albums);
            // TODO: This line of code loads data into the 'userDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDatabase.Users);

            var dataTable = this.usersTableAdapter.getSearchUserID(id);
            string fname = dataTable[0].firstname;
            string lname = dataTable[0].lastname;
            string hometown = dataTable[0].hometown;
            string gender = dataTable[0].gender;
            string email = dataTable[0].email;
            string birthday = dataTable[0].birthday;

            fnameLabel.Text = fname;
            lnameLabel.Text = lname;
            hometownLabel.Text = hometown;
            genderLabel.Text = gender;
            emailLabel.Text = email;
            birthdayLabel.Text = birthday;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main(id.ToString());
            mainPage.Show();
            this.Visible = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string albumName = Interaction.InputBox("Enter an album name for your new album", "Add Album", "New Album");
            this.albumsTableAdapter.insertAlbum(id, albumName, DateTime.Today.ToString());
            MessageBox.Show("Album Added");
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "All files (*.*)|*.*";
            var filePath = string.Empty;
            var fileContent = string.Empty;
            if (opnfd.ShowDialog() == DialogResult.OK)
            {              
                var fileStream = opnfd.OpenFile();
                filePath = opnfd.FileName;

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                this.photosTableAdapter.insertPhoto(id, fileContent, "");
            }
            string photoCaption = Interaction.InputBox("Enter a caption for your photo", "Caption", "NewPhoto");
            string tags = Interaction.InputBox("Give your photo some tags", "Tags", "#NewTag");

            this.photosTableAdapter.insertPhoto(id, filePath, photoCaption);

            int photoId = (int)this.photosTableAdapter.countPhotos() + 2;
            this.tagsTableAdapter.insertTag(photoId, id, tags);
            MessageBox.Show("Photo Added");

            int activity = (int)this.usersTableAdapter.getUserActivity(id);
            this.usersTableAdapter.updateActivity(activity + 1, id);
        }

        private void userActivityButton_Click(object sender, EventArgs e)
        {
            userActivity userActivityPage = new userActivity(id.ToString());
            userActivityPage.Show();
            this.Visible = false;
        }

        private void myAlbumsButton_Click(object sender, EventArgs e)
        {
            myAlbums albumsPage = new myAlbums(id.ToString());
            albumsPage.Show();
            this.Visible = false;
        }

        private void tagButton_Click(object sender, EventArgs e)
        {
            popularTags tagPage = new popularTags(id.ToString());
            tagPage.Show();
            this.Visible = false;
        }
    }
}
