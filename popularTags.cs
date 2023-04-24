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
    public partial class popularTags : Form
    {
        int id = 0;
        public popularTags(string userId)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(userId);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Profile profilePage = new Profile(id.ToString());
            profilePage.Show();
            this.Visible = false;
        }

        private void tagsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tagsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);

        }

        private void popularTags_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Tags' table. You can move, or remove it, as needed.
            this.tagsTableAdapter.Fill(this.userDatabase.Tags);

            var allTags = this.tagsTableAdapter.GetByPopularTags();

            string tags = "";
            for(int i = 0; i < allTags.Count; i++)
            {
                tags = tags + "Name: " + allTags[i].tagWord 
                    + " - Count: " + this.tagsTableAdapter.countTags(allTags[i].tagWord);
            }
            tagTextbox.Text = tags;
        }
    }
}
