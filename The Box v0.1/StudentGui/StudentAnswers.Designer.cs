namespace The_Box_v0._1.StudentGui
{
    partial class StudentAnswers
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
            this.CrsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EComboBox = new System.Windows.Forms.ComboBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CrsComboBox
            // 
            this.CrsComboBox.FormattingEnabled = true;
            this.CrsComboBox.Location = new System.Drawing.Point(112, 21);
            this.CrsComboBox.Name = "CrsComboBox";
            this.CrsComboBox.Size = new System.Drawing.Size(121, 21);
            this.CrsComboBox.TabIndex = 0;
            this.CrsComboBox.SelectedIndexChanged += new System.EventHandler(this.CrsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(244, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exam ID";
            this.label2.Visible = false;
            // 
            // EComboBox
            // 
            this.EComboBox.FormattingEnabled = true;
            this.EComboBox.Location = new System.Drawing.Point(297, 21);
            this.EComboBox.Name = "EComboBox";
            this.EComboBox.Size = new System.Drawing.Size(121, 21);
            this.EComboBox.TabIndex = 3;
            this.EComboBox.Visible = false;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.ForeColor = System.Drawing.Color.Black;
            this.GradeLabel.Location = new System.Drawing.Point(449, 24);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(36, 13);
            this.GradeLabel.TabIndex = 4;
            this.GradeLabel.Text = "Grade";
            this.GradeLabel.Visible = false;
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.Location = new System.Drawing.Point(503, 21);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.GradeTextBox.TabIndex = 5;
            this.GradeTextBox.Visible = false;
            this.GradeTextBox.WordWrap = false;
            // 
            // StudentAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradeTextBox);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.EComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CrsComboBox);
            this.Name = "StudentAnswers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Answers";
            this.Load += new System.EventHandler(this.StudentAnswers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CrsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EComboBox;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.TextBox GradeTextBox;
    }
}