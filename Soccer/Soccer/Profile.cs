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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        public string type, name;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "Admin")
            {
                AdminHome A = new AdminHome();
                A.name = this.name;
                A.type = this.type;
                A.Show();
                this.Hide();

            }

            else if (type == "Coach")
            {
                Coach c = new Coach();
                c.name = this.name;
                c.type = this.type;
                c.Show();
                this.Hide();
            }

            else if (type == "Player")
            {
                Player pl = new Player();
                pl.name = this.name;
                pl.type = this.type;
                pl.Show();
                this.Hide();
            }
            else if (type == "Staff")
            {
                Staff st = new Staff();
                st.name = this.name;
                st.type = this.type;
                st.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.type = this.type;
            ep.name = this.name;
            ep.Show();
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[Employee].*,[Soccer].[dbo].[UserLogin].type FROM [Soccer].[dbo].[Employee],[Soccer].[dbo].[UserLogin] where [Soccer].[dbo].[UserLogin].userID = '" + name + "' and [Soccer].[dbo].[Employee].userID = '" + name + "'");


            namelb.Text = dt.Rows[0]["name"].ToString();
            addresslb.Text = dt.Rows[0]["address"].ToString();
            emaillb.Text = dt.Rows[0]["userID"].ToString();
            phonelb.Text = dt.Rows[0]["phone"].ToString();
            genderlb.Text = dt.Rows[0]["gender"].ToString();
            typelb.Text = dt.Rows[0]["type"].ToString();
            nidlb.Text = dt.Rows[0]["nid"].ToString();
            salarylb.Text = dt.Rows[0]["salary"].ToString();
            joindatelb.Text = dt.Rows[0]["joindate"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
