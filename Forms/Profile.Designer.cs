
namespace CSE412_FinalGroupProject
{
    partial class Profile
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
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.hometownLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.createAlbum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.myAlbumsButton = new System.Windows.Forms.Button();
            this.userActivityButton = new System.Windows.Forms.Button();
            this.userDatabase = new CSE412_FinalGroupProject.userDatabase();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.AlbumsTableAdapter();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photosTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.PhotosTableAdapter();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagsTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TagsTableAdapter();
            this.tagButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(19, 236);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hometown:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Birthday:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Profile";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(223, 51);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(35, 13);
            this.fnameLabel.TabIndex = 7;
            this.fnameLabel.Text = "label7";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(86, 51);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(35, 13);
            this.lnameLabel.TabIndex = 8;
            this.lnameLabel.Text = "label8";
            // 
            // hometownLabel
            // 
            this.hometownLabel.AutoSize = true;
            this.hometownLabel.Location = new System.Drawing.Point(85, 84);
            this.hometownLabel.Name = "hometownLabel";
            this.hometownLabel.Size = new System.Drawing.Size(35, 13);
            this.hometownLabel.TabIndex = 9;
            this.hometownLabel.Text = "label9";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(223, 84);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(41, 13);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "label10";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(85, 118);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(41, 13);
            this.birthdayLabel.TabIndex = 11;
            this.birthdayLabel.Text = "label11";
            // 
            // createAlbum
            // 
            this.createAlbum.Location = new System.Drawing.Point(156, 158);
            this.createAlbum.Name = "createAlbum";
            this.createAlbum.Size = new System.Drawing.Size(107, 23);
            this.createAlbum.TabIndex = 12;
            this.createAlbum.Text = "Create Album";
            this.createAlbum.UseVisualStyleBackColor = true;
            this.createAlbum.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(223, 118);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "label8";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(18, 158);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(107, 23);
            this.changePasswordButton.TabIndex = 15;
            this.changePasswordButton.Text = "Upload Photo";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // myAlbumsButton
            // 
            this.myAlbumsButton.Location = new System.Drawing.Point(156, 197);
            this.myAlbumsButton.Name = "myAlbumsButton";
            this.myAlbumsButton.Size = new System.Drawing.Size(107, 23);
            this.myAlbumsButton.TabIndex = 16;
            this.myAlbumsButton.Text = "View My Albums";
            this.myAlbumsButton.UseVisualStyleBackColor = true;
            this.myAlbumsButton.Click += new System.EventHandler(this.myAlbumsButton_Click);
            // 
            // userActivityButton
            // 
            this.userActivityButton.Location = new System.Drawing.Point(19, 197);
            this.userActivityButton.Name = "userActivityButton";
            this.userActivityButton.Size = new System.Drawing.Size(107, 23);
            this.userActivityButton.TabIndex = 18;
            this.userActivityButton.Text = "View User Activity";
            this.userActivityButton.UseVisualStyleBackColor = true;
            this.userActivityButton.Click += new System.EventHandler(this.userActivityButton_Click);
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
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.userDatabase;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.userDatabase;
            // 
            // photosTableAdapter
            // 
            this.photosTableAdapter.ClearBeforeFill = true;
            // 
            // tagsBindingSource
            // 
            this.tagsBindingSource.DataMember = "Tags";
            this.tagsBindingSource.DataSource = this.userDatabase;
            // 
            // tagsTableAdapter
            // 
            this.tagsTableAdapter.ClearBeforeFill = true;
            // 
            // tagButton
            // 
            this.tagButton.Location = new System.Drawing.Point(156, 236);
            this.tagButton.Name = "tagButton";
            this.tagButton.Size = new System.Drawing.Size(107, 23);
            this.tagButton.TabIndex = 19;
            this.tagButton.Text = "View Popular Tags";
            this.tagButton.UseVisualStyleBackColor = true;
            this.tagButton.Visible = false;
            this.tagButton.Click += new System.EventHandler(this.tagButton_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 277);
            this.Controls.Add(this.tagButton);
            this.Controls.Add(this.userActivityButton);
            this.Controls.Add(this.myAlbumsButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.createAlbum);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.hometownLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userDatabase userDatabase;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private userDatabaseTableAdapters.UsersTableAdapter usersTableAdapter;
        private userDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label hometownLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Button createAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button myAlbumsButton;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private userDatabaseTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private userDatabaseTableAdapters.PhotosTableAdapter photosTableAdapter;
        private System.Windows.Forms.Button userActivityButton;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private userDatabaseTableAdapters.TagsTableAdapter tagsTableAdapter;
        private System.Windows.Forms.Button tagButton;
    }
}