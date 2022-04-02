namespace The_Box_v0._1.StudentGui
{
    partial class ViewGrade
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
            this.label2 = new System.Windows.Forms.Label();
            this.std_courses = new System.Windows.Forms.ComboBox();
            this.grade_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(277, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Course";
            // 
            // std_courses
            // 
            this.std_courses.FormattingEnabled = true;
            this.std_courses.Location = new System.Drawing.Point(525, 230);
            this.std_courses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.std_courses.Name = "std_courses";
            this.std_courses.Size = new System.Drawing.Size(199, 28);
            this.std_courses.TabIndex = 3;
            this.std_courses.SelectedIndexChanged += new System.EventHandler(this.Std_courses_SelectedIndexChanged);
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grade_label.Location = new System.Drawing.Point(474, 314);
            this.grade_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(0, 33);
            this.grade_label.TabIndex = 4;
            // 
            // ViewGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.grade_label);
            this.Controls.Add(this.std_courses);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewGrade";
            this.Load += new System.EventHandler(this.ViewGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox std_courses;
        private System.Windows.Forms.Label grade_label;
    }
}