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
    public partial class ViewGrade : Form
    {
        string user;
        ExaminationSysEntities Ent = new ExaminationSysEntities();
        public ViewGrade()
        {
            InitializeComponent();
        }
        public ViewGrade(string User)
        {
            InitializeComponent();
            user = User;
        }
        private void Std_courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            grade_label.Text = string.Empty;
            var stdid = (from i in Ent.Students where i.Std_UserName == user select i.Std_ID).First();
            string choosenCourse = std_courses.Text;
            var g = Ent.std_crsname(stdid, choosenCourse).FirstOrDefault().Grade;
            grade_label.Text = "your grade is " + g.ToString();

        }
        private void ViewGrade_Load(object sender, EventArgs e)
        {
            std_courses.Items.Clear();
            var stdid = (from i in Ent.Students where i.Std_UserName == user select i.Std_ID).First();
            var courses = Ent.std_courses(stdid);
            foreach (var i in courses)
            {
                std_courses.Items.Add(i);
            }
        }
    }
}
