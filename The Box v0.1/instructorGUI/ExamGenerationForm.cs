using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1.instructorGUI
{
    public partial class ExamGenerationForm : Form
    {
        ExaminationSysEntities Ent;
        int InstructorID;
        int CourseID;
        public ExamGenerationForm()
        {
            InitializeComponent();
        }
        public ExamGenerationForm(int InsID)
        {
            InitializeComponent();
            InstructorID = InsID;
            Ent = new ExaminationSysEntities();
        }

        private void ExamGenerationForm_Load(object sender, EventArgs e)
        {
            var InsCourses = Ent.Ins_Teach_Courses(InstructorID);
            foreach (var InsCourse in InsCourses)
            {
                CourseNameOfExam.Items.Add(InsCourse.Course_Name);
            }
        }

        private void GenerateExam_Click(object sender, EventArgs e)
        {
            Ent.GetRandomQuestions(CourseID, int.Parse(ExamID.Text), int.Parse(ExamDuration.Text), InstructorID, int.Parse(mcqSpilt.Text), int.Parse(T_f_spilt.Text));
            MessageBox.Show("Exam generated successfully");

        }

        private void CourseNameOfExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseID = (int)Ent.GetCourseID(CourseNameOfExam.Text).First();
        }
    }
}
