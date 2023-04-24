
namespace CSE412_FinalGroupProject
{
    partial class popularTags
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
            this.tagTextbox = new System.Windows.Forms.TextBox();
            this.userDatabase = new CSE412_FinalGroupProject.userDatabase();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagsTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TagsTableAdapter();
            this.tableAdapterManager = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 314);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popular Tags";
            // 
            // tagTextbox
            // 
            this.tagTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagTextbox.Location = new System.Drawing.Point(12, 54);
            this.tagTextbox.Multiline = true;
            this.tagTextbox.Name = "tagTextbox";
            this.tagTextbox.ReadOnly = true;
            this.tagTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagTextbox.Size = new System.Drawing.Size(215, 254);
            this.tagTextbox.TabIndex = 2;
            // 
            // userDatabase
            // 
            this.userDatabase.DataSetName = "userDatabase";
            this.userDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CommentsTableAdapter = null;
            this.tableAdapterManager.FriendsTableAdapter = null;
            this.tableAdapterManager.LikesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.TagsTableAdapter = this.tagsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // popularTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 343);
            this.Controls.Add(this.tagTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "popularTags";
            this.Text = "popularTags";
            this.Load += new System.EventHandler(this.popularTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagTextbox;
        private userDatabase userDatabase;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private userDatabaseTableAdapters.TagsTableAdapter tagsTableAdapter;
        private userDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
    }
}