
namespace CSE412_FinalGroupProject
{
    partial class addFriend
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
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.addFriendButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.userDatabase = new CSE412_FinalGroupProject.userDatabase();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager();
            this.friendsTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.FriendsTableAdapter();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recommendFriends = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 122);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email: ";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(56, 61);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(193, 20);
            this.emailTextbox.TabIndex = 2;
            // 
            // addFriendButton
            // 
            this.addFriendButton.Location = new System.Drawing.Point(93, 122);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(75, 23);
            this.addFriendButton.TabIndex = 3;
            this.addFriendButton.Text = "Add";
            this.addFriendButton.UseVisualStyleBackColor = true;
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edit Friends";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(174, 122);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
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
            this.tableAdapterManager.FriendsTableAdapter = this.friendsTableAdapter;
            this.tableAdapterManager.LikesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.TagsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // friendsTableAdapter
            // 
            this.friendsTableAdapter.ClearBeforeFill = true;
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataMember = "Friends";
            this.friendsBindingSource.DataSource = this.userDatabase;
            // 
            // recommendFriends
            // 
            this.recommendFriends.Location = new System.Drawing.Point(56, 151);
            this.recommendFriends.Name = "recommendFriends";
            this.recommendFriends.Size = new System.Drawing.Size(156, 23);
            this.recommendFriends.TabIndex = 6;
            this.recommendFriends.Text = "View Recommended Friends";
            this.recommendFriends.UseVisualStyleBackColor = true;
            this.recommendFriends.Click += new System.EventHandler(this.recommendFriends_Click);
            // 
            // addFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 188);
            this.Controls.Add(this.recommendFriends);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addFriendButton);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "addFriend";
            this.Text = "addFriend";
            this.Load += new System.EventHandler(this.addFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Button addFriendButton;
        private System.Windows.Forms.Label label2;
        private userDatabase userDatabase;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private userDatabaseTableAdapters.UsersTableAdapter usersTableAdapter;
        private userDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private userDatabaseTableAdapters.FriendsTableAdapter friendsTableAdapter;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button recommendFriends;
    }
}