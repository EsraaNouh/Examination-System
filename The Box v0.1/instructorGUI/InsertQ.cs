using System;
using System.Windows.Forms;

namespace The_Box_v0._1.instructorGUI
{
    public partial class InsertQ : Form
    {
        ExaminationSysEntities Ent = new ExaminationSysEntities();
        string Q_type;
        int Q_id;
        string Qtext;
        string correctAnswer;
        int courseID;

        public InsertQ()
        {
            InitializeComponent();


        }
        private void MCQ_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (MCQ_radio.Checked)
            {
                EnterCH_label.Visible = true;
                a_label.Visible = b_label.Visible = c_label.Visible = d_label.Visible = true;
                a_txt.Visible = b_txt.Visible = c_txt.Visible = d_txt.Visible = true;

            }
            else
            {
                EnterCH_label.Visible = false;
                a_label.Visible = b_label.Visible = c_label.Visible = d_label.Visible = false;
                a_txt.Visible = b_txt.Visible = c_txt.Visible = d_txt.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MCQ_radio.Checked == true)
            {
                Q_type = "MCQ";
                Ent.InsertChoice("a", a_txt.Text, Q_id + 1);
                Ent.InsertChoice("b", b_txt.Text, Q_id + 1);
                Ent.InsertChoice("c", c_txt.Text, Q_id + 1);
                Ent.InsertChoice("d", d_txt.Text, Q_id + 1);
            }
            else
            {
                Q_type = "T/F";

            }
            Qtext = Q_text.Text;
            correctAnswer = Corr_Ans.Text;
            courseID = int.Parse(crsID.Text);
            //Q_id = int.Parse(Ent.Q_Last_id().ToString());
            Ent.InsertQuestion(Q_type, Qtext, correctAnswer, courseID);













        }
    }
}
