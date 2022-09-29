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
    public partial class WorkoutInstruction : Form
    {
        public WorkoutInstruction()
        {
            InitializeComponent();
        }
        public string name, type;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUid.Text != "" && txtWl.Text != "")
                {

                    string query;
                    query = "insert into [Soccer].[dbo].[WorkoutMonitor](workout_list,date,userID) values('" + txtWl.Text + "','" + dateTimePicker1.Value + "','" + txtUid.Text + "')";


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
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[WorkoutMonitor].* FROM [Soccer].[dbo].[WorkoutMonitor]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Coach c = new Coach();
            c.name = this.name;
            c.type = this.type;
            c.Show();
            this.Hide();
        }

        private void WorkoutInstruction_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }
    }
}
