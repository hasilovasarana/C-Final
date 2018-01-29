namespace Code_AcademyForm
{
    partial class Task_TypesForm
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
            this.task_types = new System.Windows.Forms.GroupBox();
            this.task_type_rate = new System.Windows.Forms.TextBox();
            this.task_type_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_task_type = new System.Windows.Forms.Button();
            this.task_types.SuspendLayout();
            this.SuspendLayout();
            // 
            // task_types
            // 
            this.task_types.Controls.Add(this.task_type_rate);
            this.task_types.Controls.Add(this.task_type_name);
            this.task_types.Controls.Add(this.label2);
            this.task_types.Controls.Add(this.label1);
            this.task_types.Location = new System.Drawing.Point(44, 51);
            this.task_types.Name = "task_types";
            this.task_types.Size = new System.Drawing.Size(379, 248);
            this.task_types.TabIndex = 0;
            this.task_types.TabStop = false;
            this.task_types.Text = "Task  Types";
            // 
            // task_type_rate
            // 
            this.task_type_rate.Location = new System.Drawing.Point(156, 97);
            this.task_type_rate.Name = "task_type_rate";
            this.task_type_rate.Size = new System.Drawing.Size(168, 20);
            this.task_type_rate.TabIndex = 2;
            // 
            // task_type_name
            // 
            this.task_type_name.Location = new System.Drawing.Point(156, 56);
            this.task_type_name.Name = "task_type_name";
            this.task_type_name.Size = new System.Drawing.Size(168, 20);
            this.task_type_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Type Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Type Name:";
            // 
            // save_task_type
            // 
            this.save_task_type.Location = new System.Drawing.Point(348, 305);
            this.save_task_type.Name = "save_task_type";
            this.save_task_type.Size = new System.Drawing.Size(75, 23);
            this.save_task_type.TabIndex = 1;
            this.save_task_type.Text = "Save";
            this.save_task_type.UseVisualStyleBackColor = true;
            // 
            // Task_TypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 370);
            this.Controls.Add(this.save_task_type);
            this.Controls.Add(this.task_types);
            this.Name = "Task_TypesForm";
            this.Text = "Task_TypesForm";
            this.task_types.ResumeLayout(false);
            this.task_types.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox task_types;
        private System.Windows.Forms.TextBox task_type_rate;
        private System.Windows.Forms.TextBox task_type_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_task_type;
    }
}