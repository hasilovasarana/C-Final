namespace Code_AcademyForm
{
    partial class AcademyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademyForm));
            this.go_to_students = new System.Windows.Forms.Button();
            this.go_to_teachers = new System.Windows.Forms.Button();
            this.go_to_mentors = new System.Windows.Forms.Button();
            this.go_to_groups = new System.Windows.Forms.Button();
            this.go_to_group_types = new System.Windows.Forms.Button();
            this.go_to_group_schedule = new System.Windows.Forms.Button();
            this.go_to_tasks = new System.Windows.Forms.Button();
            this.go_to_task_types = new System.Windows.Forms.Button();
            this.go_to_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go_to_students
            // 
            this.go_to_students.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.go_to_students.Location = new System.Drawing.Point(56, 439);
            this.go_to_students.Name = "go_to_students";
            this.go_to_students.Size = new System.Drawing.Size(161, 37);
            this.go_to_students.TabIndex = 1;
            this.go_to_students.Text = "Students";
            this.go_to_students.UseVisualStyleBackColor = false;
            this.go_to_students.Click += new System.EventHandler(this.go_to_students_Click);
            // 
            // go_to_teachers
            // 
            this.go_to_teachers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.go_to_teachers.Location = new System.Drawing.Point(56, 331);
            this.go_to_teachers.Name = "go_to_teachers";
            this.go_to_teachers.Size = new System.Drawing.Size(161, 37);
            this.go_to_teachers.TabIndex = 1;
            this.go_to_teachers.Text = "Teachers";
            this.go_to_teachers.UseVisualStyleBackColor = false;
            this.go_to_teachers.Click += new System.EventHandler(this.go_to_teachers_Click);
            // 
            // go_to_mentors
            // 
            this.go_to_mentors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.go_to_mentors.Location = new System.Drawing.Point(56, 384);
            this.go_to_mentors.Name = "go_to_mentors";
            this.go_to_mentors.Size = new System.Drawing.Size(161, 37);
            this.go_to_mentors.TabIndex = 1;
            this.go_to_mentors.Text = "Mentors";
            this.go_to_mentors.UseVisualStyleBackColor = false;
            this.go_to_mentors.Click += new System.EventHandler(this.go_to_mentors_Click);
            // 
            // go_to_groups
            // 
            this.go_to_groups.Location = new System.Drawing.Point(242, 331);
            this.go_to_groups.Name = "go_to_groups";
            this.go_to_groups.Size = new System.Drawing.Size(161, 37);
            this.go_to_groups.TabIndex = 2;
            this.go_to_groups.Text = "Groups";
            this.go_to_groups.UseVisualStyleBackColor = true;
            this.go_to_groups.Click += new System.EventHandler(this.go_to_groups_Click);
            // 
            // go_to_group_types
            // 
            this.go_to_group_types.Location = new System.Drawing.Point(242, 384);
            this.go_to_group_types.Name = "go_to_group_types";
            this.go_to_group_types.Size = new System.Drawing.Size(161, 37);
            this.go_to_group_types.TabIndex = 3;
            this.go_to_group_types.Text = "Group Types";
            this.go_to_group_types.UseVisualStyleBackColor = true;
            this.go_to_group_types.Click += new System.EventHandler(this.go_to_group_types_Click);
            // 
            // go_to_group_schedule
            // 
            this.go_to_group_schedule.Location = new System.Drawing.Point(245, 439);
            this.go_to_group_schedule.Name = "go_to_group_schedule";
            this.go_to_group_schedule.Size = new System.Drawing.Size(158, 37);
            this.go_to_group_schedule.TabIndex = 4;
            this.go_to_group_schedule.Text = "Group Schedule";
            this.go_to_group_schedule.UseVisualStyleBackColor = true;
            this.go_to_group_schedule.Click += new System.EventHandler(this.go_to_group_schedule_Click);
            // 
            // go_to_tasks
            // 
            this.go_to_tasks.Location = new System.Drawing.Point(435, 331);
            this.go_to_tasks.Name = "go_to_tasks";
            this.go_to_tasks.Size = new System.Drawing.Size(152, 37);
            this.go_to_tasks.TabIndex = 5;
            this.go_to_tasks.Text = "Tasks";
            this.go_to_tasks.UseVisualStyleBackColor = true;
            this.go_to_tasks.Click += new System.EventHandler(this.go_to_tasks_Click);
            // 
            // go_to_task_types
            // 
            this.go_to_task_types.Location = new System.Drawing.Point(435, 384);
            this.go_to_task_types.Name = "go_to_task_types";
            this.go_to_task_types.Size = new System.Drawing.Size(152, 37);
            this.go_to_task_types.TabIndex = 6;
            this.go_to_task_types.Text = "Task Types";
            this.go_to_task_types.UseVisualStyleBackColor = true;
            this.go_to_task_types.Click += new System.EventHandler(this.go_to_task_types_Click);
            // 
            // go_to_settings
            // 
            this.go_to_settings.Location = new System.Drawing.Point(435, 439);
            this.go_to_settings.Name = "go_to_settings";
            this.go_to_settings.Size = new System.Drawing.Size(152, 37);
            this.go_to_settings.TabIndex = 7;
            this.go_to_settings.Text = "Settings";
            this.go_to_settings.UseVisualStyleBackColor = true;
            // 
            // AcademyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 508);
            this.Controls.Add(this.go_to_settings);
            this.Controls.Add(this.go_to_task_types);
            this.Controls.Add(this.go_to_tasks);
            this.Controls.Add(this.go_to_group_schedule);
            this.Controls.Add(this.go_to_group_types);
            this.Controls.Add(this.go_to_groups);
            this.Controls.Add(this.go_to_mentors);
            this.Controls.Add(this.go_to_teachers);
            this.Controls.Add(this.go_to_students);
            this.DoubleBuffered = true;
            this.Name = "AcademyForm";
            this.Text = "AcademyForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button go_to_students;
        private System.Windows.Forms.Button go_to_teachers;
        private System.Windows.Forms.Button go_to_mentors;
        private System.Windows.Forms.Button go_to_groups;
        private System.Windows.Forms.Button go_to_group_types;
        private System.Windows.Forms.Button go_to_group_schedule;
        private System.Windows.Forms.Button go_to_tasks;
        private System.Windows.Forms.Button go_to_task_types;
        private System.Windows.Forms.Button go_to_settings;
    }
}