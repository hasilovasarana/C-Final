namespace Code_AcademyForm
{
    partial class TeacherAcces
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
            this.show_students = new System.Windows.Forms.Button();
            this.show_tasks = new System.Windows.Forms.Button();
            this.show_mentor = new System.Windows.Forms.Button();
            this.show_task_types = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // show_students
            // 
            this.show_students.Location = new System.Drawing.Point(3, 3);
            this.show_students.Name = "show_students";
            this.show_students.Size = new System.Drawing.Size(140, 89);
            this.show_students.TabIndex = 0;
            this.show_students.Text = "Students";
            this.show_students.UseVisualStyleBackColor = true;
            this.show_students.Click += new System.EventHandler(this.show_students_Click);
            // 
            // show_tasks
            // 
            this.show_tasks.Location = new System.Drawing.Point(3, 98);
            this.show_tasks.Name = "show_tasks";
            this.show_tasks.Size = new System.Drawing.Size(140, 90);
            this.show_tasks.TabIndex = 0;
            this.show_tasks.Text = "Tasks";
            this.show_tasks.UseVisualStyleBackColor = true;
            // 
            // show_mentor
            // 
            this.show_mentor.Location = new System.Drawing.Point(149, 3);
            this.show_mentor.Name = "show_mentor";
            this.show_mentor.Size = new System.Drawing.Size(140, 89);
            this.show_mentor.TabIndex = 0;
            this.show_mentor.Text = "Mentor";
            this.show_mentor.UseVisualStyleBackColor = true;
            // 
            // show_task_types
            // 
            this.show_task_types.Location = new System.Drawing.Point(149, 98);
            this.show_task_types.Name = "show_task_types";
            this.show_task_types.Size = new System.Drawing.Size(140, 90);
            this.show_task_types.TabIndex = 0;
            this.show_task_types.Text = "Task Types";
            this.show_task_types.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.show_students, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.show_task_types, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.show_mentor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.show_tasks, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(130, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 191);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TeacherAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TeacherAcces";
            this.Text = "TeacherAcces";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_students;
        private System.Windows.Forms.Button show_tasks;
        private System.Windows.Forms.Button show_mentor;
        private System.Windows.Forms.Button show_task_types;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}