using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace The_Box_v0._1.StudentGui
{
    public partial class StudentInfo : Form
    {
        ExaminationSysEntities Ent;
        string user;
        public StudentInfo()
        {
            InitializeComponent();
            Ent = new ExaminationSysEntities();
        }
        public StudentInfo(string User)
        {
            InitializeComponent();
            Ent = new ExaminationSysEntities();
            user = User;
        }
        private void StudentInfo_Load(object sender, EventArgs e)
        {
            var stdid = (from i in Ent.Students where i.Std_UserName == user select i.Std_ID).First();
            var student = Ent.Students.Find(stdid);
            Name.Text = student.Std_Name;
            Age.Text = student.Std_Age.ToString();
            UserNameT.Text = student.Std_UserName;
            Email.Text = student.Std_Email;
            TrackId.Text = student.Track_Id.ToString();
            LeaderIdT.Text = student.Leader_ID.ToString();
        }
    }
}
