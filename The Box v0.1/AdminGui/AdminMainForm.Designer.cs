namespace The_Box_v0._1.AdminGui
{
    partial class AdminMainForm
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
            this.HdrPanel = new System.Windows.Forms.Panel();
            this.CloseAppbtn = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.MaximizeAppbtn = new System.Windows.Forms.Button();
            this.CloseFormbtn = new System.Windows.Forms.Button();
            this.WelcPanel = new System.Windows.Forms.Panel();
            this.StudentName = new System.Windows.Forms.Label();
            this.HdrPanel.SuspendLayout();
            this.WelcPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HdrPanel
            // 
            this.HdrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.HdrPanel.Controls.Add(this.CloseAppbtn);
            this.HdrPanel.Controls.Add(this.Minimize);
            this.HdrPanel.Controls.Add(this.MaximizeAppbtn);
            this.HdrPanel.Controls.Add(this.CloseFormbtn);
            this.HdrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HdrPanel.Location = new System.Drawing.Point(0, 78);
            this.HdrPanel.Name = "HdrPanel";
            this.HdrPanel.Size = new System.Drawing.Size(100, 78);
            this.HdrPanel.TabIndex = 6;
            this.HdrPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HdrPanel_Paint);
            // 
            // CloseAppbtn
            // 
            this.CloseAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppbtn.FlatAppearance.BorderSize = 0;
            this.CloseAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppbtn.Image = global::The_Box_v0._1.Properties.Resources.close__2_;
            this.CloseAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseAppbtn.Location = new System.Drawing.Point(767, 3);
            this.CloseAppbtn.Name = "CloseAppbtn";
            this.CloseAppbtn.Size = new System.Drawing.Size(28, 23);
            this.CloseAppbtn.TabIndex = 5;
            this.CloseAppbtn.UseVisualStyleBackColor = true;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = global::The_Box_v0._1.Properties.Resources.minus;
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize.Location = new System.Drawing.Point(699, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(28, 23);
            this.Minimize.TabIndex = 4;
            this.Minimize.UseVisualStyleBackColor = true;
            // 
            // MaximizeAppbtn
            // 
            this.MaximizeAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeAppbtn.FlatAppearance.BorderSize = 0;
            this.MaximizeAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeAppbtn.Image = global::The_Box_v0._1.Properties.Resources.fullscreen;
            this.MaximizeAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MaximizeAppbtn.Location = new System.Drawing.Point(733, 3);
            this.MaximizeAppbtn.Name = "MaximizeAppbtn";
            this.MaximizeAppbtn.Size = new System.Drawing.Size(28, 23);
            this.MaximizeAppbtn.TabIndex = 3;
            this.MaximizeAppbtn.UseVisualStyleBackColor = true;
            // 
            // CloseFormbtn
            // 
            this.CloseFormbtn.FlatAppearance.BorderSize = 0;
            this.CloseFormbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormbtn.Image = global::The_Box_v0._1.Properties.Resources.close__1_;
            this.CloseFormbtn.Location = new System.Drawing.Point(24, 29);
            this.CloseFormbtn.Name = "CloseFormbtn";
            this.CloseFormbtn.Size = new System.Drawing.Size(26, 25);
            this.CloseFormbtn.TabIndex = 2;
            this.CloseFormbtn.UseVisualStyleBackColor = true;
            // 
            // WelcPanel
            // 
            this.WelcPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.WelcPanel.Controls.Add(this.StudentName);
            this.WelcPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.WelcPanel.Location = new System.Drawing.Point(0, 0);
            this.WelcPanel.Name = "WelcPanel";
            this.WelcPanel.Size = new System.Drawing.Size(100, 78);
            this.WelcPanel.TabIndex = 5;
            this.WelcPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WelcPanel_Paint);
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.StudentName.Location = new System.Drawing.Point(12, 22);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(176, 35);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "studentName";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HdrPanel);
            this.Controls.Add(this.WelcPanel);
            this.Name = "AdminMainForm";
            this.Text = "Form1";
            this.HdrPanel.ResumeLayout(false);
            this.WelcPanel.ResumeLayout(false);
            this.WelcPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HdrPanel;
        private System.Windows.Forms.Button CloseAppbtn;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button MaximizeAppbtn;
        private System.Windows.Forms.Button CloseFormbtn;
        private System.Windows.Forms.Panel WelcPanel;
        private System.Windows.Forms.Label StudentName;
    }
}