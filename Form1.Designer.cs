namespace Code_AcademyForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_open.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_open.Location = new System.Drawing.Point(239, 340);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(169, 65);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "OPEN";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 460);
            this.Controls.Add(this.btn_open);
            this.Name = "Form1";
            this.Text = "CodeAcademy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_open;
    }
}

