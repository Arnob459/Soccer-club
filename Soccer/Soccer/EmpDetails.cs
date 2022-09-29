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
    public partial class EmpDetails : Form
    {
        public EmpDetails()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string name, type;

        private void ldbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[Employee].*,[Soccer].[dbo].[UserLogin].type FROM [Soccer].[dbo].[Employee],[Soccer].[dbo].[UserLogin] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[Employee].userID");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Soccer].[dbo].[Employee].*,[Soccer].[dbo].[UserLogin].type FROM [Soccer].[dbo].[Employee],[Soccer].[dbo].[UserLogin] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[Employee].userID";

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query += " and Employee.Name like '%" + searchtxt.Text + "%'";
            }
            DataTable dt = DataAccess.LoadData(query);

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void dlbtn_Click(object sender, EventArgs e)
        {
            if (idtxt.Text == "")
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }

            int row = DataAccess.ExecuteQuery("delete from [Soccer].[dbo].[UserLogin] where [Soccer].[dbo].[UserLogin].userID='" + userid.Text + "'");
            if (row > 0)
            {
                MessageBox.Show("Deleted");
                ldbtn.PerformClick();

            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            AdminHome A = new AdminHome();
            A.name = this.name;
            A.type = this.type;
            A.Show();
            this.Hide();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (typetxt.SelectedItem.ToString() != "")
            {
                string query = "";

                query = " update [Soccer].[dbo].[UserLogin] set type = '" + typetxt.SelectedItem.ToString() + "' where [Soccer].[dbo].[UserLogin].userID = '" + userid.Text + "'";

                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    ldbtn.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("left something blank");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (salarytxt.Text != "")
            {
                string query = "";


                query = "update [Soccer].[dbo].[Employee] set salary='" + salarytxt.Text + "' where [Soccer].[dbo].[Employee].id = '" + idtxt.Text + "'";

                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    ldbtn.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("left something blank");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            salarytxt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            userid.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            typetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpDetails_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }
    }
}
