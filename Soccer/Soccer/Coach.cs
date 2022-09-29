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
    public partial class Coach : Form
    {
        public Coach()
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
            Profile pr = new Profile();
            pr.type = this.type;
            pr.name = this.name;
            pr.Show();
            this.Hide();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            PlayerInstruction pi = new PlayerInstruction();
            pi.name = this.name;
            pi.type = this.type;
            pi.Show();
            this.Hide();
        }

        private void btnPd_Click(object sender, EventArgs e)
        {
            PlayerDetails pd = new PlayerDetails();
            pd.name = this.name;
            pd.type = this.type;
            pd.Show();
            this.Hide();
        }

        private void btnTm_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayerPerformance pf = new PlayerPerformance();
            pf.name = this.name;
            pf.type = this.type;
            pf.Show();
            this.Hide();
        }

        private void btnRt_Click(object sender, EventArgs e)
        {
            ReportingTime rt = new ReportingTime();
            rt.name = this.name;
            rt.type = this.type;
            rt.Show();
            this.Hide();
        }

        private void btnAi_Click(object sender, EventArgs e)
        {
            AdminInstruction ai = new AdminInstruction();
            ai.name = this.name;
            ai.type = this.type;
            ai.Show();
            this.Hide();
        }

        private void btnWi_Click(object sender, EventArgs e)
        {
            WorkoutInstruction wi = new WorkoutInstruction();
            wi.name = this.name;
            wi.type = this.type;
            wi.Show();
            this.Hide();
        }

        private void Coach_Load(object sender, EventArgs e)
        {
            username.Text = name;

        }
    }
}
