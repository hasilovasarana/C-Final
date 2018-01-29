namespace Code_AcademyForm
{
    partial class TeachersForm
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
            this.teacher_information = new System.Windows.Forms.GroupBox();
            this.teacher_gender_cmb = new System.Windows.Forms.ComboBox();
            this.teacher_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacher_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_picture = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.show_teacher = new System.Windows.Forms.Button();
            this.update_teacher = new System.Windows.Forms.Button();
            this.teacher_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_information
            // 
            this.teacher_information.Controls.Add(this.teacher_gender_cmb);
            this.teacher_information.Controls.Add(this.teacher_password);
            this.teacher_information.Controls.Add(this.label6);
            this.teacher_information.Controls.Add(this.label5);
            this.teacher_information.Controls.Add(this.teacher_phone);
            this.teacher_information.Controls.Add(this.label4);
            this.teacher_information.Controls.Add(this.teacher_email);
            this.teacher_information.Controls.Add(this.label3);
            this.teacher_information.Controls.Add(this.teacher_surname);
            this.teacher_information.Controls.Add(this.label2);
            this.teacher_information.Controls.Add(this.teacher_name);
            this.teacher_information.Controls.Add(this.label1);
            this.teacher_information.Location = new System.Drawing.Point(31, 38);
            this.teacher_information.Name = "teacher_information";
            this.teacher_information.Size = new System.Drawing.Size(408, 353);
            this.teacher_information.TabIndex = 0;
            this.teacher_information.TabStop = false;
            this.teacher_information.Text = "Teacher Information";
            // 
            // teacher_gender_cmb
            // 
            this.teacher_gender_cmb.FormattingEnabled = true;
            this.teacher_gender_cmb.Location = new System.Drawing.Point(142, 130);
            this.teacher_gender_cmb.Name = "teacher_gender_cmb";
            this.teacher_gender_cmb.Size = new System.Drawing.Size(95, 21);
            this.teacher_gender_cmb.TabIndex = 2;
            // 
            // teacher_password
            // 
            this.teacher_password.Location = new System.Drawing.Point(142, 239);
            this.teacher_password.Name = "teacher_password";
            this.teacher_password.Size = new System.Drawing.Size(162, 20);
            this.teacher_password.TabIndex = 1;
            this.teacher_password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Teacher Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Teacher Gender:";
            // 
            // teacher_phone
            // 
            this.teacher_phone.Location = new System.Drawing.Point(142, 164);
            this.teacher_phone.Name = "teacher_phone";
            this.teacher_phone.Size = new System.Drawing.Size(162, 20);
            this.teacher_phone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teacher Phone:";
            // 
            // teacher_email
            // 
            this.teacher_email.Location = new System.Drawing.Point(142, 200);
            this.teacher_email.Name = "teacher_email";
            this.teacher_email.Size = new System.Drawing.Size(162, 20);
            this.teacher_email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher Email:";
            // 
            // teacher_surname
            // 
            this.teacher_surname.Location = new System.Drawing.Point(142, 91);
            this.teacher_surname.Name = "teacher_surname";
            this.teacher_surname.Size = new System.Drawing.Size(162, 20);
            this.teacher_surname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher Surname:";
            // 
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(142, 55);
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(162, 20);
            this.teacher_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Name:";
            // 
            // teacher_picture
            // 
            this.teacher_picture.Location = new System.Drawing.Point(462, 46);
            this.teacher_picture.Name = "teacher_picture";
            this.teacher_picture.Size = new System.Drawing.Size(119, 88);
            this.teacher_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacher_picture.TabIndex = 1;
            this.teacher_picture.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(462, 153);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 65);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // show_teacher
            // 
            this.show_teacher.Location = new System.Drawing.Point(462, 238);
            this.show_teacher.Name = "show_teacher";
            this.show_teacher.Size = new System.Drawing.Size(119, 70);
            this.show_teacher.TabIndex = 3;
            this.show_teacher.Text = "Show Teacher Data";
            this.show_teacher.UseVisualStyleBackColor = true;
            this.show_teacher.Click += new System.EventHandler(this.show_teacher_Click);
            // 
            // update_teacher
            // 
            this.update_teacher.Location = new System.Drawing.Point(462, 326);
            this.update_teacher.Name = "update_teacher";
            this.update_teacher.Size = new System.Drawing.Size(119, 65);
            this.update_teacher.TabIndex = 4;
            this.update_teacher.Text = "Upadate";
            this.update_teacher.UseVisualStyleBackColor = true;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 441);
            this.Controls.Add(this.update_teacher);
            this.Controls.Add(this.show_teacher);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.teacher_picture);
            this.Controls.Add(this.teacher_information);
            this.Name = "TeachersForm";
            this.Text = "TeacherForm";
            this.teacher_information.ResumeLayout(false);
            this.teacher_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox teacher_information;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher_gender_cmb;
        private System.Windows.Forms.TextBox teacher_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teacher_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox teacher_picture;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button show_teacher;
        private System.Windows.Forms.Button update_teacher;
    }
}