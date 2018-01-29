namespace Code_AcademyForm
{
    partial class TaechersDataForm
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
            this.taecher_data_gridview = new System.Windows.Forms.DataGridView();
            this.programing_StudentDataSet2 = new Code_AcademyForm.Programing_StudentDataSet2();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new Code_AcademyForm.Programing_StudentDataSet2TableAdapters.TeacherTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachergenderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherphotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_id_cmb = new System.Windows.Forms.ComboBox();
            this.delete_teacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taecher_data_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programing_StudentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taecher_data_gridview
            // 
            this.taecher_data_gridview.AutoGenerateColumns = false;
            this.taecher_data_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taecher_data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taecher_data_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.teachernameDataGridViewTextBoxColumn,
            this.teachersurnameDataGridViewTextBoxColumn,
            this.teacheremailDataGridViewTextBoxColumn,
            this.teacherphoneDataGridViewTextBoxColumn,
            this.teachergenderidDataGridViewTextBoxColumn,
            this.teacherpasswordDataGridViewTextBoxColumn,
            this.teacherphotoDataGridViewTextBoxColumn});
            this.taecher_data_gridview.DataSource = this.teacherBindingSource;
            this.taecher_data_gridview.Location = new System.Drawing.Point(12, 12);
            this.taecher_data_gridview.Name = "taecher_data_gridview";
            this.taecher_data_gridview.Size = new System.Drawing.Size(975, 233);
            this.taecher_data_gridview.TabIndex = 0;
            // 
            // programing_StudentDataSet2
            // 
            this.programing_StudentDataSet2.DataSetName = "Programing_StudentDataSet2";
            this.programing_StudentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.programing_StudentDataSet2;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teachernameDataGridViewTextBoxColumn
            // 
            this.teachernameDataGridViewTextBoxColumn.DataPropertyName = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn.HeaderText = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn.Name = "teachernameDataGridViewTextBoxColumn";
            // 
            // teachersurnameDataGridViewTextBoxColumn
            // 
            this.teachersurnameDataGridViewTextBoxColumn.DataPropertyName = "teacher_surname";
            this.teachersurnameDataGridViewTextBoxColumn.HeaderText = "teacher_surname";
            this.teachersurnameDataGridViewTextBoxColumn.Name = "teachersurnameDataGridViewTextBoxColumn";
            // 
            // teacheremailDataGridViewTextBoxColumn
            // 
            this.teacheremailDataGridViewTextBoxColumn.DataPropertyName = "teacher_email";
            this.teacheremailDataGridViewTextBoxColumn.HeaderText = "teacher_email";
            this.teacheremailDataGridViewTextBoxColumn.Name = "teacheremailDataGridViewTextBoxColumn";
            // 
            // teacherphoneDataGridViewTextBoxColumn
            // 
            this.teacherphoneDataGridViewTextBoxColumn.DataPropertyName = "teacher_phone";
            this.teacherphoneDataGridViewTextBoxColumn.HeaderText = "teacher_phone";
            this.teacherphoneDataGridViewTextBoxColumn.Name = "teacherphoneDataGridViewTextBoxColumn";
            // 
            // teachergenderidDataGridViewTextBoxColumn
            // 
            this.teachergenderidDataGridViewTextBoxColumn.DataPropertyName = "teacher_gender_id";
            this.teachergenderidDataGridViewTextBoxColumn.HeaderText = "teacher_gender_id";
            this.teachergenderidDataGridViewTextBoxColumn.Name = "teachergenderidDataGridViewTextBoxColumn";
            // 
            // teacherpasswordDataGridViewTextBoxColumn
            // 
            this.teacherpasswordDataGridViewTextBoxColumn.DataPropertyName = "teacher_password";
            this.teacherpasswordDataGridViewTextBoxColumn.HeaderText = "teacher_password";
            this.teacherpasswordDataGridViewTextBoxColumn.Name = "teacherpasswordDataGridViewTextBoxColumn";
            // 
            // teacherphotoDataGridViewTextBoxColumn
            // 
            this.teacherphotoDataGridViewTextBoxColumn.DataPropertyName = "teacher_photo";
            this.teacherphotoDataGridViewTextBoxColumn.HeaderText = "teacher_photo";
            this.teacherphotoDataGridViewTextBoxColumn.Name = "teacherphotoDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Teacher:";
            // 
            // teacher_id_cmb
            // 
            this.teacher_id_cmb.FormattingEnabled = true;
            this.teacher_id_cmb.Location = new System.Drawing.Point(184, 303);
            this.teacher_id_cmb.Name = "teacher_id_cmb";
            this.teacher_id_cmb.Size = new System.Drawing.Size(163, 21);
            this.teacher_id_cmb.TabIndex = 2;
            // 
            // delete_teacher
            // 
            this.delete_teacher.Location = new System.Drawing.Point(462, 303);
            this.delete_teacher.Name = "delete_teacher";
            this.delete_teacher.Size = new System.Drawing.Size(122, 23);
            this.delete_teacher.TabIndex = 3;
            this.delete_teacher.Text = "Delete";
            this.delete_teacher.UseVisualStyleBackColor = true;
            this.delete_teacher.Click += new System.EventHandler(this.delete_teacher_Click);
            // 
            // TaechersDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 387);
            this.Controls.Add(this.delete_teacher);
            this.Controls.Add(this.teacher_id_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taecher_data_gridview);
            this.Name = "TaechersDataForm";
            this.Text = "TaechersDataForm";
            this.Load += new System.EventHandler(this.TaechersDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taecher_data_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programing_StudentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView taecher_data_gridview;
        private Programing_StudentDataSet2 programing_StudentDataSet2;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private Programing_StudentDataSet2TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachergenderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherphotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher_id_cmb;
        private System.Windows.Forms.Button delete_teacher;
    }
}