namespace Code_AcademyForm
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.admin_entry = new System.Windows.Forms.GroupBox();
            this.login = new System.Windows.Forms.Button();
            this.admin_photo = new System.Windows.Forms.PictureBox();
            this.admin_entry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(152, 74);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(236, 20);
            this.username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(152, 118);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(236, 20);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // admin_entry
            // 
            this.admin_entry.Controls.Add(this.login);
            this.admin_entry.Controls.Add(this.admin_photo);
            this.admin_entry.Controls.Add(this.username);
            this.admin_entry.Controls.Add(this.password);
            this.admin_entry.Controls.Add(this.label1);
            this.admin_entry.Controls.Add(this.label2);
            this.admin_entry.Location = new System.Drawing.Point(39, 35);
            this.admin_entry.Name = "admin_entry";
            this.admin_entry.Size = new System.Drawing.Size(540, 274);
            this.admin_entry.TabIndex = 2;
            this.admin_entry.TabStop = false;
            this.admin_entry.Text = "Admin_Entry";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(313, 169);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // admin_photo
            // 
            this.admin_photo.Image = ((System.Drawing.Image)(resources.GetObject("admin_photo.Image")));
            this.admin_photo.Location = new System.Drawing.Point(406, 30);
            this.admin_photo.Name = "admin_photo";
            this.admin_photo.Size = new System.Drawing.Size(106, 108);
            this.admin_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_photo.TabIndex = 3;
            this.admin_photo.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 400);
            this.Controls.Add(this.admin_entry);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.admin_entry.ResumeLayout(false);
            this.admin_entry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.GroupBox admin_entry;
        private System.Windows.Forms.PictureBox admin_photo;
        private System.Windows.Forms.Button login;
    }
}