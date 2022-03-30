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
            this.SuspendLayout();
            // 
            // ChooseCourselabel
            // 
            this.ChooseCourselabel.AutoSize = true;
            this.ChooseCourselabel.Location = new System.Drawing.Point(62, 45);
            this.ChooseCourselabel.Name = "ChooseCourselabel";
            this.ChooseCourselabel.Size = new System.Drawing.Size(105, 17);
            this.ChooseCourselabel.TabIndex = 0;
            this.ChooseCourselabel.Text = "Choose Course";
            // 
            // ChooseCourse
            // 
            this.ChooseCourse.FormattingEnabled = true;
            this.ChooseCourse.Location = new System.Drawing.Point(234, 42);
            this.ChooseCourse.Name = "ChooseCourse";
            this.ChooseCourse.Size = new System.Drawing.Size(121, 24);
            this.ChooseCourse.TabIndex = 1;
            // 
            // Start_Exam_Btn
            // 
            this.Start_Exam_Btn.Location = new System.Drawing.Point(436, 38);
            this.Start_Exam_Btn.Name = "Start_Exam_Btn";
            this.Start_Exam_Btn.Size = new System.Drawing.Size(106, 31);
            this.Start_Exam_Btn.TabIndex = 2;
            this.Start_Exam_Btn.Text = "Start Exam";
            this.Start_Exam_Btn.UseVisualStyleBackColor = true;
            this.Start_Exam_Btn.Click += new System.EventHandler(this.Start_Exam_Btn_Click);
            // 
            // NextQ
            // 
            this.NextQ.Location = new System.Drawing.Point(325, 410);
            this.NextQ.Name = "NextQ";
            this.NextQ.Size = new System.Drawing.Size(115, 28);
            this.NextQ.TabIndex = 3;
            this.NextQ.Text = "Next Question";
            this.NextQ.UseVisualStyleBackColor = true;
            this.NextQ.Click += new System.EventHandler(this.NextQ_Click);
            // 
            // Submit_Exam_Btn
            // 
            this.Submit_Exam_Btn.Location = new System.Drawing.Point(706, 411);
            this.Submit_Exam_Btn.Name = "Submit_Exam_Btn";
            this.Submit_Exam_Btn.Size = new System.Drawing.Size(75, 27);
            this.Submit_Exam_Btn.TabIndex = 4;
            this.Submit_Exam_Btn.Text = "Submit";
            this.Submit_Exam_Btn.UseVisualStyleBackColor = true;
            this.Submit_Exam_Btn.Click += new System.EventHandler(this.Submit_Exam_Btn_Click);
            // 
            // StudentExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit_Exam_Btn);
            this.Controls.Add(this.NextQ);
            this.Controls.Add(this.Start_Exam_Btn);
            this.Controls.Add(this.ChooseCourse);
            this.Controls.Add(this.ChooseCourselabel);
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
    }
}