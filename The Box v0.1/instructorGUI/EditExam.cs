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
    public partial class EditExam : Form
    {
        ExaminationSysEntities Ent;
        int InstructorID;
        public EditExam()
        {
            InitializeComponent();
        }
        public EditExam(int InsID)
        {
            InitializeComponent();
            Ent = new ExaminationSysEntities();
            InstructorID = InsID;
        }

        private void EditExam_Load(object sender, EventArgs e)
        {
            var InsCourses = Ent.Ins_Teach_Courses(InstructorID);
            foreach (var InsCourse in InsCourses)
            {
                comboBox2.Items.Add(InsCourse.Course_Id+" "+ InsCourse.Course_Name);
            }
        }

        private void GenerateExam_Click(object sender, EventArgs e)
        {
            try
            {
                string Exam_Time = ExamTime.Value.TimeOfDay.ToString();
                Ent.Update_Exam(int.Parse(comboBox1.Text), int.Parse(DurationText.Text), ExamDate.Value, Exam_Time);
                MessageBox.Show("Updated Successfully");
            }
            catch
            {

            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var exam = Ent.SelectExam(int.Parse(comboBox1.Text)).First();
            ExamDate.Value = (DateTime)exam.Date;
            ExamTime.Value = Convert.ToDateTime(exam.Start_Time.ToString());
            DurationText.Text = exam.E_Duration.ToString();
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox2.Text.Split(' ')[0]);
            var exams = Ent.Course_Exams(id);
            foreach(var ex in exams)
            {
                comboBox1.Items.Add(ex.Value.ToString());
            }
        }
    }
}
