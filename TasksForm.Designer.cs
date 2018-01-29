namespace Code_AcademyForm
{
    partial class TasksForm
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
            this.tasks_information = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.task_end_date = new System.Windows.Forms.DateTimePicker();
            this.task_start_date = new System.Windows.Forms.DateTimePicker();
            this.task_note = new System.Windows.Forms.TextBox();
            this.task_source = new System.Windows.Forms.TextBox();
            this.save_tasks = new System.Windows.Forms.Button();
            this.task_type_cmb = new System.Windows.Forms.ComboBox();
            this.task_point = new System.Windows.Forms.TextBox();
            this.task_student = new System.Windows.Forms.TextBox();
            this.task_group = new System.Windows.Forms.TextBox();
            this.tasks_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasks_information
            // 
            this.tasks_information.Controls.Add(this.task_group);
            this.tasks_information.Controls.Add(this.task_student);
            this.tasks_information.Controls.Add(this.task_point);
            this.tasks_information.Controls.Add(this.task_type_cmb);
            this.tasks_information.Controls.Add(this.task_source);
            this.tasks_information.Controls.Add(this.task_note);
            this.tasks_information.Controls.Add(this.task_start_date);
            this.tasks_information.Controls.Add(this.task_end_date);
            this.tasks_information.Controls.Add(this.label8);
            this.tasks_information.Controls.Add(this.label7);
            this.tasks_information.Controls.Add(this.label6);
            this.tasks_information.Controls.Add(this.label5);
            this.tasks_information.Controls.Add(this.label4);
            this.tasks_information.Controls.Add(this.label3);
            this.tasks_information.Controls.Add(this.label9);
            this.tasks_information.Controls.Add(this.label1);
            this.tasks_information.Location = new System.Drawing.Point(40, 29);
            this.tasks_information.Name = "tasks_information";
            this.tasks_information.Size = new System.Drawing.Size(405, 346);
            this.tasks_information.TabIndex = 0;
            this.tasks_information.TabStop = false;
            this.tasks_information.Text = "Tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Note :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Task Student:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Task Point:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Task Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Task Source:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Task Start Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Task End Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Task Group:";
            // 
            // task_end_date
            // 
            this.task_end_date.Location = new System.Drawing.Point(123, 305);
            this.task_end_date.Name = "task_end_date";
            this.task_end_date.Size = new System.Drawing.Size(200, 20);
            this.task_end_date.TabIndex = 3;
            // 
            // task_start_date
            // 
            this.task_start_date.Location = new System.Drawing.Point(123, 276);
            this.task_start_date.Name = "task_start_date";
            this.task_start_date.Size = new System.Drawing.Size(200, 20);
            this.task_start_date.TabIndex = 3;
            // 
            // task_note
            // 
            this.task_note.Location = new System.Drawing.Point(123, 187);
            this.task_note.Multiline = true;
            this.task_note.Name = "task_note";
            this.task_note.Size = new System.Drawing.Size(158, 79);
            this.task_note.TabIndex = 4;
            // 
            // task_source
            // 
            this.task_source.Location = new System.Drawing.Point(123, 155);
            this.task_source.Name = "task_source";
            this.task_source.Size = new System.Drawing.Size(200, 20);
            this.task_source.TabIndex = 5;
            // 
            // save_tasks
            // 
            this.save_tasks.Location = new System.Drawing.Point(462, 337);
            this.save_tasks.Name = "save_tasks";
            this.save_tasks.Size = new System.Drawing.Size(75, 32);
            this.save_tasks.TabIndex = 1;
            this.save_tasks.Text = "Save";
            this.save_tasks.UseVisualStyleBackColor = true;
            // 
            // task_type_cmb
            // 
            this.task_type_cmb.FormattingEnabled = true;
            this.task_type_cmb.Location = new System.Drawing.Point(123, 126);
            this.task_type_cmb.Name = "task_type_cmb";
            this.task_type_cmb.Size = new System.Drawing.Size(121, 21);
            this.task_type_cmb.TabIndex = 6;
            // 
            // task_point
            // 
            this.task_point.Location = new System.Drawing.Point(123, 93);
            this.task_point.Name = "task_point";
            this.task_point.Size = new System.Drawing.Size(89, 20);
            this.task_point.TabIndex = 7;
            // 
            // task_student
            // 
            this.task_student.Location = new System.Drawing.Point(123, 65);
            this.task_student.Name = "task_student";
            this.task_student.Size = new System.Drawing.Size(200, 20);
            this.task_student.TabIndex = 8;
            // 
            // task_group
            // 
            this.task_group.Location = new System.Drawing.Point(123, 34);
            this.task_group.Name = "task_group";
            this.task_group.Size = new System.Drawing.Size(100, 20);
            this.task_group.TabIndex = 9;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 398);
            this.Controls.Add(this.save_tasks);
            this.Controls.Add(this.tasks_information);
            this.Name = "TasksForm";
            this.Text = "TasksForm";
            this.tasks_information.ResumeLayout(false);
            this.tasks_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tasks_information;
        private System.Windows.Forms.TextBox task_source;
        private System.Windows.Forms.TextBox task_note;
        private System.Windows.Forms.DateTimePicker task_start_date;
        private System.Windows.Forms.DateTimePicker task_end_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_tasks;
        private System.Windows.Forms.TextBox task_group;
        private System.Windows.Forms.TextBox task_student;
        private System.Windows.Forms.TextBox task_point;
        private System.Windows.Forms.ComboBox task_type_cmb;
    }
}