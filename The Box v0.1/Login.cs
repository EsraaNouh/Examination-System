using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public partial class Login : Form
    {
        ExaminationSysEntities Ent;
        public Login()
        {
            InitializeComponent();
            Ent = new ExaminationSysEntities();
        }
        private void Log_In_Button_Click(object sender, EventArgs e)
        {
            if (InsRadioBtn.Checked == true)
            {
                Instructor ins = Ent.InstructorsAuthentication(UserNameText.Text, passwordText.Text);
                if (ins != null)
                {
                    instructorGUI.InstructorMainForm Imf = new instructorGUI.InstructorMainForm(this, ins);
                    Imf.Show();
                    this.Hide();
                }
                else
                {
                    //
                    MessageBox.Show("Wrong Password .... try again ! ");
                }
            }
            else if (StuRadioBtn.Checked == true)
            {
                Student std = Ent.Studentuthentication(UserNameText.Text, passwordText.Text);
                if (std != null)
                {
                    MainForm stdForm = new MainForm(this, std);
                    stdForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password .... try again ! ");
                }
            }
            else if (AdminRadioBtn.Checked == true)
            {
                AdminForm adminForm = new AdminForm(this);
                adminForm.Show();
                this.Hide();
            }
            UserNameText.Text = passwordText.Text = string.Empty;
        }
    }
}
