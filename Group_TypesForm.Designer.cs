namespace Code_AcademyForm
{
    partial class Group_TypesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.group_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_schedule_cmb = new System.Windows.Forms.ComboBox();
            this.group_types = new System.Windows.Forms.GroupBox();
            this.save_group_types = new System.Windows.Forms.Button();
            this.group_types.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Type:";
            // 
            // group_type
            // 
            this.group_type.Location = new System.Drawing.Point(117, 46);
            this.group_type.Name = "group_type";
            this.group_type.Size = new System.Drawing.Size(146, 20);
            this.group_type.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Group Schedule:";
            // 
            // group_schedule_cmb
            // 
            this.group_schedule_cmb.FormattingEnabled = true;
            this.group_schedule_cmb.Location = new System.Drawing.Point(117, 85);
            this.group_schedule_cmb.Name = "group_schedule_cmb";
            this.group_schedule_cmb.Size = new System.Drawing.Size(146, 21);
            this.group_schedule_cmb.TabIndex = 2;
            // 
            // group_types
            // 
            this.group_types.Controls.Add(this.group_type);
            this.group_types.Controls.Add(this.group_schedule_cmb);
            this.group_types.Controls.Add(this.label1);
            this.group_types.Controls.Add(this.label2);
            this.group_types.Location = new System.Drawing.Point(31, 26);
            this.group_types.Name = "group_types";
            this.group_types.Size = new System.Drawing.Size(326, 167);
            this.group_types.TabIndex = 3;
            this.group_types.TabStop = false;
            this.group_types.Text = "Group Types";
            // 
            // save_group_types
            // 
            this.save_group_types.Location = new System.Drawing.Point(282, 199);
            this.save_group_types.Name = "save_group_types";
            this.save_group_types.Size = new System.Drawing.Size(75, 23);
            this.save_group_types.TabIndex = 4;
            this.save_group_types.Text = "Save";
            this.save_group_types.UseVisualStyleBackColor = true;
            this.save_group_types.Click += new System.EventHandler(this.save_group_types_Click);
            // 
            // Group_TypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 383);
            this.Controls.Add(this.save_group_types);
            this.Controls.Add(this.group_types);
            this.Name = "Group_TypesForm";
            this.Text = "Group_TypesForm";
            this.group_types.ResumeLayout(false);
            this.group_types.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox group_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox group_schedule_cmb;
        private System.Windows.Forms.GroupBox group_types;
        private System.Windows.Forms.Button save_group_types;
    }
}