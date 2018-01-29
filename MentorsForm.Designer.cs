namespace Code_AcademyForm
{
    partial class MentorsForm
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
            this.mentor_Information = new System.Windows.Forms.GroupBox();
            this.mentor_gender_cmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mentor_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mentor_info = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mentor_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mentor_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mentor_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mentor_picture = new System.Windows.Forms.PictureBox();
            this.save_mentor = new System.Windows.Forms.Button();
            this.show_mentor_data = new System.Windows.Forms.Button();
            this.go_update_mentor = new System.Windows.Forms.Button();
            this.mentor_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mentor_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // mentor_Information
            // 
            this.mentor_Information.Controls.Add(this.mentor_gender_cmb);
            this.mentor_Information.Controls.Add(this.label6);
            this.mentor_Information.Controls.Add(this.mentor_password);
            this.mentor_Information.Controls.Add(this.label5);
            this.mentor_Information.Controls.Add(this.mentor_info);
            this.mentor_Information.Controls.Add(this.label4);
            this.mentor_Information.Controls.Add(this.mentor_email);
            this.mentor_Information.Controls.Add(this.label3);
            this.mentor_Information.Controls.Add(this.mentor_surname);
            this.mentor_Information.Controls.Add(this.label2);
            this.mentor_Information.Controls.Add(this.mentor_name);
            this.mentor_Information.Controls.Add(this.label1);
            this.mentor_Information.Location = new System.Drawing.Point(27, 25);
            this.mentor_Information.Name = "mentor_Information";
            this.mentor_Information.Size = new System.Drawing.Size(388, 342);
            this.mentor_Information.TabIndex = 0;
            this.mentor_Information.TabStop = false;
            this.mentor_Information.Text = "Mentor Information";
            // 
            // mentor_gender_cmb
            // 
            this.mentor_gender_cmb.FormattingEnabled = true;
            this.mentor_gender_cmb.Location = new System.Drawing.Point(141, 299);
            this.mentor_gender_cmb.Name = "mentor_gender_cmb";
            this.mentor_gender_cmb.Size = new System.Drawing.Size(126, 21);
            this.mentor_gender_cmb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mentor Gender:";
            // 
            // mentor_password
            // 
            this.mentor_password.Location = new System.Drawing.Point(141, 167);
            this.mentor_password.Name = "mentor_password";
            this.mentor_password.Size = new System.Drawing.Size(126, 20);
            this.mentor_password.TabIndex = 1;
            this.mentor_password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mentor Password:";
            // 
            // mentor_info
            // 
            this.mentor_info.Location = new System.Drawing.Point(141, 209);
            this.mentor_info.Multiline = true;
            this.mentor_info.Name = "mentor_info";
            this.mentor_info.Size = new System.Drawing.Size(126, 78);
            this.mentor_info.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mentor Info:";
            // 
            // mentor_email
            // 
            this.mentor_email.Location = new System.Drawing.Point(141, 127);
            this.mentor_email.Name = "mentor_email";
            this.mentor_email.Size = new System.Drawing.Size(126, 20);
            this.mentor_email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mentor Email:";
            // 
            // mentor_surname
            // 
            this.mentor_surname.Location = new System.Drawing.Point(141, 89);
            this.mentor_surname.Name = "mentor_surname";
            this.mentor_surname.Size = new System.Drawing.Size(126, 20);
            this.mentor_surname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mentor Surname:";
            // 
            // mentor_name
            // 
            this.mentor_name.Location = new System.Drawing.Point(141, 54);
            this.mentor_name.Name = "mentor_name";
            this.mentor_name.Size = new System.Drawing.Size(126, 20);
            this.mentor_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mentor Name:";
            // 
            // mentor_picture
            // 
            this.mentor_picture.Location = new System.Drawing.Point(421, 31);
            this.mentor_picture.Name = "mentor_picture";
            this.mentor_picture.Size = new System.Drawing.Size(122, 110);
            this.mentor_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mentor_picture.TabIndex = 1;
            this.mentor_picture.TabStop = false;
            // 
            // save_mentor
            // 
            this.save_mentor.Location = new System.Drawing.Point(421, 169);
            this.save_mentor.Name = "save_mentor";
            this.save_mentor.Size = new System.Drawing.Size(122, 58);
            this.save_mentor.TabIndex = 3;
            this.save_mentor.Text = "Save";
            this.save_mentor.UseVisualStyleBackColor = true;
            this.save_mentor.Click += new System.EventHandler(this.save_mentor_Click);
            // 
            // show_mentor_data
            // 
            this.show_mentor_data.Location = new System.Drawing.Point(421, 238);
            this.show_mentor_data.Name = "show_mentor_data";
            this.show_mentor_data.Size = new System.Drawing.Size(122, 57);
            this.show_mentor_data.TabIndex = 4;
            this.show_mentor_data.Text = "Show MentorData";
            this.show_mentor_data.UseVisualStyleBackColor = true;
            this.show_mentor_data.Click += new System.EventHandler(this.show_mentor_data_Click);
            // 
            // go_update_mentor
            // 
            this.go_update_mentor.Location = new System.Drawing.Point(421, 310);
            this.go_update_mentor.Name = "go_update_mentor";
            this.go_update_mentor.Size = new System.Drawing.Size(122, 57);
            this.go_update_mentor.TabIndex = 5;
            this.go_update_mentor.Text = "Update";
            this.go_update_mentor.UseVisualStyleBackColor = true;
            this.go_update_mentor.Click += new System.EventHandler(this.go_update_mentor_Click);
            // 
            // MentorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 391);
            this.Controls.Add(this.go_update_mentor);
            this.Controls.Add(this.show_mentor_data);
            this.Controls.Add(this.save_mentor);
            this.Controls.Add(this.mentor_picture);
            this.Controls.Add(this.mentor_Information);
            this.Name = "MentorsForm";
            this.Text = "MentorsForm";
            this.mentor_Information.ResumeLayout(false);
            this.mentor_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mentor_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mentor_Information;
        private System.Windows.Forms.PictureBox mentor_picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mentor_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mentor_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mentor_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mentor_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mentor_name;
        private System.Windows.Forms.Button save_mentor;
        private System.Windows.Forms.ComboBox mentor_gender_cmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button show_mentor_data;
        private System.Windows.Forms.Button go_update_mentor;
    }
}