namespace Code_AcademyForm
{
    partial class MentorsDataForm
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
            this.programing_StudentDataSet3 = new Code_AcademyForm.Programing_StudentDataSet3();
            this.mentorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mentorsTableAdapter = new Code_AcademyForm.Programing_StudentDataSet3TableAdapters.MentorsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentorsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentoremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentorphotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentorinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentorgenderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentorpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_mentor_cmb = new System.Windows.Forms.ComboBox();
            this.delete_mentor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programing_StudentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.mentornameDataGridViewTextBoxColumn,
            this.mentorsurnameDataGridViewTextBoxColumn,
            this.mentoremailDataGridViewTextBoxColumn,
            this.mentorphotoDataGridViewTextBoxColumn,
            this.mentorinfoDataGridViewTextBoxColumn,
            this.mentorgenderidDataGridViewTextBoxColumn,
            this.mentorpasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mentorsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // programing_StudentDataSet3
            // 
            this.programing_StudentDataSet3.DataSetName = "Programing_StudentDataSet3";
            this.programing_StudentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mentorsBindingSource
            // 
            this.mentorsBindingSource.DataMember = "Mentors";
            this.mentorsBindingSource.DataSource = this.programing_StudentDataSet3;
            // 
            // mentorsTableAdapter
            // 
            this.mentorsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mentornameDataGridViewTextBoxColumn
            // 
            this.mentornameDataGridViewTextBoxColumn.DataPropertyName = "mentor_name";
            this.mentornameDataGridViewTextBoxColumn.HeaderText = "mentor_name";
            this.mentornameDataGridViewTextBoxColumn.Name = "mentornameDataGridViewTextBoxColumn";
            // 
            // mentorsurnameDataGridViewTextBoxColumn
            // 
            this.mentorsurnameDataGridViewTextBoxColumn.DataPropertyName = "mentor_surname";
            this.mentorsurnameDataGridViewTextBoxColumn.HeaderText = "mentor_surname";
            this.mentorsurnameDataGridViewTextBoxColumn.Name = "mentorsurnameDataGridViewTextBoxColumn";
            // 
            // mentoremailDataGridViewTextBoxColumn
            // 
            this.mentoremailDataGridViewTextBoxColumn.DataPropertyName = "mentor_email";
            this.mentoremailDataGridViewTextBoxColumn.HeaderText = "mentor_email";
            this.mentoremailDataGridViewTextBoxColumn.Name = "mentoremailDataGridViewTextBoxColumn";
            // 
            // mentorphotoDataGridViewTextBoxColumn
            // 
            this.mentorphotoDataGridViewTextBoxColumn.DataPropertyName = "mentor_photo";
            this.mentorphotoDataGridViewTextBoxColumn.HeaderText = "mentor_photo";
            this.mentorphotoDataGridViewTextBoxColumn.Name = "mentorphotoDataGridViewTextBoxColumn";
            // 
            // mentorinfoDataGridViewTextBoxColumn
            // 
            this.mentorinfoDataGridViewTextBoxColumn.DataPropertyName = "mentor_info";
            this.mentorinfoDataGridViewTextBoxColumn.HeaderText = "mentor_info";
            this.mentorinfoDataGridViewTextBoxColumn.Name = "mentorinfoDataGridViewTextBoxColumn";
            // 
            // mentorgenderidDataGridViewTextBoxColumn
            // 
            this.mentorgenderidDataGridViewTextBoxColumn.DataPropertyName = "mentor_gender_id";
            this.mentorgenderidDataGridViewTextBoxColumn.HeaderText = "mentor_gender_id";
            this.mentorgenderidDataGridViewTextBoxColumn.Name = "mentorgenderidDataGridViewTextBoxColumn";
            // 
            // mentorpasswordDataGridViewTextBoxColumn
            // 
            this.mentorpasswordDataGridViewTextBoxColumn.DataPropertyName = "mentor_password";
            this.mentorpasswordDataGridViewTextBoxColumn.HeaderText = "mentor_password";
            this.mentorpasswordDataGridViewTextBoxColumn.Name = "mentorpasswordDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Mentor:";
            // 
            // delete_mentor_cmb
            // 
            this.delete_mentor_cmb.FormattingEnabled = true;
            this.delete_mentor_cmb.Location = new System.Drawing.Point(218, 299);
            this.delete_mentor_cmb.Name = "delete_mentor_cmb";
            this.delete_mentor_cmb.Size = new System.Drawing.Size(121, 21);
            this.delete_mentor_cmb.TabIndex = 2;
            // 
            // delete_mentor
            // 
            this.delete_mentor.Location = new System.Drawing.Point(392, 297);
            this.delete_mentor.Name = "delete_mentor";
            this.delete_mentor.Size = new System.Drawing.Size(82, 23);
            this.delete_mentor.TabIndex = 3;
            this.delete_mentor.Text = "Delete";
            this.delete_mentor.UseVisualStyleBackColor = true;
            this.delete_mentor.Click += new System.EventHandler(this.delete_mentor_Click);
            // 
            // MentorsDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 360);
            this.Controls.Add(this.delete_mentor);
            this.Controls.Add(this.delete_mentor_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MentorsDataForm";
            this.Text = "MentorsDataForm";
            this.Load += new System.EventHandler(this.MentorsDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programing_StudentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Programing_StudentDataSet3 programing_StudentDataSet3;
        private System.Windows.Forms.BindingSource mentorsBindingSource;
        private Programing_StudentDataSet3TableAdapters.MentorsTableAdapter mentorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentorsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentoremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentorphotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentorinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentorgenderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentorpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox delete_mentor_cmb;
        private System.Windows.Forms.Button delete_mentor;
    }
}