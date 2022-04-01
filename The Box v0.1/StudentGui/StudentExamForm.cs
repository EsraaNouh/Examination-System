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
        int DurationForExam = 0;
        Timer TimerPerExam = new Timer();
        Timer TimerForEachSecond = new Timer();






        private void TimerElapsedforExam(object sender, EventArgs e)
        {

            TimerPerExam.Stop();
            TimerForEachSecond.Stop();

            foreach (var box in Groupsbox)
            {
                box.Visible = false;

            }
            TimerLabel.Visible = false;
            Submit_Exam_Btn.Visible = false;
            NextQ.Visible = false;


        }
        private void DecreaseOneSecondInExamTimer(object sender, EventArgs e)
        {
            DurationForExam = DurationForExam - 1;
            TimeSpan t = TimeSpan.FromSeconds(DurationForExam);

            string DurationWithTimeFormat = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                  t.Hours,
                  t.Minutes,
                  t.Seconds
                );
            TimerLabel.Text = DurationWithTimeFormat;

        }
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
            int examId = Exam[0].E_ID;
            var durationPerMins = (from ex in Ent.Exams
                     where ex.E_ID == examId
                     select ex.E_Duration).FirstOrDefault();
            DurationForExam = (Int32)durationPerMins * 60;
            timerConfig((Int32)DurationForExam);

        }
        private void timerConfig(int timeInSecond)

        {


            TimerPerExam.Interval = timeInSecond* 1000;
            TimerPerExam.Tick += new EventHandler(TimerElapsedforExam);
        TimerPerExam.Start();


            TimerForEachSecond.Interval = 1000;
            TimerForEachSecond.Tick += new EventHandler(DecreaseOneSecondInExamTimer);
        TimerForEachSecond.Start();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
