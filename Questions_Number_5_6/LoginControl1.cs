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
    public delegate string UserDeposition(User user);

    public partial class LoginControl1 : UserControl
    {

        public event UserDeposition depositEvent;

        public LoginControl1()
        {
            InitializeComponent();
        }

        public string DepositAnnounce(User user)
        {
            return $"{user.UserName}, you deposited {user.Depositing} shekels";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            WrongDetailsLabel.Text = ClientsManagement.Login(Usernametxt.Text, Passwordtxt.Text);
            WrongDetailsLabel.Visible = true;
            if (WrongDetailsLabel.Text == "Wrong Details")
            {
                await Task.Delay(3000);
                WrongDetailsLabel.Visible = false;
            }

            if (WrongDetailsLabel.Text == $"Welcome {Usernametxt.Text}")
            {
                if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12) { statusLabel.Text = "Good Morning"; statusLabel.ForeColor = Color.Yellow; }
                else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18) { statusLabel.Text = "Good Noon"; statusLabel.ForeColor = Color.Red; }
                else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 20) { statusLabel.Text = "Good Afternoon"; statusLabel.ForeColor = Color.Blue; }
                else { statusLabel.Text = "Good Night"; statusLabel.ForeColor = Color.AliceBlue; }
                statusLabel.Visible = true;

                Usernametxt.ReadOnly = true;
                Passwordtxt.ReadOnly = true;

                groupBox2.Visible = true;
                groupBox3.Visible = true;

                await Task.Delay(5000);
                statusLabel.Visible = false;
                WrongDetailsLabel.Visible = false;
            }

            foreach (var client in ClientsManagement.clients)
            {
                if (client.UserName == Usernametxt.Text && client.Password == Passwordtxt.Text)
                {
                    balancetxt.Text = client.TotalMoneyInAccount.ToString();
                }
            }

        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {
            Passwordtxt.PasswordChar = '*';
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Usernametxt.ReadOnly = false;
            Passwordtxt.ReadOnly = false;

            Usernametxt.Clear();
            Passwordtxt.Clear();
            groupBox2.Visible = false;
            groupBox3.Visible = false;

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            int sum = 0;

            foreach (var client in ClientsManagement.clients)
            {
                if (client.UserName == Usernametxt.Text && client.Password == Passwordtxt.Text)
                {
                    balancetxt.ReadOnly = false;
                    totalCashtxt.ReadOnly = false;

                    client.Depositing = (int)numericUpDown1.Value;
                    client.TotalMoneyInAccount += client.Depositing;
                    depositEvent += DepositAnnounce;
                    balancetxt.Text = client.TotalMoneyInAccount.ToString();
                    balancetxt.ReadOnly = true;
                    DepositLabel.Text = depositEvent(client);
                    DepositLabel.Visible = true;
                }
            }
            foreach (var client in ClientsManagement.clients)
            {
                sum += client.TotalMoneyInAccount;
            }
            totalCashtxt.Text = sum.ToString();
            totalCashtxt.ReadOnly = true;
            await Task.Delay(3000);
            DepositLabel.Visible = false;
        }

        private void depositiontxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
