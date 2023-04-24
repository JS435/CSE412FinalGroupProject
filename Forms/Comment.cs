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
    public partial class Comment : Form
    {
        int id = 0;
        public Comment(string userId)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(userId);
        }

        private void commentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDatabase);

        }

        private void Comment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDatabase.Users);
            // TODO: This line of code loads data into the 'userDatabase.Comments' table. You can move, or remove it, as needed.
            this.commentsTableAdapter.Fill(this.userDatabase.Comments);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main(id.ToString());
            mainPage.Show();
            this.Visible = false;
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            string comment = commentTextbox.Text;
            this.commentsTableAdapter.insertComment(id, 15, comment, DateTime.Today.ToString());

            int activity = (int)this.usersTableAdapter.getUserActivity(id);
            this.usersTableAdapter.updateActivity(activity + 1, id);

            Main mainPage = new Main(id.ToString());
            mainPage.Show();
            this.Visible = false;
        }
    }
}
