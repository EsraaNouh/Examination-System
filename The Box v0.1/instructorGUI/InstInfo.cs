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
    public partial class InstInfo : Form
    {
        ExaminationSysEntities Ent;
        string user;
        public InstInfo()
        {
            InitializeComponent();
            Ent = new ExaminationSysEntities();
        }
        public InstInfo(string User)
        {
            InitializeComponent();
            Ent = new ExaminationSysEntities();
            user = User;
        }
        private void InstInfo_Load(object sender, EventArgs e)
        {
            var instid = (from i in Ent.Instructors where i.Ins_UserName == user select i.Ins_ID).First();
            var instructor = Ent.Instructors.Find(instid);
            Name.Text = instructor.Ins_Name;
            UserNameT.Text = instructor.Ins_UserName;
            Email.Text = instructor.Ins_Email;
        }
    }
}
