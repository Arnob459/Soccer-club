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
    public partial class AddPerformance : Form
    {
        public AddPerformance()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string name, type;

        private void btnSrc_Click(object sender, EventArgs e)
        {
            string query = "";

            if (!string.IsNullOrEmpty(txtUid.Text))
            {
                query = " SELECT [Soccer].[dbo].[Employee].name FROM [Soccer].[dbo].[Employee] where [Soccer].[dbo].[Employee].userID = '" + txtUid.Text + "'";
            }

            DataTable dt = DataAccess.LoadData(query);
            txtName.Text = dt.Rows[0]["name"].ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Coach C = new Coach();
            C.name = this.name;
            C.type = this.type;
            C.Show();
            this.Hide();
        }

        private void AddPerformance_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBall.SelectedItem.ToString() != "" && cmbPass.SelectedItem.ToString() != "" && cmbDrib.SelectedItem.ToString() != "" && cmbHead.SelectedItem.ToString() != "" && cmbFinish.SelectedItem.ToString() != "" && cmbAttack.SelectedItem.ToString() != "" && cmbDef.SelectedItem.ToString() != "" && cmbEndur.SelectedItem.ToString() != "" && cmbSpd.SelectedItem.ToString() != "" && cmbAgil.SelectedItem.ToString() != "" && cmbStrn.SelectedItem.ToString() != "" && cmbDriv.SelectedItem.ToString() != "" && cmbAgg.SelectedItem.ToString() != "" && cmbLeader.SelectedItem.ToString() != "")
                {
                    
                        string query;
                        query = "insert into [Soccer].[dbo].[PlayerPerformance](userID, Ball_Control, Passing, Dribbling, Heading, Finishing, In_Attack, In_Defense, Endurance, Speed, Agility, Strenth, Drive, Aggressiveness, Leadership) values('" + txtUid.Text + "','" + cmbBall.SelectedItem + "','" + cmbPass.SelectedItem + "','" + cmbDrib.SelectedItem + "','" + cmbHead.SelectedItem + "','" + cmbFinish.SelectedItem + "','" + cmbAttack.SelectedItem + "','" + cmbDef.SelectedItem + "','" + cmbEndur.SelectedItem + "','" + cmbSpd.SelectedItem + "','" + cmbAgil.SelectedItem + "','" + cmbStrn.SelectedItem + "','" + cmbDriv.SelectedItem + "','" + cmbAgg.SelectedItem + "','" + cmbLeader.SelectedItem + "')";


                        int row = DataAccess.ExecuteQuery(query);

                        if (row > 0)
                        {
                            MessageBox.Show("Operation Completed");

                            PlayerPerformance pp = new PlayerPerformance();
                            pp.name = this.name;
                            pp.Show();
                            this.Hide();
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
    }
}
