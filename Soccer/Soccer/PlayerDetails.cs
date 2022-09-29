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
    public partial class PlayerDetails : Form
    {
        public PlayerDetails()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string name, type;

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Soccer].[dbo].[Employee].*,[Soccer].[dbo].[UserLogin].type FROM [Soccer].[dbo].[Employee],[Soccer].[dbo].[UserLogin] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[Employee].userID AND [Soccer].[dbo].[UserLogin].type = 'player'";

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query += " and Employee.Name like '%" + searchtxt.Text + "%'";
            }
            DataTable dt = DataAccess.LoadData(query);

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void ldbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[Employee].*,[Soccer].[dbo].[UserLogin].type,[Soccer].[dbo].[teamFormat].team  FROM [Soccer].[dbo].[Employee],[Soccer].[dbo].[UserLogin], [Soccer].[dbo].[teamFormat] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[Employee].userID AND [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[teamFormat].userID");

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            userid.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbTeam.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (cmbTeam.SelectedItem.ToString() != "")
            {
                string query = "";

                query = " update [Soccer].[dbo].[teamFormat] set team = '" + cmbTeam.SelectedItem.ToString() + "' where [Soccer].[dbo].[teamFormat].userID = '" + userid.Text + "'";

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

        private void homebtn_Click(object sender, EventArgs e)
        {
            Coach C = new Coach();
            C.name = this.name;
            C.type = this.type;
            C.Show();
            this.Hide();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerDetails_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }
    }
}
