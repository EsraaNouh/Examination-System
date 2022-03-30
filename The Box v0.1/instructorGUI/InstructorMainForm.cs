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
    public partial class InstructorMainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Color color;
        Login loginPage;
        Instructor instructor;
        string User;
        public InstructorMainForm()
        {
            InitializeComponent();
        }
        public InstructorMainForm(Login login, Instructor ins)
        {
            InitializeComponent();
            loginPage = login;
            random = new Random();
            CloseFormbtn.Visible = false;
            instructor = ins;
            User = ins.Ins_UserName;
        }
        private Color SelectThemeColor()
        {

            string color = ThemeColor.ColorList[0];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Trebuchet MS", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    HdrPanel.BackColor = color;
                    WelcPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    CloseFormbtn.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in LeftPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //  ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(childForm);
            this.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //    boxLabel.Text = childForm.Text;
        }

        private void Inst_label_Click(object sender, EventArgs e)
        {

        }

        private void CloseFormbtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            //boxLabel.Text = "Examination System";
            HdrPanel.BackColor = Color.FromArgb(0, 150, 136);
            WelcPanel.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            CloseFormbtn.Visible = false;
        }

        private void MaximizeAppbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignoutBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Close();
            loginPage.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InsertQ(), sender);
            //InsertQ form = new InsertQ();
            //form.Show();
        }

        private void StudentInfo_label_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InstInfo(User), sender);
        }

        private void Courses_Label_Click(object sender, EventArgs e)
        {
            OpenChildForm(new insCourses(User), sender);
        }

        private void Gen_Exam_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExamGenerationForm(instructor.Ins_ID), sender);
        }
    }
}
