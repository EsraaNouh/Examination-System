namespace The_Box_v0._1.instructorGUI
{
    partial class InstructorMainForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WelcPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inst_label = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowMessage = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HdrPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Gen_Exam_Btn = new System.Windows.Forms.Button();
            this.InsertQ_label = new System.Windows.Forms.Button();
            this.Courses_Label = new System.Windows.Forms.Button();
            this.StudentInfo_label = new System.Windows.Forms.Button();
            this.addTrackLabel = new System.Windows.Forms.Button();
            this.Add_ins_label = new System.Windows.Forms.Button();
            this.AddExam_label = new System.Windows.Forms.Button();
            this.topicsInCourseLabel = new System.Windows.Forms.Button();
            this.Courses_per_int_label = new System.Windows.Forms.Button();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.SignoutBtn = new System.Windows.Forms.Button();
            this.CloseFormbtn = new System.Windows.Forms.Button();
            this.CloseAppbtn = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.MaximizeAppbtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.WelcPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.HdrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.addTrackLabel);
            this.panel3.Controls.Add(this.Add_ins_label);
            this.panel3.Controls.Add(this.AddExam_label);
            this.panel3.Controls.Add(this.topicsInCourseLabel);
            this.panel3.Controls.Add(this.Courses_per_int_label);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(862, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 522);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Will be array of Labels defined with size of array";
            // 
            // WelcPanel
            // 
            this.WelcPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.WelcPanel.Controls.Add(this.panel4);
            this.WelcPanel.Controls.Add(this.StudentName);
            this.WelcPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.WelcPanel.Location = new System.Drawing.Point(0, 0);
            this.WelcPanel.Name = "WelcPanel";
            this.WelcPanel.Size = new System.Drawing.Size(190, 78);
            this.WelcPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.inst_label);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 78);
            this.panel4.TabIndex = 2;
            // 
            // inst_label
            // 
            this.inst_label.AutoSize = true;
            this.inst_label.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.inst_label.Location = new System.Drawing.Point(-6, 22);
            this.inst_label.Name = "inst_label";
            this.inst_label.Size = new System.Drawing.Size(203, 35);
            this.inst_label.TabIndex = 1;
            this.inst_label.Text = "InstructorName";
            this.inst_label.Click += new System.EventHandler(this.Inst_label_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.Gen_Exam_Btn);
            this.panel2.Controls.Add(this.InsertQ_label);
            this.panel2.Controls.Add(this.Courses_Label);
            this.panel2.Controls.Add(this.StudentInfo_label);
            this.panel2.Controls.Add(this.ShowMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 436);
            this.panel2.TabIndex = 2;
            // 
            // ShowMessage
            // 
            this.ShowMessage.AutoSize = true;
            this.ShowMessage.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.ShowMessage.ForeColor = System.Drawing.Color.White;
            this.ShowMessage.Location = new System.Drawing.Point(183, 124);
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.Size = new System.Drawing.Size(396, 23);
            this.ShowMessage.TabIndex = 23;
            this.ShowMessage.Text = "Will be array of Labels defined with size of array";
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.panel2);
            this.ImagePanel.Controls.Add(this.panel3);
            this.ImagePanel.Controls.Add(this.MainImage);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(190, 436);
            this.ImagePanel.TabIndex = 4;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.LeftPanel.Controls.Add(this.ImagePanel);
            this.LeftPanel.Controls.Add(this.SignoutBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.LeftPanel.Location = new System.Drawing.Point(0, 78);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(190, 490);
            this.LeftPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.LeftPanel);
            this.panel1.Controls.Add(this.WelcPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 568);
            this.panel1.TabIndex = 6;
            // 
            // HdrPanel
            // 
            this.HdrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.HdrPanel.Controls.Add(this.CloseFormbtn);
            this.HdrPanel.Controls.Add(this.CloseAppbtn);
            this.HdrPanel.Controls.Add(this.Minimize);
            this.HdrPanel.Controls.Add(this.MaximizeAppbtn);
            this.HdrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HdrPanel.Location = new System.Drawing.Point(0, 0);
            this.HdrPanel.Name = "HdrPanel";
            this.HdrPanel.Size = new System.Drawing.Size(985, 48);
            this.HdrPanel.TabIndex = 7;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.BackgroundImage = global::The_Box_v0._1.Properties.Resources.iti_logo;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainPanel.CausesValidation = false;
            this.MainPanel.Location = new System.Drawing.Point(187, 51);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(833, 562);
            this.MainPanel.TabIndex = 8;
            // 
            // Gen_Exam_Btn
            // 
            this.Gen_Exam_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gen_Exam_Btn.FlatAppearance.BorderSize = 0;
            this.Gen_Exam_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gen_Exam_Btn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gen_Exam_Btn.ForeColor = System.Drawing.Color.White;
            this.Gen_Exam_Btn.Image = global::The_Box_v0._1.Properties.Resources.Letter_Q_icon;
            this.Gen_Exam_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gen_Exam_Btn.Location = new System.Drawing.Point(0, 101);
            this.Gen_Exam_Btn.Name = "Gen_Exam_Btn";
            this.Gen_Exam_Btn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Gen_Exam_Btn.Size = new System.Drawing.Size(190, 34);
            this.Gen_Exam_Btn.TabIndex = 32;
            this.Gen_Exam_Btn.Text = "Generate Exam";
            this.Gen_Exam_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gen_Exam_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Gen_Exam_Btn.UseVisualStyleBackColor = true;
            this.Gen_Exam_Btn.Click += new System.EventHandler(this.Gen_Exam_Btn_Click);
            // 
            // InsertQ_label
            // 
            this.InsertQ_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertQ_label.FlatAppearance.BorderSize = 0;
            this.InsertQ_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertQ_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertQ_label.ForeColor = System.Drawing.Color.White;
            this.InsertQ_label.Image = global::The_Box_v0._1.Properties.Resources.Letter_Q_icon;
            this.InsertQ_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertQ_label.Location = new System.Drawing.Point(0, 67);
            this.InsertQ_label.Name = "InsertQ_label";
            this.InsertQ_label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.InsertQ_label.Size = new System.Drawing.Size(190, 34);
            this.InsertQ_label.TabIndex = 30;
            this.InsertQ_label.Text = "Insert Question";
            this.InsertQ_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertQ_label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsertQ_label.UseVisualStyleBackColor = true;
            this.InsertQ_label.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Courses_Label
            // 
            this.Courses_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Courses_Label.FlatAppearance.BorderSize = 0;
            this.Courses_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Courses_Label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_Label.ForeColor = System.Drawing.Color.White;
            this.Courses_Label.Image = global::The_Box_v0._1.Properties.Resources.Product_sale_report_icon;
            this.Courses_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Courses_Label.Location = new System.Drawing.Point(0, 32);
            this.Courses_Label.Name = "Courses_Label";
            this.Courses_Label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Courses_Label.Size = new System.Drawing.Size(190, 35);
            this.Courses_Label.TabIndex = 25;
            this.Courses_Label.Text = "Courses";
            this.Courses_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Courses_Label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Courses_Label.UseVisualStyleBackColor = true;
            this.Courses_Label.Click += new System.EventHandler(this.Courses_Label_Click);
            // 
            // StudentInfo_label
            // 
            this.StudentInfo_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentInfo_label.FlatAppearance.BorderSize = 0;
            this.StudentInfo_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentInfo_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInfo_label.ForeColor = System.Drawing.Color.White;
            this.StudentInfo_label.Image = global::The_Box_v0._1.Properties.Resources.Product_sale_report_icon;
            this.StudentInfo_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentInfo_label.Location = new System.Drawing.Point(0, 0);
            this.StudentInfo_label.Name = "StudentInfo_label";
            this.StudentInfo_label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.StudentInfo_label.Size = new System.Drawing.Size(190, 32);
            this.StudentInfo_label.TabIndex = 24;
            this.StudentInfo_label.Text = "Instructor Info";
            this.StudentInfo_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentInfo_label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StudentInfo_label.UseVisualStyleBackColor = true;
            this.StudentInfo_label.Click += new System.EventHandler(this.StudentInfo_label_Click);
            // 
            // addTrackLabel
            // 
            this.addTrackLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTrackLabel.FlatAppearance.BorderSize = 0;
            this.addTrackLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTrackLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTrackLabel.ForeColor = System.Drawing.Color.White;
            this.addTrackLabel.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.addTrackLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTrackLabel.Location = new System.Drawing.Point(0, 161);
            this.addTrackLabel.Name = "addTrackLabel";
            this.addTrackLabel.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.addTrackLabel.Size = new System.Drawing.Size(178, 40);
            this.addTrackLabel.TabIndex = 28;
            this.addTrackLabel.Text = "Add Track";
            this.addTrackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTrackLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addTrackLabel.UseVisualStyleBackColor = true;
            // 
            // Add_ins_label
            // 
            this.Add_ins_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_ins_label.FlatAppearance.BorderSize = 0;
            this.Add_ins_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_ins_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_ins_label.ForeColor = System.Drawing.Color.White;
            this.Add_ins_label.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.Add_ins_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_ins_label.Location = new System.Drawing.Point(0, 121);
            this.Add_ins_label.Name = "Add_ins_label";
            this.Add_ins_label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Add_ins_label.Size = new System.Drawing.Size(178, 40);
            this.Add_ins_label.TabIndex = 27;
            this.Add_ins_label.Text = "Add instructor";
            this.Add_ins_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_ins_label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add_ins_label.UseVisualStyleBackColor = true;
            // 
            // AddExam_label
            // 
            this.AddExam_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddExam_label.FlatAppearance.BorderSize = 0;
            this.AddExam_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExam_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExam_label.ForeColor = System.Drawing.Color.White;
            this.AddExam_label.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.AddExam_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddExam_label.Location = new System.Drawing.Point(0, 79);
            this.AddExam_label.Name = "AddExam_label";
            this.AddExam_label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.AddExam_label.Size = new System.Drawing.Size(178, 42);
            this.AddExam_label.TabIndex = 26;
            this.AddExam_label.Text = "Add Exam";
            this.AddExam_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddExam_label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddExam_label.UseVisualStyleBackColor = true;
            // 
            // topicsInCourseLabel
            // 
            this.topicsInCourseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topicsInCourseLabel.FlatAppearance.BorderSize = 0;
            this.topicsInCourseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topicsInCourseLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicsInCourseLabel.ForeColor = System.Drawing.Color.White;
            this.topicsInCourseLabel.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.topicsInCourseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topicsInCourseLabel.Location = new System.Drawing.Point(0, 38);
            this.topicsInCourseLabel.Name = "topicsInCourseLabel";
            this.topicsInCourseLabel.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.topicsInCourseLabel.Size = new System.Drawing.Size(178, 41);
            this.topicsInCourseLabel.TabIndex = 25;
            this.topicsInCourseLabel.Text = "topics In Course";
            this.topicsInCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topicsInCourseLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topicsInCourseLabel.UseVisualStyleBackColor = true;
            // 
            // Courses_per_int_label
            // 
            this.Courses_per_int_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Courses_per_int_label.FlatAppearance.BorderSize = 0;
            this.Courses_per_int_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Courses_per_int_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_per_int_label.ForeColor = System.Drawing.Color.White;
            this.Courses_per_int_label.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.Courses_per_int_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Courses_per_int_label.Location = new System.Drawing.Point(0, 0);
            this.Courses_per_int_label.Name = "Courses_per_int_label";
            this.Courses_per_int_label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Courses_per_int_label.Size = new System.Drawing.Size(178, 38);
            this.Courses_per_int_label.TabIndex = 24;
            this.Courses_per_int_label.Text = "Courses per ins";
            this.Courses_per_int_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Courses_per_int_label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Courses_per_int_label.UseVisualStyleBackColor = true;
            // 
            // MainImage
            // 
            this.MainImage.Location = new System.Drawing.Point(0, 0);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(800, 344);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainImage.TabIndex = 0;
            this.MainImage.TabStop = false;
            // 
            // SignoutBtn
            // 
            this.SignoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignoutBtn.FlatAppearance.BorderSize = 0;
            this.SignoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignoutBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignoutBtn.ForeColor = System.Drawing.Color.White;
            this.SignoutBtn.Image = global::The_Box_v0._1.Properties.Resources.logout;
            this.SignoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignoutBtn.Location = new System.Drawing.Point(0, 436);
            this.SignoutBtn.Name = "SignoutBtn";
            this.SignoutBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.SignoutBtn.Size = new System.Drawing.Size(190, 54);
            this.SignoutBtn.TabIndex = 3;
            this.SignoutBtn.Text = "  SignOut";
            this.SignoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SignoutBtn.UseVisualStyleBackColor = true;
            this.SignoutBtn.Click += new System.EventHandler(this.SignoutBtn_Click);
            // 
            // CloseFormbtn
            // 
            this.CloseFormbtn.FlatAppearance.BorderSize = 0;
            this.CloseFormbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormbtn.Image = global::The_Box_v0._1.Properties.Resources.close__1_;
            this.CloseFormbtn.Location = new System.Drawing.Point(18, 12);
            this.CloseFormbtn.Name = "CloseFormbtn";
            this.CloseFormbtn.Size = new System.Drawing.Size(26, 25);
            this.CloseFormbtn.TabIndex = 2;
            this.CloseFormbtn.UseVisualStyleBackColor = true;
            this.CloseFormbtn.Click += new System.EventHandler(this.CloseFormbtn_Click);
            // 
            // CloseAppbtn
            // 
            this.CloseAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppbtn.FlatAppearance.BorderSize = 0;
            this.CloseAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppbtn.Image = global::The_Box_v0._1.Properties.Resources.close__2_;
            this.CloseAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseAppbtn.Location = new System.Drawing.Point(952, 3);
            this.CloseAppbtn.Name = "CloseAppbtn";
            this.CloseAppbtn.Size = new System.Drawing.Size(28, 23);
            this.CloseAppbtn.TabIndex = 5;
            this.CloseAppbtn.UseVisualStyleBackColor = true;
            this.CloseAppbtn.Click += new System.EventHandler(this.CloseAppbtn_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = global::The_Box_v0._1.Properties.Resources.minus;
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize.Location = new System.Drawing.Point(884, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(28, 23);
            this.Minimize.TabIndex = 4;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // MaximizeAppbtn
            // 
            this.MaximizeAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeAppbtn.FlatAppearance.BorderSize = 0;
            this.MaximizeAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeAppbtn.Image = global::The_Box_v0._1.Properties.Resources.fullscreen;
            this.MaximizeAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MaximizeAppbtn.Location = new System.Drawing.Point(918, 3);
            this.MaximizeAppbtn.Name = "MaximizeAppbtn";
            this.MaximizeAppbtn.Size = new System.Drawing.Size(28, 23);
            this.MaximizeAppbtn.TabIndex = 3;
            this.MaximizeAppbtn.UseVisualStyleBackColor = true;
            this.MaximizeAppbtn.Click += new System.EventHandler(this.MaximizeAppbtn_Click);
            // 
            // InstructorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 616);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HdrPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstructorMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.WelcPanel.ResumeLayout(false);
            this.WelcPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.HdrPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addTrackLabel;
        private System.Windows.Forms.Button Add_ins_label;
        private System.Windows.Forms.Button AddExam_label;
        private System.Windows.Forms.Button topicsInCourseLabel;
        internal System.Windows.Forms.Button Courses_per_int_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Courses_Label;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.Button SignoutBtn;
        private System.Windows.Forms.Panel WelcPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label inst_label;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Panel MainPanel;
        internal System.Windows.Forms.Button StudentInfo_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ShowMessage;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseAppbtn;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button MaximizeAppbtn;
        private System.Windows.Forms.Button CloseFormbtn;
        private System.Windows.Forms.Panel HdrPanel;
        private System.Windows.Forms.Button InsertQ_label;
        private System.Windows.Forms.Button Gen_Exam_Btn;
    }
}