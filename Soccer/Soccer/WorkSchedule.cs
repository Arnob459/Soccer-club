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
    public partial class WorkSchedule : Form
    {
        public WorkSchedule()
        {
            InitializeComponent();
        }

        public string name, type;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void WorkSchedule_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.name = this.name;
            st.type = this.type;
            st.Show();
            this.Hide();
        }

        private void ldbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[WorkSchedule].* FROM [Soccer].[dbo].[WorkSchedule] where [Soccer].[dbo].[WorkSchedule].userID = '" + name + "'");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }
    }
}
