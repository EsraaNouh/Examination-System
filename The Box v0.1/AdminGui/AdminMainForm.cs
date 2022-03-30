using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1.AdminGui
{
    public partial class AdminMainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Color color;
        Login loginPage;


        public AdminMainForm()
        {
            InitializeComponent();
        }

        public AdminMainForm(Login login)
        {
            InitializeComponent();
            loginPage = login;
            random = new Random();
            CloseFormbtn.Visible = false;


        }

        private void WelcPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HdrPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
