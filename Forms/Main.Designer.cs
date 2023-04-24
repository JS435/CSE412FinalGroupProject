
namespace CSE412_FinalGroupProject
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.likeLabel = new System.Windows.Forms.Label();
            this.commentTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.captionLabel = new System.Windows.Forms.Label();
            this.tagLabel = new System.Windows.Forms.Label();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.viewFriendsButton = new System.Windows.Forms.Button();
            this.commentButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userDatabase = new CSE412_FinalGroupProject.userDatabase();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.CommentsTableAdapter();
            this.likesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.likesTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.LikesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(248, 42);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome User: ";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(222, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(13, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "[]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Likes:";
            // 
            // likeLabel
            // 
            this.likeLabel.AutoSize = true;
            this.likeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeLabel.Location = new System.Drawing.Point(290, 282);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(23, 25);
            this.likeLabel.TabIndex = 11;
            this.likeLabel.Text = "0";
            // 
            // commentTextbox
            // 
            this.commentTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentTextbox.Location = new System.Drawing.Point(45, 398);
            this.commentTextbox.Multiline = true;
            this.commentTextbox.Name = "commentTextbox";
            this.commentTextbox.ReadOnly = true;
            this.commentTextbox.Size = new System.Drawing.Size(281, 180);
            this.commentTextbox.TabIndex = 14;
            this.commentTextbox.Text = "User1: Thats Sick!\r\nUser4: Wish I had that kind of car\r\nUser7: Dream car right th" +
    "ere\r\n";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(42, 324);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(89, 13);
            this.usernameLabel.TabIndex = 15;
            this.usernameLabel.Text = "epic_cool_guy";
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Location = new System.Drawing.Point(42, 347);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(46, 13);
            this.captionLabel.TabIndex = 17;
            this.captionLabel.Text = "Cool car";
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Location = new System.Drawing.Point(42, 371);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(61, 13);
            this.tagLabel.TabIndex = 18;
            this.tagLabel.Text = "#Car #Epic";
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.Location = new System.Drawing.Point(42, 42);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(75, 23);
            this.viewProfileButton.TabIndex = 19;
            this.viewProfileButton.Text = "View Profile";
            this.viewProfileButton.UseVisualStyleBackColor = true;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // viewFriendsButton
            // 
            this.viewFriendsButton.Location = new System.Drawing.Point(123, 42);
            this.viewFriendsButton.Name = "viewFriendsButton";
            this.viewFriendsButton.Size = new System.Drawing.Size(119, 23);
            this.viewFriendsButton.TabIndex = 20;
            this.viewFriendsButton.Text = "View Friends";
            this.viewFriendsButton.UseVisualStyleBackColor = true;
            this.viewFriendsButton.Click += new System.EventHandler(this.viewFriendsButton_Click);
            // 
            // commentButton
            // 
            this.commentButton.BackgroundImage = global::CSE412_FinalGroupProject.Properties.Resources.instaComment;
            this.commentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commentButton.Location = new System.Drawing.Point(83, 273);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(35, 34);
            this.commentButton.TabIndex = 16;
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.BackgroundImage = global::CSE412_FinalGroupProject.Properties.Resources.instaLike;
            this.likeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likeButton.Location = new System.Drawing.Point(42, 273);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(35, 34);
            this.likeButton.TabIndex = 9;
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::CSE412_FinalGroupProject.Properties.Resources.car;
            this.pictureBox5.Location = new System.Drawing.Point(42, 71);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(281, 196);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(42, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(281, 196);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(42, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 196);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userDatabase
            // 
            this.userDatabase.DataSetName = "userDatabase";
            this.userDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.userDatabase;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CommentsTableAdapter = null;
            this.tableAdapterManager.FriendsTableAdapter = null;
            this.tableAdapterManager.LikesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.TagsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlbumsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CommentsTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.FriendsTableAdapter = null;
            this.tableAdapterManager1.LikesTableAdapter = null;
            this.tableAdapterManager1.PhotosTableAdapter = null;
            this.tableAdapterManager1.TagsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.userDatabase;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // likesBindingSource
            // 
            this.likesBindingSource.DataMember = "Likes";
            this.likesBindingSource.DataSource = this.userDatabase;
            // 
            // likesTableAdapter
            // 
            this.likesTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 599);
            this.Controls.Add(this.viewFriendsButton);
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.tagLabel);
            this.Controls.Add(this.captionLabel);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.commentTextbox);
            this.Controls.Add(this.likeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutButton);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private userDatabase userDatabase;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private userDatabaseTableAdapters.UsersTableAdapter usersTableAdapter;
        private userDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label likeLabel;
        private System.Windows.Forms.TextBox commentTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Label tagLabel;
        private userDatabaseTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button viewProfileButton;
        private System.Windows.Forms.Button viewFriendsButton;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private userDatabaseTableAdapters.CommentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.BindingSource likesBindingSource;
        private userDatabaseTableAdapters.LikesTableAdapter likesTableAdapter;
    }
}