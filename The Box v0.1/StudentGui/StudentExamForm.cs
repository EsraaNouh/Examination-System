using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1.StudentGui
{
    public partial class StudentExamForm : Form
    {
        ExaminationSysEntities Ent;
        Student student;
        List<GroupBox> Groupsbox = new List<GroupBox>();
        int iteratorOfQ = 0;
        List<GetRandomExam_Result> Exam = new List<GetRandomExam_Result>();
        List<string> QAnswers = new List<string>();
        string QAnswer;
        public StudentExamForm()
        {
            InitializeComponent();
        }
        public StudentExamForm(Student std)
        {
            InitializeComponent();
            student = std;
            Ent = new ExaminationSysEntities();
        }

        private void StudentExamForm_Load(object sender, EventArgs e)
        {
            var StudCourses = Ent.GetStudentCourses(student.Std_ID);
            foreach (var StudCourse in StudCourses)
            {
                ChooseCourse.Items.Add(StudCourse);
            }
        }
        private void Start_Exam_Btn_Click(object sender, EventArgs e)
        {
            Exam = Ent.ShowExam(ChooseCourse.Text, Groupsbox, this);
        }
        private void NextQ_Click(object sender, EventArgs e)
        {
            foreach (GroupBox boxIterator in Groupsbox)
            {
                boxIterator.Visible = false;
                List<RadioButton> rbs = boxIterator.Controls.OfType<RadioButton>().ToList();
                foreach (RadioButton rb in rbs)
                {
                    if (rb.Checked)
                    {
                        QAnswer = rb.Name;
                    }
                }
            }
            QAnswers.Add(QAnswer);
            Groupsbox[(++iteratorOfQ) % Groupsbox.Count].Visible = true;
        }
        private void Submit_Exam_Btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Ent.ExamAnswer(student.Std_ID, Exam[i].E_ID, Exam[i].Q_ID, QAnswers[i]);
            }
            Ent.ExamCorrection(Exam[0].E_ID, student.Std_ID);
        }
    }
}
