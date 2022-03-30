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
    public partial class ViewCourses : Form
    {
        ExaminationSysEntities Ent = new ExaminationSysEntities();
        string user;
        Label[] labels;
        int i;
        int x; int y;
        public ViewCourses()
        {
            InitializeComponent();
        }
        public ViewCourses(string User)
        {
            InitializeComponent();
            user = User;
            labels = new Label[100];
            i = 0;
            x = 300; y = 150;
        }
        private void ViewCourses_Load(object sender, EventArgs e)
        {

            var stdid = (from i in Ent.Students where i.Std_UserName == user select i.Std_ID).First();
            var courses = Ent.std_courses(stdid);
            foreach (var c in courses)
            {
                labels[i] = new Label();
                labels[i].ForeColor = System.Drawing.Color.White;
                labels[i].Text = i + 1 + "-" + c;
                labels[i].Location = new System.Drawing.Point(x, y);
                labels[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Controls.Add(labels[i]);
                i++;
                y += 50;

            }
        }
    }
}
