namespace Code_AcademyForm
{
    partial class StudentAcces
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
            this.student_own_data_gridview = new System.Windows.Forms.DataGridView();
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
            this.programing_StudentDataSet1 = new Code_AcademyForm.Programing_StudentDataSet1();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Code_AcademyForm.Programing_StudentDataSet1TableAdapters.StudentsTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.student_own_data_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programing_StudentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // student_own_data_gridview
            // 
            this.student_own_data_gridview.AutoGenerateColumns = false;
            this.student_own_data_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.student_own_data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_own_data_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.student_own_data_gridview.DataSource = this.studentsBindingSource;
            this.student_own_data_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_own_data_gridview.Location = new System.Drawing.Point(0, 0);
            this.student_own_data_gridview.Name = "student_own_data_gridview";
            this.student_own_data_gridview.Size = new System.Drawing.Size(1119, 379);
            this.student_own_data_gridview.TabIndex = 0;
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
            // programing_StudentDataSet1
            // 
            this.programing_StudentDataSet1.DataSetName = "Programing_StudentDataSet1";
            this.programing_StudentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.programing_StudentDataSet1;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Code_AcademyForm.Student);
            // 
            // studentsFormBindingSource
            // 
            this.studentsFormBindingSource.DataSource = typeof(Code_AcademyForm.StudentsForm);
            // 
            // StudentAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 379);
            this.Controls.Add(this.student_own_data_gridview);
            this.Name = "StudentAcces";
            this.Text = "StudentAcces";
            this.Load += new System.EventHandler(this.StudentAcces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_own_data_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programing_StudentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView student_own_data_gridview;
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
        private System.Windows.Forms.BindingSource studentsFormBindingSource;
        private Programing_StudentDataSet1 programing_StudentDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Programing_StudentDataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}