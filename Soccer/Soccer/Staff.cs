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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            username.Text = name;
        }

        private void btnWs_Click(object sender, EventArgs e)
        {
            WorkSchedule ws = new WorkSchedule();
            ws.name = this.name;
            ws.type = this.type;
            ws.Show();
            this.Hide();
        }

        private void btnRf_Click(object sender, EventArgs e)
        {
            ReportFeedback rf = new ReportFeedback();
            rf.type = this.type;
            rf.name = this.name;
            rf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile pr = new Profile();
            pr.type = this.type;
            pr.name = this.name;
            pr.Show();
            this.Hide();
        }
    }
}
