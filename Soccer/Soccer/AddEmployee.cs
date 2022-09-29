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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        public string name, type;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametxt.Text != "" && addtxt.Text != "" && phonetxt.Text != "" && gentxt.SelectedItem.ToString() != "" && nidtxt.Text != "" && saltxt.Text != "" && uidtxt.Text != "" && typetxt.SelectedItem.ToString() != "" && passtxt.Text != "" && cpasstxt.Text != "" && qsntxt.SelectedItem.ToString() != "" && anstxt.Text != "")
                {
                    if (passtxt.Text == cpasstxt.Text)
                    {
                        string query;
                        query = "insert into [Soccer].[dbo].[Employee](name,address,phone,gender,nid,salary,joindate,userID) values('" + nametxt.Text + "','" + addtxt.Text + "','" + phonetxt.Text + "','" + gentxt.SelectedItem + "','" + nidtxt.Text + "','" + saltxt.Text + "','" + dateTimePicker1.Value + "','" + uidtxt.Text + "')";


                        int row = DataAccess.ExecuteQuery(query);


                        //login access
                        string query1;
                        query1 = "insert into [Soccer].[dbo].[UserLogin](userID,password,type,qsn,ans) values('" + uidtxt.Text + "','" + passtxt.Text + "','" + typetxt.SelectedItem + "','" + qsntxt.SelectedItem + "','" + anstxt.Text + "')";


                        int row1 = DataAccess.ExecuteQuery1(query1);

                        if ((row > 0) && (row1 > 0))
                        {
                            MessageBox.Show("Operation Completed");

                            AdminHome A = new AdminHome();
                            A.name = this.name;
                            A.Show();
                            this.Hide();
                        }
                    }
                    else
                        MessageBox.Show("Password did not match");
                }
                else
                    MessageBox.Show("You left something blank");
            }
            catch (Exception)
            {

                MessageBox.Show("You left something blank");
            }

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminHome A = new AdminHome();
            A.name = this.name;
            A.type = this.type;
            A.Show();
            this.Hide();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
    }
}
