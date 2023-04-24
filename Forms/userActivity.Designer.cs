
namespace CSE412_FinalGroupProject
{
    partial class userActivity
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
            this.label1 = new System.Windows.Forms.Label();
            this.activityTextbox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.userDatabase = new CSE412_FinalGroupProject.userDatabase();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Activity";
            // 
            // activityTextbox
            // 
            this.activityTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activityTextbox.Location = new System.Drawing.Point(12, 49);
            this.activityTextbox.Multiline = true;
            this.activityTextbox.Name = "activityTextbox";
            this.activityTextbox.ReadOnly = true;
            this.activityTextbox.Size = new System.Drawing.Size(235, 290);
            this.activityTextbox.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 345);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            // userActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 376);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.activityTextbox);
            this.Controls.Add(this.label1);
            this.Name = "userActivity";
            this.Text = "userActivity";
            this.Load += new System.EventHandler(this.userActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox activityTextbox;
        private System.Windows.Forms.Button backButton;
        private userDatabase userDatabase;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private userDatabaseTableAdapters.UsersTableAdapter usersTableAdapter;
        private userDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
    }
}