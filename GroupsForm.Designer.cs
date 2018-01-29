namespace Code_AcademyForm
{
    partial class GroupsForm
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
            this.group_information = new System.Windows.Forms.GroupBox();
            this.group_start_date = new System.Windows.Forms.DateTimePicker();
            this.group_mentor_cmb = new System.Windows.Forms.ComboBox();
            this.group_teacher_cmb = new System.Windows.Forms.ComboBox();
            this.group_type_cmb = new System.Windows.Forms.ComboBox();
            this.group_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_group = new System.Windows.Forms.Button();
            this.group_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_information
            // 
            this.group_information.Controls.Add(this.group_start_date);
            this.group_information.Controls.Add(this.group_mentor_cmb);
            this.group_information.Controls.Add(this.group_teacher_cmb);
            this.group_information.Controls.Add(this.group_type_cmb);
            this.group_information.Controls.Add(this.group_name);
            this.group_information.Controls.Add(this.label5);
            this.group_information.Controls.Add(this.label4);
            this.group_information.Controls.Add(this.label3);
            this.group_information.Controls.Add(this.label2);
            this.group_information.Controls.Add(this.label1);
            this.group_information.Location = new System.Drawing.Point(30, 30);
            this.group_information.Name = "group_information";
            this.group_information.Size = new System.Drawing.Size(394, 278);
            this.group_information.TabIndex = 0;
            this.group_information.TabStop = false;
            this.group_information.Text = "Group Information";
            // 
            // group_start_date
            // 
            this.group_start_date.Location = new System.Drawing.Point(147, 187);
            this.group_start_date.Name = "group_start_date";
            this.group_start_date.Size = new System.Drawing.Size(200, 20);
            this.group_start_date.TabIndex = 3;
            // 
            // group_mentor_cmb
            // 
            this.group_mentor_cmb.FormattingEnabled = true;
            this.group_mentor_cmb.Location = new System.Drawing.Point(147, 153);
            this.group_mentor_cmb.Name = "group_mentor_cmb";
            this.group_mentor_cmb.Size = new System.Drawing.Size(140, 21);
            this.group_mentor_cmb.TabIndex = 2;
            // 
            // group_teacher_cmb
            // 
            this.group_teacher_cmb.FormattingEnabled = true;
            this.group_teacher_cmb.Location = new System.Drawing.Point(147, 119);
            this.group_teacher_cmb.Name = "group_teacher_cmb";
            this.group_teacher_cmb.Size = new System.Drawing.Size(140, 21);
            this.group_teacher_cmb.TabIndex = 2;
            // 
            // group_type_cmb
            // 
            this.group_type_cmb.FormattingEnabled = true;
            this.group_type_cmb.Location = new System.Drawing.Point(147, 86);
            this.group_type_cmb.Name = "group_type_cmb";
            this.group_type_cmb.Size = new System.Drawing.Size(140, 21);
            this.group_type_cmb.TabIndex = 2;
            // 
            // group_name
            // 
            this.group_name.Location = new System.Drawing.Point(147, 52);
            this.group_name.Name = "group_name";
            this.group_name.Size = new System.Drawing.Size(91, 20);
            this.group_name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Group Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Group Mentor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Group Teacher:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Group Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name:";
            // 
            // save_group
            // 
            this.save_group.Location = new System.Drawing.Point(349, 344);
            this.save_group.Name = "save_group";
            this.save_group.Size = new System.Drawing.Size(75, 23);
            this.save_group.TabIndex = 1;
            this.save_group.Text = "Save";
            this.save_group.UseVisualStyleBackColor = true;
            this.save_group.Click += new System.EventHandler(this.save_group_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 379);
            this.Controls.Add(this.save_group);
            this.Controls.Add(this.group_information);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            this.group_information.ResumeLayout(false);
            this.group_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_information;
        private System.Windows.Forms.DateTimePicker group_start_date;
        private System.Windows.Forms.ComboBox group_mentor_cmb;
        private System.Windows.Forms.ComboBox group_teacher_cmb;
        private System.Windows.Forms.ComboBox group_type_cmb;
        private System.Windows.Forms.TextBox group_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_group;
    }
}