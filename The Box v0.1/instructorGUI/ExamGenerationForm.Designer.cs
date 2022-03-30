namespace The_Box_v0._1.instructorGUI
{
    partial class ExamGenerationForm
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
            this.ExamId_label = new System.Windows.Forms.Label();
            this.CourseNameOfExam = new System.Windows.Forms.ComboBox();
            this.GenerateExam = new System.Windows.Forms.Button();
            this.TorFlabel = new System.Windows.Forms.Label();
            this.T_f_spilt = new System.Windows.Forms.TextBox();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.MCQlabel = new System.Windows.Forms.Label();
            this.Duration_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exam_IDlabel = new System.Windows.Forms.Label();
            this.mcqSpilt = new System.Windows.Forms.TextBox();
            this.ExamDuration = new System.Windows.Forms.TextBox();
            this.ExamID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExamId_label
            // 
            this.ExamId_label.AutoSize = true;
            this.ExamId_label.Location = new System.Drawing.Point(-143, 44);
            this.ExamId_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExamId_label.Name = "ExamId_label";
            this.ExamId_label.Size = new System.Drawing.Size(61, 17);
            this.ExamId_label.TabIndex = 20;
            this.ExamId_label.Text = "Exam Id ";
            // 
            // CourseNameOfExam
            // 
            this.CourseNameOfExam.FormattingEnabled = true;
            this.CourseNameOfExam.Location = new System.Drawing.Point(168, 92);
            this.CourseNameOfExam.Margin = new System.Windows.Forms.Padding(4);
            this.CourseNameOfExam.Name = "CourseNameOfExam";
            this.CourseNameOfExam.Size = new System.Drawing.Size(201, 24);
            this.CourseNameOfExam.TabIndex = 33;
            this.CourseNameOfExam.SelectedIndexChanged += new System.EventHandler(this.CourseNameOfExam_SelectedIndexChanged);
            // 
            // GenerateExam
            // 
            this.GenerateExam.Location = new System.Drawing.Point(181, 317);
            this.GenerateExam.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateExam.Name = "GenerateExam";
            this.GenerateExam.Size = new System.Drawing.Size(171, 28);
            this.GenerateExam.TabIndex = 32;
            this.GenerateExam.Text = "generateExam";
            this.GenerateExam.UseVisualStyleBackColor = true;
            this.GenerateExam.Click += new System.EventHandler(this.GenerateExam_Click);
            // 
            // TorFlabel
            // 
            this.TorFlabel.AutoSize = true;
            this.TorFlabel.Location = new System.Drawing.Point(46, 253);
            this.TorFlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TorFlabel.Name = "TorFlabel";
            this.TorFlabel.Size = new System.Drawing.Size(77, 17);
            this.TorFlabel.TabIndex = 31;
            this.TorFlabel.Text = "T/F Qs No.";
            // 
            // T_f_spilt
            // 
            this.T_f_spilt.Location = new System.Drawing.Point(168, 248);
            this.T_f_spilt.Margin = new System.Windows.Forms.Padding(4);
            this.T_f_spilt.Name = "T_f_spilt";
            this.T_f_spilt.Size = new System.Drawing.Size(205, 22);
            this.T_f_spilt.TabIndex = 30;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(46, 99);
            this.CourseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(94, 17);
            this.CourseNameLabel.TabIndex = 29;
            this.CourseNameLabel.Text = "Course Name";
            // 
            // MCQlabel
            // 
            this.MCQlabel.AutoSize = true;
            this.MCQlabel.Location = new System.Drawing.Point(46, 204);
            this.MCQlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MCQlabel.Name = "MCQlabel";
            this.MCQlabel.Size = new System.Drawing.Size(87, 17);
            this.MCQlabel.TabIndex = 28;
            this.MCQlabel.Text = "MCQ Qs No.";
            // 
            // Duration_label
            // 
            this.Duration_label.AutoSize = true;
            this.Duration_label.Location = new System.Drawing.Point(46, 149);
            this.Duration_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Duration_label.Name = "Duration_label";
            this.Duration_label.Size = new System.Drawing.Size(62, 17);
            this.Duration_label.TabIndex = 26;
            this.Duration_label.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 25;
            // 
            // Exam_IDlabel
            // 
            this.Exam_IDlabel.AutoSize = true;
            this.Exam_IDlabel.Location = new System.Drawing.Point(46, 50);
            this.Exam_IDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exam_IDlabel.Name = "Exam_IDlabel";
            this.Exam_IDlabel.Size = new System.Drawing.Size(59, 17);
            this.Exam_IDlabel.TabIndex = 24;
            this.Exam_IDlabel.Text = "Exam ID";
            // 
            // mcqSpilt
            // 
            this.mcqSpilt.Location = new System.Drawing.Point(168, 201);
            this.mcqSpilt.Margin = new System.Windows.Forms.Padding(4);
            this.mcqSpilt.Name = "mcqSpilt";
            this.mcqSpilt.Size = new System.Drawing.Size(205, 22);
            this.mcqSpilt.TabIndex = 23;
            // 
            // ExamDuration
            // 
            this.ExamDuration.Location = new System.Drawing.Point(168, 146);
            this.ExamDuration.Margin = new System.Windows.Forms.Padding(4);
            this.ExamDuration.Name = "ExamDuration";
            this.ExamDuration.Size = new System.Drawing.Size(205, 22);
            this.ExamDuration.TabIndex = 22;
            // 
            // ExamID
            // 
            this.ExamID.Location = new System.Drawing.Point(168, 50);
            this.ExamID.Margin = new System.Windows.Forms.Padding(4);
            this.ExamID.Name = "ExamID";
            this.ExamID.Size = new System.Drawing.Size(205, 22);
            this.ExamID.TabIndex = 21;
            // 
            // ExamGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CourseNameOfExam);
            this.Controls.Add(this.GenerateExam);
            this.Controls.Add(this.TorFlabel);
            this.Controls.Add(this.T_f_spilt);
            this.Controls.Add(this.CourseNameLabel);
            this.Controls.Add(this.MCQlabel);
            this.Controls.Add(this.Duration_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exam_IDlabel);
            this.Controls.Add(this.mcqSpilt);
            this.Controls.Add(this.ExamDuration);
            this.Controls.Add(this.ExamID);
            this.Controls.Add(this.ExamId_label);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamGenerationForm";
            this.Text = "ExamGenerationForm";
            this.Load += new System.EventHandler(this.ExamGenerationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ExamId_label;
        public System.Windows.Forms.ComboBox CourseNameOfExam;
        private System.Windows.Forms.Button GenerateExam;
        private System.Windows.Forms.Label TorFlabel;
        private System.Windows.Forms.TextBox T_f_spilt;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label MCQlabel;
        private System.Windows.Forms.Label Duration_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Exam_IDlabel;
        private System.Windows.Forms.TextBox mcqSpilt;
        private System.Windows.Forms.TextBox ExamDuration;
        private System.Windows.Forms.TextBox ExamID;
    }
}