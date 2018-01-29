namespace Code_AcademyForm
{
    partial class StudentsDataForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentgithubaccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentphotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentgenderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentcappointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentgroupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_student_cmb = new System.Windows.Forms.ComboBox();
            this.delete_student = new System.Windows.Forms.Button();
            this.programing_StudentDataSet = new Code_AcademyForm.Programing_StudentDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Code_AcademyForm.Programing_StudentDataSetTableAdapters.StudentsTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programing_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.studentsurnameDataGridViewTextBoxColumn,
            this.studentemailDataGridViewTextBoxColumn,
            this.studentphoneDataGridViewTextBoxColumn,
            this.studentgithubaccountDataGridViewTextBoxColumn,
            this.studentinfoDataGridViewTextBoxColumn,
            this.studentphotoDataGridViewTextBoxColumn,
            this.studentgenderidDataGridViewTextBoxColumn,
            this.studentpasswordDataGridViewTextBoxColumn,
            this.studentcappointDataGridViewTextBoxColumn,
            this.studentgroupidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1141, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "student_name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // studentsurnameDataGridViewTextBoxColumn
            // 
            this.studentsurnameDataGridViewTextBoxColumn.DataPropertyName = "student_surname";
            this.studentsurnameDataGridViewTextBoxColumn.HeaderText = "student_surname";
            this.studentsurnameDataGridViewTextBoxColumn.Name = "studentsurnameDataGridViewTextBoxColumn";
            // 
            // studentemailDataGridViewTextBoxColumn
            // 
            this.studentemailDataGridViewTextBoxColumn.DataPropertyName = "student_email";
            this.studentemailDataGridViewTextBoxColumn.HeaderText = "student_email";
            this.studentemailDataGridViewTextBoxColumn.Name = "studentemailDataGridViewTextBoxColumn";
            // 
            // studentphoneDataGridViewTextBoxColumn
            // 
            this.studentphoneDataGridViewTextBoxColumn.DataPropertyName = "student_phone";
            this.studentphoneDataGridViewTextBoxColumn.HeaderText = "student_phone";
            this.studentphoneDataGridViewTextBoxColumn.Name = "studentphoneDataGridViewTextBoxColumn";
            // 
            // studentgithubaccountDataGridViewTextBoxColumn
            // 
            this.studentgithubaccountDataGridViewTextBoxColumn.DataPropertyName = "student_github_account";
            this.studentgithubaccountDataGridViewTextBoxColumn.HeaderText = "student_github_account";
            this.studentgithubaccountDataGridViewTextBoxColumn.Name = "studentgithubaccountDataGridViewTextBoxColumn";
            // 
            // studentinfoDataGridViewTextBoxColumn
            // 
            this.studentinfoDataGridViewTextBoxColumn.DataPropertyName = "student_info";
            this.studentinfoDataGridViewTextBoxColumn.HeaderText = "student_info";
            this.studentinfoDataGridViewTextBoxColumn.Name = "studentinfoDataGridViewTextBoxColumn";
            // 
            // studentphotoDataGridViewTextBoxColumn
            // 
            this.studentphotoDataGridViewTextBoxColumn.DataPropertyName = "student_photo";
            this.studentphotoDataGridViewTextBoxColumn.HeaderText = "student_photo";
            this.studentphotoDataGridViewTextBoxColumn.Name = "studentphotoDataGridViewTextBoxColumn";
            // 
            // studentgenderidDataGridViewTextBoxColumn
            // 
            this.studentgenderidDataGridViewTextBoxColumn.DataPropertyName = "student_gender_id";
            this.studentgenderidDataGridViewTextBoxColumn.HeaderText = "student_gender_id";
            this.studentgenderidDataGridViewTextBoxColumn.Name = "studentgenderidDataGridViewTextBoxColumn";
            // 
            // studentpasswordDataGridViewTextBoxColumn
            // 
            this.studentpasswordDataGridViewTextBoxColumn.DataPropertyName = "student_password";
            this.studentpasswordDataGridViewTextBoxColumn.HeaderText = "student_password";
            this.studentpasswordDataGridViewTextBoxColumn.Name = "studentpasswordDataGridViewTextBoxColumn";
            // 
            // studentcappointDataGridViewTextBoxColumn
            // 
            this.studentcappointDataGridViewTextBoxColumn.DataPropertyName = "student_cap_point";
            this.studentcappointDataGridViewTextBoxColumn.HeaderText = "student_cap_point";
            this.studentcappointDataGridViewTextBoxColumn.Name = "studentcappointDataGridViewTextBoxColumn";
            // 
            // studentgroupidDataGridViewTextBoxColumn
            // 
            this.studentgroupidDataGridViewTextBoxColumn.DataPropertyName = "student_group_id";
            this.studentgroupidDataGridViewTextBoxColumn.HeaderText = "student_group_id";
            this.studentgroupidDataGridViewTextBoxColumn.Name = "studentgroupidDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Student:";
            // 
            // delete_student_cmb
            // 
            this.delete_student_cmb.FormattingEnabled = true;
            this.delete_student_cmb.Location = new System.Drawing.Point(134, 336);
            this.delete_student_cmb.Name = "delete_student_cmb";
            this.delete_student_cmb.Size = new System.Drawing.Size(147, 21);
            this.delete_student_cmb.TabIndex = 2;
            // 
            // delete_student
            // 
            this.delete_student.Location = new System.Drawing.Point(350, 336);
            this.delete_student.Name = "delete_student";
            this.delete_student.Size = new System.Drawing.Size(94, 23);
            this.delete_student.TabIndex = 3;
            this.delete_student.Text = "Delete";
            this.delete_student.UseVisualStyleBackColor = true;
            this.delete_student.Click += new System.EventHandler(this.delete_student_Click);
            // 
            // programing_StudentDataSet
            // 
            this.programing_StudentDataSet.DataSetName = "Programing_StudentDataSet";
            this.programing_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.programing_StudentDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Code_AcademyForm.Student);
            // 
            // StudentsDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 401);
            this.Controls.Add(this.delete_student);
            this.Controls.Add(this.delete_student_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentsDataForm";
            this.Text = "StudentsDataForm";
            this.Load += new System.EventHandler(this.StudentsDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programing_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentgithubaccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentphotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentgenderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentcappointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentgroupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox delete_student_cmb;
        private System.Windows.Forms.Button delete_student;
        private Programing_StudentDataSet programing_StudentDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Programing_StudentDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}