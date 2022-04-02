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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamGenerationForm));
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
            this.ExamDate = new System.Windows.Forms.DateTimePicker();
            this.ExamTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExamId_label
            // 
            this.ExamId_label.AutoSize = true;
            this.ExamId_label.Location = new System.Drawing.Point(-107, 36);
            this.ExamId_label.Name = "ExamId_label";
            this.ExamId_label.Size = new System.Drawing.Size(48, 13);
            this.ExamId_label.TabIndex = 20;
            this.ExamId_label.Text = "Exam Id ";
            // 
            // CourseNameOfExam
            // 
            this.CourseNameOfExam.FormattingEnabled = true;
            this.CourseNameOfExam.Location = new System.Drawing.Point(136, 75);
            this.CourseNameOfExam.Name = "CourseNameOfExam";
            this.CourseNameOfExam.Size = new System.Drawing.Size(155, 21);
            this.CourseNameOfExam.TabIndex = 33;
            this.CourseNameOfExam.SelectedIndexChanged += new System.EventHandler(this.CourseNameOfExam_SelectedIndexChanged);
            // 
            // GenerateExam
            // 
            this.GenerateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateExam.Location = new System.Drawing.Point(133, 328);
            this.GenerateExam.Name = "GenerateExam";
            this.GenerateExam.Size = new System.Drawing.Size(129, 33);
            this.GenerateExam.TabIndex = 32;
            this.GenerateExam.Text = "generateExam";
            this.GenerateExam.UseVisualStyleBackColor = true;
            this.GenerateExam.Click += new System.EventHandler(this.GenerateExam_Click);
            // 
            // TorFlabel
            // 
            this.TorFlabel.AutoSize = true;
            this.TorFlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TorFlabel.Location = new System.Drawing.Point(21, 276);
            this.TorFlabel.Name = "TorFlabel";
            this.TorFlabel.Size = new System.Drawing.Size(77, 17);
            this.TorFlabel.TabIndex = 31;
            this.TorFlabel.Text = "T/F Qs No.";
            // 
            // T_f_spilt
            // 
            this.T_f_spilt.Location = new System.Drawing.Point(136, 273);
            this.T_f_spilt.Name = "T_f_spilt";
            this.T_f_spilt.Size = new System.Drawing.Size(155, 20);
            this.T_f_spilt.TabIndex = 30;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNameLabel.Location = new System.Drawing.Point(21, 79);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(94, 17);
            this.CourseNameLabel.TabIndex = 29;
            this.CourseNameLabel.Text = "Course Name";
            // 
            // MCQlabel
            // 
            this.MCQlabel.AutoSize = true;
            this.MCQlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCQlabel.Location = new System.Drawing.Point(21, 237);
            this.MCQlabel.Name = "MCQlabel";
            this.MCQlabel.Size = new System.Drawing.Size(87, 17);
            this.MCQlabel.TabIndex = 28;
            this.MCQlabel.Text = "MCQ Qs No.";
            // 
            // Duration_label
            // 
            this.Duration_label.AutoSize = true;
            this.Duration_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_label.Location = new System.Drawing.Point(21, 192);
            this.Duration_label.Name = "Duration_label";
            this.Duration_label.Size = new System.Drawing.Size(109, 17);
            this.Duration_label.TabIndex = 26;
            this.Duration_label.Text = "Duration(in min)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // Exam_IDlabel
            // 
            this.Exam_IDlabel.AutoSize = true;
            this.Exam_IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exam_IDlabel.Location = new System.Drawing.Point(21, 40);
            this.Exam_IDlabel.Name = "Exam_IDlabel";
            this.Exam_IDlabel.Size = new System.Drawing.Size(59, 17);
            this.Exam_IDlabel.TabIndex = 24;
            this.Exam_IDlabel.Text = "Exam ID";
            // 
            // mcqSpilt
            // 
            this.mcqSpilt.Location = new System.Drawing.Point(136, 234);
            this.mcqSpilt.Name = "mcqSpilt";
            this.mcqSpilt.Size = new System.Drawing.Size(155, 20);
            this.mcqSpilt.TabIndex = 23;
            // 
            // ExamDuration
            // 
            this.ExamDuration.Location = new System.Drawing.Point(136, 189);
            this.ExamDuration.Name = "ExamDuration";
            this.ExamDuration.Size = new System.Drawing.Size(155, 20);
            this.ExamDuration.TabIndex = 22;
            // 
            // ExamID
            // 
            this.ExamID.Location = new System.Drawing.Point(136, 40);
            this.ExamID.Name = "ExamID";
            this.ExamID.Size = new System.Drawing.Size(155, 20);
            this.ExamID.TabIndex = 21;
            // 
            // ExamDate
            // 
            this.ExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExamDate.Location = new System.Drawing.Point(136, 119);
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Size = new System.Drawing.Size(155, 20);
            this.ExamDate.TabIndex = 34;
            // 
            // ExamTime
            // 
            this.ExamTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ExamTime.Location = new System.Drawing.Point(136, 157);
            this.ExamTime.Name = "ExamTime";
            this.ExamTime.ShowUpDown = true;
            this.ExamTime.Size = new System.Drawing.Size(155, 20);
            this.ExamTime.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Select Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Starting Time";
            // 
            // ExamGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExamTime);
            this.Controls.Add(this.ExamDate);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.DateTimePicker ExamDate;
        private System.Windows.Forms.DateTimePicker ExamTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}