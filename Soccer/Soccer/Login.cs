using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string type;
        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable table1 = DataAccess.LoadData("select * from [Soccer].[dbo].[UserLogin] where userID = '" + UserIdTextBox.Text + "' AND password = '" + PasswordTextBox.Text + "'");


            if (table1.Rows.Count != 1)
            {

                MessageBox.Show("wrong user Id or Password");

                UserIdTextBox.Clear();
                PasswordTextBox.Clear();
                return;


            }


            type = table1.Rows[0]["type"].ToString();


            if (type == "Admin")
            {
                AdminHome A = new AdminHome();
                A.name = UserIdTextBox.Text;
                A.type = this.type;
                A.Show();
                this.Hide();

            }

            else if (type == "Coach")
            {
                Coach c = new Coach();
                c.name = UserIdTextBox.Text;
                c.type = this.type;
                c.Show();
                this.Hide();
            }

            else if (type == "Player")
            {
                Player pl = new Player();
                pl.name = UserIdTextBox.Text;
                pl.type = this.type;
                pl.Show();
                this.Hide();
            }

            else if (type == "Staff")
            {
                Staff sf = new Staff();
                sf.name = UserIdTextBox.Text;
                sf.type = this.type;
                sf.Show();
                this.Hide();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass f = new ForgotPass();
            f.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
