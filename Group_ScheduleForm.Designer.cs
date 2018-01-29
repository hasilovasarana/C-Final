namespace Code_AcademyForm
{
    partial class Group_ScheduleForm
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
            this.group_schedule = new System.Windows.Forms.GroupBox();
            this.group_begin_time = new System.Windows.Forms.DateTimePicker();
            this.group_end_time = new System.Windows.Forms.DateTimePicker();
            this.group_schedule_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_schedule = new System.Windows.Forms.Button();
            this.group_schedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_schedule
            // 
            this.group_schedule.Controls.Add(this.group_begin_time);
            this.group_schedule.Controls.Add(this.group_end_time);
            this.group_schedule.Controls.Add(this.group_schedule_name);
            this.group_schedule.Controls.Add(this.label3);
            this.group_schedule.Controls.Add(this.label2);
            this.group_schedule.Controls.Add(this.label1);
            this.group_schedule.Location = new System.Drawing.Point(43, 47);
            this.group_schedule.Name = "group_schedule";
            this.group_schedule.Size = new System.Drawing.Size(398, 232);
            this.group_schedule.TabIndex = 0;
            this.group_schedule.TabStop = false;
            this.group_schedule.Text = "Group Schedule";
            // 
            // group_begin_time
            // 
            this.group_begin_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.group_begin_time.Location = new System.Drawing.Point(172, 80);
            this.group_begin_time.Name = "group_begin_time";
            this.group_begin_time.Size = new System.Drawing.Size(200, 20);
            this.group_begin_time.TabIndex = 2;
            // 
            // group_end_time
            // 
            this.group_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.group_end_time.Location = new System.Drawing.Point(172, 119);
            this.group_end_time.Name = "group_end_time";
            this.group_end_time.Size = new System.Drawing.Size(200, 20);
            this.group_end_time.TabIndex = 2;
            // 
            // group_schedule_name
            // 
            this.group_schedule_name.Location = new System.Drawing.Point(172, 46);
            this.group_schedule_name.Name = "group_schedule_name";
            this.group_schedule_name.Size = new System.Drawing.Size(120, 20);
            this.group_schedule_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Group End Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Group Begin Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Schedule Name:";
            // 
            // save_schedule
            // 
            this.save_schedule.Location = new System.Drawing.Point(366, 297);
            this.save_schedule.Name = "save_schedule";
            this.save_schedule.Size = new System.Drawing.Size(75, 23);
            this.save_schedule.TabIndex = 0;
            this.save_schedule.Text = "Save";
            this.save_schedule.UseVisualStyleBackColor = true;
            this.save_schedule.Click += new System.EventHandler(this.save_schedule_Click);
            // 
            // Group_ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 382);
            this.Controls.Add(this.save_schedule);
            this.Controls.Add(this.group_schedule);
            this.Name = "Group_ScheduleForm";
            this.Text = "Group_ScheduleForm";
            this.group_schedule.ResumeLayout(false);
            this.group_schedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_schedule;
        private System.Windows.Forms.DateTimePicker group_begin_time;
        private System.Windows.Forms.DateTimePicker group_end_time;
        private System.Windows.Forms.TextBox group_schedule_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_schedule;
    }
}