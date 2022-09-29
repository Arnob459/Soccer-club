namespace Soccer
{
    partial class PlayerDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDetails));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.ldbtn = new System.Windows.Forms.Button();
            this.dlbtn = new System.Windows.Forms.Button();
            this.userid = new System.Windows.Forms.TextBox();
            this.useridlbl = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 430);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(434, 63);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(106, 34);
            this.searchbtn.TabIndex = 84;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(207, 71);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(221, 20);
            this.searchtxt.TabIndex = 83;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // ldbtn
            // 
            this.ldbtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldbtn.Location = new System.Drawing.Point(36, 63);
            this.ldbtn.Name = "ldbtn";
            this.ldbtn.Size = new System.Drawing.Size(106, 34);
            this.ldbtn.TabIndex = 85;
            this.ldbtn.Text = "Load";
            this.ldbtn.UseVisualStyleBackColor = true;
            this.ldbtn.Click += new System.EventHandler(this.ldbtn_Click);
            // 
            // dlbtn
            // 
            this.dlbtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlbtn.Location = new System.Drawing.Point(695, 57);
            this.dlbtn.Name = "dlbtn";
            this.dlbtn.Size = new System.Drawing.Size(119, 47);
            this.dlbtn.TabIndex = 86;
            this.dlbtn.Text = "Delete";
            this.dlbtn.UseVisualStyleBackColor = true;
            this.dlbtn.Click += new System.EventHandler(this.dlbtn_Click);
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(752, 243);
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Size = new System.Drawing.Size(151, 20);
            this.userid.TabIndex = 90;
            // 
            // useridlbl
            // 
            this.useridlbl.AutoSize = true;
            this.useridlbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridlbl.Location = new System.Drawing.Point(631, 241);
            this.useridlbl.Name = "useridlbl";
            this.useridlbl.Size = new System.Drawing.Size(76, 28);
            this.useridlbl.TabIndex = 89;
            this.useridlbl.Text = "User ID:";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(752, 182);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(151, 20);
            this.idtxt.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 87;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 91;
            this.label2.Text = "Team Assign";
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Terminated"});
            this.cmbTeam.Location = new System.Drawing.Point(623, 351);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(234, 21);
            this.cmbTeam.TabIndex = 92;
            // 
            // editbtn
            // 
            this.editbtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Location = new System.Drawing.Point(664, 426);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(106, 34);
            this.editbtn.TabIndex = 93;
            this.editbtn.Text = "Update";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(894, 57);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(132, 47);
            this.homebtn.TabIndex = 94;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // PlayerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 736);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.useridlbl);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dlbtn);
            this.Controls.Add(this.ldbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "PlayerDetails";
            this.Text = "Player Details";
            this.Load += new System.EventHandler(this.PlayerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button ldbtn;
        private System.Windows.Forms.Button dlbtn;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.Label useridlbl;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button homebtn;
    }
}