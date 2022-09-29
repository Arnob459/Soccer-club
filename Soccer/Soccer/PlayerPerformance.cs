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
    public partial class PlayerPerformance : Form
    {
        public PlayerPerformance()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string name, type;

        private void PlayerPerformance_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Soccer].[dbo].[PlayerPerformance].*, [Soccer].[dbo].[Employee].name, [Soccer].[dbo].[UserLogin].type FROM [Soccer].[dbo].[PlayerPerformance],[Soccer].[dbo].[UserLogin], [Soccer].[dbo].[Employee] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[PlayerPerformance].userID AND [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[Employee].userID AND [Soccer].[dbo].[UserLogin].type = 'player'";

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query += " and Employee.Name like '%" + searchtxt.Text + "%'";
            }
            DataTable dt = DataAccess.LoadData(query);

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Coach C = new Coach();
            C.name = this.name;
            C.type = this.type;
            C.Show();
            this.Hide();
        }

        private void btnAddPerf_Click(object sender, EventArgs e)
        {
            AddPerformance Ap = new AddPerformance();
            Ap.name = this.name;
            Ap.type = this.type;
            Ap.Show();
            this.Hide();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            txtUid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
            cmbBall.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbPass.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbDrib.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbHead.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbFinish.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbAttack.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbDef.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbEndur.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmbSpd.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmbAgil.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            cmbStrn.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            cmbDriv.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            cmbAgg.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            cmbLeader.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBall.SelectedItem.ToString() != "" && cmbPass.SelectedItem.ToString() != "" && cmbDrib.SelectedItem.ToString() != "" && cmbHead.SelectedItem.ToString() != "" && cmbFinish.SelectedItem.ToString() != "" && cmbAttack.SelectedItem.ToString() != "" && cmbDef.SelectedItem.ToString() != "" && cmbEndur.SelectedItem.ToString() != "" && cmbSpd.SelectedItem.ToString() != "" && cmbAgil.SelectedItem.ToString() != "" && cmbStrn.SelectedItem.ToString() != "" && cmbDriv.SelectedItem.ToString() != "" && cmbAgg.SelectedItem.ToString() != "" && cmbLeader.SelectedItem.ToString() != "")
            {
                string query = "";

                query = " update [Soccer].[dbo].[PlayerPerformance] set Ball_Control= '" + cmbBall.SelectedItem.ToString() + "', Passing = '" + cmbPass.SelectedItem.ToString() + "', Dribbling = '" + cmbDrib.SelectedItem.ToString() + "', Heading = '" + cmbHead.SelectedItem.ToString() + "', Finishing = '" + cmbFinish.SelectedItem.ToString() + "', In_Attack = '" + cmbAttack.SelectedItem.ToString() + "', In_Defense = '" + cmbDef.SelectedItem.ToString() + "', Endurance = '" + cmbEndur.SelectedItem.ToString() + "', Speed = '" + cmbSpd.SelectedItem.ToString() + "', Agility = '" + cmbAgil.SelectedItem.ToString() + "', Strenth = '" + cmbStrn.SelectedItem.ToString() + "', Drive = '" + cmbDriv.SelectedItem.ToString() + "', Aggressiveness = '" + cmbAgg.SelectedItem.ToString() + "', Leadership = '" + cmbLeader.SelectedItem.ToString() + "' where [Soccer].[dbo].[PlayerPerformance].userID = '" + txtUid.Text + "'";

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


        private void ldbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT  [Soccer].[dbo].[PlayerPerformance].* , [Soccer].[dbo].[UserLogin].type, [Soccer].[dbo].[Employee].name FROM [Soccer].[dbo].[UserLogin], [Soccer].[dbo].[PlayerPerformance], [Soccer].[dbo].[Employee] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[PlayerPerformance].userID AND [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[Employee].userID");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }
    }
}
