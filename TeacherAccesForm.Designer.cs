namespace Code_AcademyForm
{
    partial class TeacherAccesForm
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
            this.teacherDataGridview = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.show_mentor = new System.Windows.Forms.Button();
            this.show_task_types = new System.Windows.Forms.Button();
            this.show_tasks = new System.Windows.Forms.Button();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.show_students = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherDataGridview
            // 
            this.teacherDataGridview.AutoGenerateColumns = false;
            this.teacherDataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn});
            this.teacherDataGridview.DataSource = this.teacherBindingSource;
            this.teacherDataGridview.Location = new System.Drawing.Point(12, 12);
            this.teacherDataGridview.Name = "teacherDataGridview";
            this.teacherDataGridview.Size = new System.Drawing.Size(652, 150);
            this.teacherDataGridview.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource2
            // 
            this.teacherBindingSource2.DataSource = typeof(Code_AcademyForm.Teacher);
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataSource = typeof(Code_AcademyForm.Student);
            // 
            // show_mentor
            // 
            this.show_mentor.Location = new System.Drawing.Point(109, 324);
            this.show_mentor.Name = "show_mentor";
            this.show_mentor.Size = new System.Drawing.Size(75, 23);
            this.show_mentor.TabIndex = 1;
            this.show_mentor.Text = "Mentor";
            this.show_mentor.UseVisualStyleBackColor = true;
            // 
            // show_task_types
            // 
            this.show_task_types.Location = new System.Drawing.Point(373, 324);
            this.show_task_types.Name = "show_task_types";
            this.show_task_types.Size = new System.Drawing.Size(78, 23);
            this.show_task_types.TabIndex = 2;
            this.show_task_types.Text = "Tasks Types";
            this.show_task_types.UseVisualStyleBackColor = true;
            // 
            // show_tasks
            // 
            this.show_tasks.Location = new System.Drawing.Point(244, 324);
            this.show_tasks.Name = "show_tasks";
            this.show_tasks.Size = new System.Drawing.Size(75, 23);
            this.show_tasks.TabIndex = 2;
            this.show_tasks.Text = "Tasks";
            this.show_tasks.UseVisualStyleBackColor = true;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Code_AcademyForm.Teacher);
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataSource = typeof(Code_AcademyForm.Teacher);
            // 
            // show_students
            // 
            this.show_students.Location = new System.Drawing.Point(514, 324);
            this.show_students.Name = "show_students";
            this.show_students.Size = new System.Drawing.Size(78, 23);
            this.show_students.TabIndex = 2;
            this.show_students.Text = "Students";
            this.show_students.UseVisualStyleBackColor = true;
            // 
            // TeacherAccesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 382);
            this.Controls.Add(this.show_tasks);
            this.Controls.Add(this.show_students);
            this.Controls.Add(this.show_task_types);
            this.Controls.Add(this.show_mentor);
            this.Controls.Add(this.teacherDataGridview);
            this.Name = "TeacherAccesForm";
            this.Text = "TeacherAccesForm";
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teacherDataGridview;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button show_mentor;
        private System.Windows.Forms.Button show_task_types;
        private System.Windows.Forms.Button show_tasks;
        private System.Windows.Forms.BindingSource teacherBindingSource2;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private System.Windows.Forms.Button show_students;
    }
}