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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentExamForm));
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
            this.ChooseCourselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCourselabel.Location = new System.Drawing.Point(47, 36);
            this.ChooseCourselabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseCourselabel.Name = "ChooseCourselabel";
            this.ChooseCourselabel.Size = new System.Drawing.Size(105, 17);
            this.ChooseCourselabel.TabIndex = 0;
            this.ChooseCourselabel.Text = "Choose Course";
            // 
            // ChooseCourse
            // 
            this.ChooseCourse.FormattingEnabled = true;
            this.ChooseCourse.Location = new System.Drawing.Point(175, 34);
            this.ChooseCourse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ChooseCourse.Name = "ChooseCourse";
            this.ChooseCourse.Size = new System.Drawing.Size(92, 21);
            this.ChooseCourse.TabIndex = 1;
            // 
            // Start_Exam_Btn
            // 
            this.Start_Exam_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Exam_Btn.Location = new System.Drawing.Point(327, 31);
            this.Start_Exam_Btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Start_Exam_Btn.Name = "Start_Exam_Btn";
            this.Start_Exam_Btn.Size = new System.Drawing.Size(79, 25);
            this.Start_Exam_Btn.TabIndex = 2;
            this.Start_Exam_Btn.Text = "Start Exam";
            this.Start_Exam_Btn.UseVisualStyleBackColor = true;
            this.Start_Exam_Btn.Click += new System.EventHandler(this.Start_Exam_Btn_Click);
            // 
            // NextQ
            // 
            this.NextQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQ.Location = new System.Drawing.Point(33, 143);
            this.NextQ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NextQ.Name = "NextQ";
            this.NextQ.Size = new System.Drawing.Size(107, 31);
            this.NextQ.TabIndex = 3;
            this.NextQ.Text = "Next Question";
            this.NextQ.UseVisualStyleBackColor = true;
            this.NextQ.Click += new System.EventHandler(this.NextQ_Click);
            // 
            // Submit_Exam_Btn
            // 
            this.Submit_Exam_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Exam_Btn.Location = new System.Drawing.Point(33, 188);
            this.Submit_Exam_Btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Submit_Exam_Btn.Name = "Submit_Exam_Btn";
            this.Submit_Exam_Btn.Size = new System.Drawing.Size(65, 31);
            this.Submit_Exam_Btn.TabIndex = 4;
            this.Submit_Exam_Btn.Text = "Submit";
            this.Submit_Exam_Btn.UseVisualStyleBackColor = true;
            this.Submit_Exam_Btn.Click += new System.EventHandler(this.Submit_Exam_Btn_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(452, 53);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(0, 17);
            this.TimerLabel.TabIndex = 5;
            // 
            // StudentExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.Submit_Exam_Btn);
            this.Controls.Add(this.NextQ);
            this.Controls.Add(this.Start_Exam_Btn);
            this.Controls.Add(this.ChooseCourse);
            this.Controls.Add(this.ChooseCourselabel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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