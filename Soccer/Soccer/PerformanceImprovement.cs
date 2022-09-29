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
    public partial class PerformanceImprovement : Form
    {
        public PerformanceImprovement()
        {
            InitializeComponent();
        }
        public string name, type;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Player c = new Player();
            c.name = this.name;
            c.type = this.type;
            c.Show();
            this.Hide();
        }

        private void ldbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[PlayerPerformance].* FROM [Soccer].[dbo].[PlayerPerformance] where [Soccer].[dbo].[PlayerPerformance].userID = '" + name + "'");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void PerformanceImprovement_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }
    }
}
