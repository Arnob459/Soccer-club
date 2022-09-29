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
    public partial class CoachInstruction : Form
    {
        public CoachInstruction()
        {
            InitializeComponent();
        }
        public string name, type;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void ldbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[CoachInstruction].* FROM [Soccer].[dbo].[CoachInstruction]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            AdminHome c = new AdminHome();
            c.name = this.name;
            c.type = this.type;
            c.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtUid.Text != "" &&  txtMsg.Text != "")
                {
                    
                        string query;
                        query = "insert into [Soccer].[dbo].[CoachInstruction](UserID,message,date) values('" + txtUid.Text + "','" + txtMsg.Text + "','" + dateTimePicker1.Value + "')";


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

        private void CoachInstruction_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();

        }
    }
}
