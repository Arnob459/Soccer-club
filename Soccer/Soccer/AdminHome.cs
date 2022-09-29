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
    public partial class AdminHome : Form
    {
        public AdminHome()
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

        private void aempbtn_Click(object sender, EventArgs e)
        {
            AddEmployee emp = new AddEmployee();
            emp.name = this.name;
            emp.type = this.type;
            emp.Show();
            this.Hide();
        }

        private void empdetbtn_Click(object sender, EventArgs e)
        {
            EmpDetails ed = new EmpDetails();
            ed.name = this.name;
            ed.type = this.type;
            ed.Show();
            this.Hide();
        }

        private void btnCi_Click(object sender, EventArgs e)
        {
            CoachInstruction ci = new CoachInstruction();
            ci.name = this.name;
            ci.type = this.type;
            ci.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageStaff ms = new ManageStaff();
            ms.name = this.name;
            ms.type = this.type;
            ms.Show();
            this.Hide();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            username.Text = name;
        }
    }
}
