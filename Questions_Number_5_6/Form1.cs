using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questions_Number_5_6
{
    public partial class Form1 : Form
    {

        

        public string SuccessLogin(User user)
        {
            string status;
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12) { status = "Good Morning"; }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18) { status = "Good Noon"; }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 20) { status = "Good Afternoon"; }
            else { status = "Good Night"; }
            return $"Welcom {user.UserName}, {status}";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control1 = new LoginControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(control1);

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
    }
}
