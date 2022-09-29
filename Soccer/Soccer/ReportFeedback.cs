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
    public partial class ReportFeedback : Form
    {
        public ReportFeedback()
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
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[ReportFeedback].* FROM [Soccer].[dbo].[ReportFeedback] where [Soccer].[dbo].[ReportFeedback].userID = '" + name + "'");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.name = this.name;
            st.type = this.type;
            st.Show();
            this.Hide();
        }

        private void ReportFeedback_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }
    }
}
