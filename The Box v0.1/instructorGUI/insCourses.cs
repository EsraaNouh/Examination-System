using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace The_Box_v0._1.instructorGUI
{
    public partial class insCourses : Form
    {
        ExaminationSysEntities Ent = new ExaminationSysEntities();
        string user;
        Label[] labels;
        int i;
        int x; int y;
        public insCourses()
        {
            InitializeComponent();
        }
        public insCourses(string User)
        {
            InitializeComponent();
            user = User;
            labels = new Label[100];
            i = 0;
            x = 300; y = 120;
        }
        private void InsCourses_Load(object sender, EventArgs e)
        {
            var instid = (from i in Ent.Instructors where i.Ins_UserName == user select i.Ins_ID).First();
            var courses = Ent.Ins_Teach_Courses(instid);
            foreach (var c in courses)
            {
                labels[i] = new Label();
                labels[i].ForeColor = System.Drawing.Color.White;
                labels[i].Text = i + 1 + "-" + c.Course_Name;
                labels[i].Location = new System.Drawing.Point(x, y);
                labels[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Controls.Add(labels[i]);
                i++;
                y += 50;

            }
        }
    }
}