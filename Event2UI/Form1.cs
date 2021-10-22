using Question_Number_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event2UI
{
    public partial class Form1 : Form
    {
        Client client = new Client();

        public Form1()
        {
            InitializeComponent();
            client.LongNameEntered += LongNameHandler;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            client.Name = txtName.Text;
        }

        private void LongNameHandler()
        {
            MessageBox.Show("Let the client know what an intresting name");
        }
    }
}
