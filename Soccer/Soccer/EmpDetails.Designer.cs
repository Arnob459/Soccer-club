namespace Soccer
{
    partial class EmpDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpDetails));
            this.button1 = new System.Windows.Forms.Button();
            this.userid = new System.Windows.Forms.TextBox();
            this.useridlbl = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editbtn = new System.Windows.Forms.Button();
            this.dlbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.ldbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(770, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 85;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(811, 242);
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Size = new System.Drawing.Size(151, 20);
            this.userid.TabIndex = 84;
            // 
            // useridlbl
            // 
            this.useridlbl.AutoSize = true;
            this.useridlbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.useridlbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridlbl.ForeColor = System.Drawing.Color.Yellow;
            this.useridlbl.Location = new System.Drawing.Point(717, 242);
            this.useridlbl.Name = "useridlbl";
            this.useridlbl.Size = new System.Drawing.Size(76, 28);
            this.useridlbl.TabIndex = 83;
            this.useridlbl.Text = "User ID:";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchbtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.Yellow;
            this.searchbtn.Location = new System.Drawing.Point(407, 61);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(106, 34);
            this.searchbtn.TabIndex = 82;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(180, 69);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(221, 20);
            this.searchtxt.TabIndex = 81;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(811, 191);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(151, 20);
            this.idtxt.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(755, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 79;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // salarytxt
            // 
            this.salarytxt.Location = new System.Drawing.Point(811, 397);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(151, 20);
            this.salarytxt.TabIndex = 78;
            // 
            // typetxt
            // 
            this.typetxt.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "Admin",
            "Coach",
            "Player"});
            this.typetxt.Location = new System.Drawing.Point(811, 296);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(151, 27);
            this.typetxt.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(717, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 28);
            this.label9.TabIndex = 76;
            this.label9.Text = "Salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(738, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 28);
            this.label7.TabIndex = 75;
            this.label7.Text = "Type:";
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editbtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.Yellow;
            this.editbtn.Location = new System.Drawing.Point(770, 342);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(106, 34);
            this.editbtn.TabIndex = 74;
            this.editbtn.Text = "Update";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // dlbtn
            // 
            this.dlbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dlbtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlbtn.ForeColor = System.Drawing.Color.Yellow;
            this.dlbtn.Location = new System.Drawing.Point(602, 55);
            this.dlbtn.Name = "dlbtn";
            this.dlbtn.Size = new System.Drawing.Size(106, 34);
            this.dlbtn.TabIndex = 73;
            this.dlbtn.Text = "Delete";
            this.dlbtn.UseVisualStyleBackColor = false;
            this.dlbtn.Click += new System.EventHandler(this.dlbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homebtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.Yellow;
            this.homebtn.Location = new System.Drawing.Point(734, 55);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(106, 34);
            this.homebtn.TabIndex = 72;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // ldbtn
            // 
            this.ldbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ldbtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldbtn.ForeColor = System.Drawing.Color.Yellow;
            this.ldbtn.Location = new System.Drawing.Point(30, 61);
            this.ldbtn.Name = "ldbtn";
            this.ldbtn.Size = new System.Drawing.Size(106, 34);
            this.ldbtn.TabIndex = 71;
            this.ldbtn.Text = "Load";
            this.ldbtn.UseVisualStyleBackColor = false;
            this.ldbtn.Click += new System.EventHandler(this.ldbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 358);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.useridlbl);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salarytxt);
            this.Controls.Add(this.typetxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.dlbtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.ldbtn);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "EmpDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmpDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.Label useridlbl;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button dlbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button ldbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}