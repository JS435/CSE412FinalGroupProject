
namespace CSE412_FinalGroupProject
{
    partial class Signup
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label hometownLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthdayLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDatabase = new CSE412_FinalGroupProject.userDatabase();
            this.usersTableAdapter = new CSE412_FinalGroupProject.userDatabaseTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CSE412_FinalGroupProject.userDatabaseTableAdapters.TableAdapterManager();
            this.hometownTextbox = new System.Windows.Forms.TextBox();
            this.lnameTextbox = new System.Windows.Forms.TextBox();
            this.fnameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.genderTextbox = new System.Windows.Forms.TextBox();
            this.birthdayTextbox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            hometownLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(14, 55);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(14, 81);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 21;
            passwordLabel.Text = "password:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(14, 107);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(52, 13);
            firstnameLabel.TabIndex = 23;
            firstnameLabel.Text = "firstname:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(14, 133);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(52, 13);
            lastnameLabel.TabIndex = 25;
            lastnameLabel.Text = "lastname:";
            // 
            // hometownLabel
            // 
            hometownLabel.AutoSize = true;
            hometownLabel.Location = new System.Drawing.Point(14, 159);
            hometownLabel.Name = "hometownLabel";
            hometownLabel.Size = new System.Drawing.Size(59, 13);
            hometownLabel.TabIndex = 27;
            hometownLabel.Text = "hometown:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(14, 185);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(43, 13);
            genderLabel.TabIndex = 29;
            genderLabel.Text = "gender:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(14, 211);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(47, 13);
            birthdayLabel.TabIndex = 31;
            birthdayLabel.Text = "birthday:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(17, 245);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(316, 23);
            this.createAccountButton.TabIndex = 8;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.userDatabase;
            // 
            // userDatabase
            // 
            this.userDatabase.DataSetName = "userDatabase";
            this.userDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // hometownTextbox
            // 
            this.hometownTextbox.Location = new System.Drawing.Point(79, 156);
            this.hometownTextbox.Name = "hometownTextbox";
            this.hometownTextbox.Size = new System.Drawing.Size(254, 20);
            this.hometownTextbox.TabIndex = 4;
            // 
            // lnameTextbox
            // 
            this.lnameTextbox.Location = new System.Drawing.Point(79, 130);
            this.lnameTextbox.Name = "lnameTextbox";
            this.lnameTextbox.Size = new System.Drawing.Size(254, 20);
            this.lnameTextbox.TabIndex = 3;
            // 
            // fnameTextbox
            // 
            this.fnameTextbox.Location = new System.Drawing.Point(79, 104);
            this.fnameTextbox.Name = "fnameTextbox";
            this.fnameTextbox.Size = new System.Drawing.Size(254, 20);
            this.fnameTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(79, 78);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(254, 20);
            this.passwordTextbox.TabIndex = 1;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(79, 52);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(254, 20);
            this.emailTextbox.TabIndex = 0;
            // 
            // genderTextbox
            // 
            this.genderTextbox.Location = new System.Drawing.Point(79, 182);
            this.genderTextbox.Name = "genderTextbox";
            this.genderTextbox.Size = new System.Drawing.Size(254, 20);
            this.genderTextbox.TabIndex = 5;
            // 
            // birthdayTextbox
            // 
            this.birthdayTextbox.Location = new System.Drawing.Point(79, 208);
            this.birthdayTextbox.Name = "birthdayTextbox";
            this.birthdayTextbox.Size = new System.Drawing.Size(254, 20);
            this.birthdayTextbox.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(17, 274);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 41;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 322);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.birthdayTextbox);
            this.Controls.Add(this.genderTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.fnameTextbox);
            this.Controls.Add(this.lnameTextbox);
            this.Controls.Add(this.hometownTextbox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(hometownLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createAccountButton;
        private userDatabase userDatabase;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private userDatabaseTableAdapters.UsersTableAdapter usersTableAdapter;
        private userDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox hometownTextbox;
        private System.Windows.Forms.TextBox lnameTextbox;
        private System.Windows.Forms.TextBox fnameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox genderTextbox;
        private System.Windows.Forms.TextBox birthdayTextbox;
        private System.Windows.Forms.Button backButton;
    }
}