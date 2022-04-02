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
    public partial class StudentAnswers : Form
    {
        Student student;
        ExaminationSysEntities Ent;
        int CrsID;
        int EID;
        public StudentAnswers()
        {
            InitializeComponent();
        }
        public StudentAnswers(Student std)
        {
            InitializeComponent();
            Ent = new ExaminationSysEntities();
            student = std;
        }

        private void StudentAnswers_Load(object sender, EventArgs e)
        {
            var Courses = Ent.GetStudentExams(student.Std_ID);
            foreach(var C_Exam in Courses)
            {
                string text = C_Exam.Course_Id.ToString() + " " + C_Exam.Course_Name;
                CrsComboBox.Items.Add(text);
                EComboBox.Items.Add(C_Exam.E_ID.ToString());
            } 
        }

        private void CrsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls.OfType<RadioButton>().ToList())
            {
                Controls.Remove(item);
            }
            foreach (Control item in Controls.OfType<Label>().ToList())
            {
                Controls.RemoveByKey("QL");
            }
            CrsID = int.Parse(CrsComboBox.Text.Split(' ')[0]);
            EComboBox.SelectedIndex = CrsComboBox.SelectedIndex;
            EID = int.Parse(EComboBox.Text);
            GradeTextBox.Visible = GradeLabel.Visible = true;
            GradeTextBox.Text = Ent.std_crs_select(student.Std_ID, CrsID, null).First().Grade.ToString();
            DisplayExam();
            //this.Enabled = false;
        }
        public void DisplayExam()
        {
            var Questions = Ent.ExamQuestions(EID, student.Std_ID);
            int LY = 70;
            int i = 1;
            Label Qlabel;
            foreach (var Q in Questions)
            {
                Qlabel = new Label();
                Qlabel.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Qlabel.Location = new Point(20, LY);
                Qlabel.Text = i.ToString() + " " + Q.Q_Text;
                Qlabel.Name = "QL";
                Qlabel.AutoSize = true;
                Controls.Add(Qlabel);
                LY += 20;
                i++;
                RadioButton radio;
                Label label;
                var choicesofQ = Ent.GetChoiceOfQ(Q.Q_ID).ToList();
                int lengthofChoice = choicesofQ.Count;
                for (int j = 0; j < lengthofChoice; j++)
                {
                    radio = new RadioButton();
                    label = new Label();
                    radio.Enabled = false;
                    radio.AutoSize = true;
                    label.AutoSize = true;
                    radio.Location = new Point(30, LY);
                    label.Location = new Point(45, LY);
                    label.ForeColor = Color.DarkGray;
                    if (lengthofChoice == 2)
                    {
                        radio.Name = (j == 0) ? "t" : "f";
                        label.Text = (j == 0) ? "True" : "False";
                    }
                    else
                    {
                        radio.Name = choicesofQ[j].ChoiceId.ToString();
                        label.Text = choicesofQ[j].Choice_text;
                    }
                    if(Q.Std_Answer == radio.Name)
                    {
                        radio.Checked = true;
                        label.ForeColor = (Q.Std_Answer == Q.Q_Model_Answer) ? Color.Black : Color.Red;
                    }
                    if(Q.Q_Model_Answer == radio.Name)
                    {
                        label.BackColor = Color.Green;
                        label.ForeColor = Color.Black;

                    }
                    LY += 20;
                    Controls.Add(radio);
                    Controls.Add(label);
                }
                LY += 20;
            }
        }
    }
}
