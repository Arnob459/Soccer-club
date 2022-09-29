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
    public partial class ManageStaff : Form
    {
        public ManageStaff()
        {
            InitializeComponent();
        }

        public string name, type;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUid.Text != "" && txtWl.Text != "")
                {

                    string query;
                    query = "insert into [Soccer].[dbo].[WorkSchedule](userID, date, task) values('" + txtUid.Text + "','" + dateTimePicker1.Value + "', '" + txtWl.Text + "')";


                    int row = DataAccess.ExecuteQuery(query);


                    if (row > 0)
                    {
                        MessageBox.Show("Operation Completed");

                        ldbtn.PerformClick();
                    }

                }
                else
                    MessageBox.Show("You left something blank");
            }
            catch (Exception)
            {

                MessageBox.Show("You left something blank");
            }
        }

        private void ldbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[WorkSchedule].* FROM [Soccer].[dbo].[WorkSchedule]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();


            DataTable dt1 = DataAccess.LoadData("SELECT [Soccer].[dbo].[ReportFeedback].* FROM [Soccer].[dbo].[ReportFeedback]");

            dataGridView2.DataSource = dt1;
            dataGridView2.Refresh();
            dataGridView2.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUid.Text != "" && txtRp.Text != "")
                {

                    string query;
                    query = "insert into [Soccer].[dbo].[ReportFeedback](userID, date, remark) values('" + txtUid.Text + "','" + dateTimePicker1.Value + "', '" + txtRp.Text + "')";


                    int row = DataAccess.ExecuteQuery(query);


                    if (row > 0)
                    {
                        MessageBox.Show("Operation Completed");

                        ldbtn.PerformClick();
                    }

                }
                else
                    MessageBox.Show("You left something blank");
            }
            catch (Exception)
            {

                MessageBox.Show("You left something blank");
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            AdminHome c = new AdminHome();
            c.name = this.name;
            c.type = this.type;
            c.Show();
            this.Hide();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }
    }
}
