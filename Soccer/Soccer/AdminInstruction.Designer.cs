namespace Soccer
{
    partial class AdminInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInstruction));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homebtn = new System.Windows.Forms.Button();
            this.ldbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homebtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(649, 29);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(106, 41);
            this.homebtn.TabIndex = 86;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // ldbtn
            // 
            this.ldbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ldbtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldbtn.Location = new System.Drawing.Point(59, 29);
            this.ldbtn.Name = "ldbtn";
            this.ldbtn.Size = new System.Drawing.Size(106, 41);
            this.ldbtn.TabIndex = 85;
            this.ldbtn.Text = "Load";
            this.ldbtn.UseVisualStyleBackColor = false;
            this.ldbtn.Click += new System.EventHandler(this.ldbtn_Click);
            // 
            // AdminInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 579);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.ldbtn);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "AdminInstruction";
            this.Text = "Admin Instruction";
            this.Load += new System.EventHandler(this.AdminInstruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button ldbtn;
    }
}