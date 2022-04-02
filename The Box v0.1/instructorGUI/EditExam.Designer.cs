namespace The_Box_v0._1.instructorGUI
{
    partial class EditExam
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ExamTime = new System.Windows.Forms.DateTimePicker();
            this.ExamDate = new System.Windows.Forms.DateTimePicker();
            this.DurationText = new System.Windows.Forms.TextBox();
            this.Duration_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(487, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(66, 175);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 17);
            this.label23.TabIndex = 33;
            this.label23.Text = "Starting Time";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(66, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 17);
            this.label22.TabIndex = 32;
            this.label22.Text = "Select Date";
            // 
            // ExamTime
            // 
            this.ExamTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ExamTime.Location = new System.Drawing.Point(191, 175);
            this.ExamTime.Name = "ExamTime";
            this.ExamTime.ShowUpDown = true;
            this.ExamTime.Size = new System.Drawing.Size(155, 20);
            this.ExamTime.TabIndex = 31;
            // 
            // ExamDate
            // 
            this.ExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExamDate.Location = new System.Drawing.Point(191, 140);
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Size = new System.Drawing.Size(155, 20);
            this.ExamDate.TabIndex = 30;
            // 
            // DurationText
            // 
            this.DurationText.Location = new System.Drawing.Point(191, 210);
            this.DurationText.Name = "DurationText";
            this.DurationText.Size = new System.Drawing.Size(155, 20);
            this.DurationText.TabIndex = 22;
            // 
            // Duration_label
            // 
            this.Duration_label.AutoSize = true;
            this.Duration_label.BackColor = System.Drawing.Color.White;
            this.Duration_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_label.Location = new System.Drawing.Point(66, 211);
            this.Duration_label.Name = "Duration_label";
            this.Duration_label.Size = new System.Drawing.Size(109, 17);
            this.Duration_label.TabIndex = 24;
            this.Duration_label.Text = "Duration(in min)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Select Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Exam Id";
            // 
            // GenerateExam
            // 
            this.GenerateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateExam.Location = new System.Drawing.Point(153, 279);
            this.GenerateExam.Name = "GenerateExam";
            this.GenerateExam.Size = new System.Drawing.Size(133, 38);
            this.GenerateExam.TabIndex = 37;
            this.GenerateExam.Text = "Update";
            this.GenerateExam.UseVisualStyleBackColor = true;
            this.GenerateExam.Click += new System.EventHandler(this.GenerateExam_Click);
            // 
            // EditExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerateExam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.ExamTime);
            this.Controls.Add(this.ExamDate);
            this.Controls.Add(this.DurationText);
            this.Controls.Add(this.Duration_label);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "EditExam";
            this.Text = "EditExam";
            this.Load += new System.EventHandler(this.EditExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker ExamTime;
        private System.Windows.Forms.DateTimePicker ExamDate;
        private System.Windows.Forms.TextBox DurationText;
        private System.Windows.Forms.Label Duration_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateExam;
    }
}