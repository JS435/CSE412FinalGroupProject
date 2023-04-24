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
    public partial class myAlbums : Form
    {
        int id = 0;
        public myAlbums(string userId)
        {
            InitializeComponent();
            id = Convert.ToInt32(userId);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Profile profilePage = new Profile(id.ToString());
            profilePage.Show();
            this.Visible = false;
        }

        private void albumsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.albumsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);

        }

        private void myAlbums_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.userDatabase.Albums);

            var albumTable = this.albumsTableAdapter.GetDataByUserId(id);

            string albums = "";
            for (int i = 0; i < albumTable.Count; i++)
            {              
                albums = albums + "Album: " +  albumTable[i].albumName + 
                    " - Made On: " + albumTable[i].albumDoB + Environment.NewLine;
            }
            albumsTextbox.Text = albums;
        }
    }
}
