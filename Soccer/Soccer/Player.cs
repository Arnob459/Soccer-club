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
    public partial class Player : Form
    {
        public Player()
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

        private void btnWm_Click(object sender, EventArgs e)
        {
            WorkoutMonitor wm = new WorkoutMonitor();
            wm.type = this.type;
            wm.name = this.name;
            wm.Show();
            this.Hide();
        }

        private void btnPmi_Click(object sender, EventArgs e)
        {
            PerformanceImprovement pmi = new PerformanceImprovement();
            pmi.type = this.type;
            pmi.name = this.name;
            pmi.Show();
            this.Hide();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            username.Text = name;

        }
    }
}
