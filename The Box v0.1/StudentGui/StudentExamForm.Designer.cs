namespace The_Box_v0._1.StudentGui
{
    partial class StudentExamForm
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
            this.ChooseCourselabel = new System.Windows.Forms.Label();
            this.ChooseCourse = new System.Windows.Forms.ComboBox();
            this.Start_Exam_Btn = new System.Windows.Forms.Button();
            this.NextQ = new System.Windows.Forms.Button();
            this.Submit_Exam_Btn = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseCourselabel
            // 
            this.ChooseCourselabel.AutoSize = true;
            this.ChooseCourselabel.Location = new System.Drawing.Point(46, 37);
            this.ChooseCourselabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseCourselabel.Name = "ChooseCourselabel";
            this.ChooseCourselabel.Size = new System.Drawing.Size(79, 13);
            this.ChooseCourselabel.TabIndex = 0;
            this.ChooseCourselabel.Text = "Choose Course";
            // 
            // ChooseCourse
            // 
            this.ChooseCourse.FormattingEnabled = true;
            this.ChooseCourse.Location = new System.Drawing.Point(176, 34);
            this.ChooseCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseCourse.Name = "ChooseCourse";
            this.ChooseCourse.Size = new System.Drawing.Size(92, 21);
            this.ChooseCourse.TabIndex = 1;
            // 
            // Start_Exam_Btn
            // 
            this.Start_Exam_Btn.Location = new System.Drawing.Point(327, 31);
            this.Start_Exam_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_Exam_Btn.Name = "Start_Exam_Btn";
            this.Start_Exam_Btn.Size = new System.Drawing.Size(80, 25);
            this.Start_Exam_Btn.TabIndex = 2;
            this.Start_Exam_Btn.Text = "Start Exam";
            this.Start_Exam_Btn.UseVisualStyleBackColor = true;
            this.Start_Exam_Btn.Click += new System.EventHandler(this.Start_Exam_Btn_Click);
            // 
            // NextQ
            // 
            this.NextQ.Location = new System.Drawing.Point(244, 333);
            this.NextQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NextQ.Name = "NextQ";
            this.NextQ.Size = new System.Drawing.Size(86, 23);
            this.NextQ.TabIndex = 3;
            this.NextQ.Text = "Next Question";
            this.NextQ.UseVisualStyleBackColor = true;
            this.NextQ.Click += new System.EventHandler(this.NextQ_Click);
            // 
            // Submit_Exam_Btn
            // 
            this.Submit_Exam_Btn.Location = new System.Drawing.Point(530, 334);
            this.Submit_Exam_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Submit_Exam_Btn.Name = "Submit_Exam_Btn";
            this.Submit_Exam_Btn.Size = new System.Drawing.Size(56, 22);
            this.Submit_Exam_Btn.TabIndex = 4;
            this.Submit_Exam_Btn.Text = "Submit";
            this.Submit_Exam_Btn.UseVisualStyleBackColor = true;
            this.Submit_Exam_Btn.Click += new System.EventHandler(this.Submit_Exam_Btn_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(461, 37);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(35, 13);
            this.TimerLabel.TabIndex = 5;
            this.TimerLabel.Text = "label1";
            this.TimerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StudentExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.Submit_Exam_Btn);
            this.Controls.Add(this.NextQ);
            this.Controls.Add(this.Start_Exam_Btn);
            this.Controls.Add(this.ChooseCourse);
            this.Controls.Add(this.ChooseCourselabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentExamForm";
            this.Text = "StudentExamForm";
            this.Load += new System.EventHandler(this.StudentExamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseCourselabel;
        private System.Windows.Forms.ComboBox ChooseCourse;
        private System.Windows.Forms.Button Start_Exam_Btn;
        private System.Windows.Forms.Button NextQ;
        private System.Windows.Forms.Button Submit_Exam_Btn;
        private System.Windows.Forms.Label TimerLabel;
    }
}