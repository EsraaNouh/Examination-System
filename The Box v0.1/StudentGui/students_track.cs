using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public partial class students_track : Form
    {
        ExaminationSysEntities Ent = new ExaminationSysEntities();
        string user;
        Label[] labels;
        int i;
        int x; int y;

        public students_track()
        {
            InitializeComponent();
        }
        public students_track(string User)
        {
            InitializeComponent();
            user = User;
            labels = new Label[100];
            i = 0;
            x = 300; y = 120;

        }
        private void Students_track_Load(object sender, EventArgs e)
        {
            var stdid = (from i in Ent.Students where i.Std_UserName == user select i.Std_ID).First();
            int trackid = Ent.SelectStudentById(stdid).First().Track_Id;
            var studentList = from s in Ent.Students where s.Track_Id == trackid select s;
            foreach (var s in studentList)
            {
                labels[i] = new Label();
                labels[i].ForeColor = System.Drawing.Color.White;
                labels[i].Text = i + 1 + "-" + s.Std_Name;
                labels[i].Location = new System.Drawing.Point(x, y);
                labels[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Controls.Add(labels[i]);
                i++;
                y += 50;
            }
        }
    }
}
