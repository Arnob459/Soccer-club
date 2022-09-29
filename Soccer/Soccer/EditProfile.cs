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

    
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        public string type, name;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametxt.Text != "" && addresstxt.Text != "" && phonetxt.Text != "" && gendertxt.SelectedItem.ToString() != "" && nidtxt.Text != "")
            {
                string query = "";

                query = "  update [Soccer].[dbo].[Employee] set name='" + nametxt.Text + "',address='" + addresstxt.Text + "',phone='" + phonetxt.Text + "',gender='" + gendertxt.SelectedItem + "',nid='" + nidtxt.Text + "' where [Soccer].[dbo].[Employee].userID = '" + name + "'";


                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("left something blank");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.name = this.name;
            cp.type = this.type;
            cp.Show();
            this.Hide();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            if (type == "Coach")
            {
                typetxt.Enabled = false;
            }
            else if (type == "Player")
            {
                typetxt.Enabled = false;

            }
            else if (type == "Staff")
            {
                typetxt.Enabled = false;

            }

            DataTable dt = DataAccess.LoadData("SELECT [Soccer].[dbo].[Employee].*,[Soccer].[dbo].[UserLogin].type FROM [Soccer].[dbo].[Employee],[Soccer].[dbo].[UserLogin] where [Soccer].[dbo].[UserLogin].userID = '" + name + "' and [Soccer].[dbo].[Employee].userID = '" + name + "'");


            nametxt.Text = dt.Rows[0]["name"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
            emailtxt.Text = dt.Rows[0]["userID"].ToString();
            phonetxt.Text = dt.Rows[0]["phone"].ToString();
            gendertxt.Text = dt.Rows[0]["gender"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            nidtxt.Text = dt.Rows[0]["nid"].ToString();

        }

        
    }
}
