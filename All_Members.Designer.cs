namespace GUI_CW
{
    partial class All_Members
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Members));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.issueReturn = new System.Windows.Forms.Button();
            this.booksViewBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.AddMemberBtn = new System.Windows.Forms.Button();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.issueReturn);
            this.panel1.Controls.Add(this.booksViewBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 452);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // issueReturn
            // 
            this.issueReturn.BackColor = System.Drawing.Color.White;
            this.issueReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueReturn.Location = new System.Drawing.Point(14, 367);
            this.issueReturn.Name = "issueReturn";
            this.issueReturn.Size = new System.Drawing.Size(140, 46);
            this.issueReturn.TabIndex = 2;
            this.issueReturn.Text = "Issue / Return";
            this.issueReturn.UseVisualStyleBackColor = false;
            this.issueReturn.Click += new System.EventHandler(this.issueReturn_Click);
            // 
            // booksViewBtn
            // 
            this.booksViewBtn.BackColor = System.Drawing.Color.White;
            this.booksViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booksViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksViewBtn.Location = new System.Drawing.Point(14, 293);
            this.booksViewBtn.Name = "booksViewBtn";
            this.booksViewBtn.Size = new System.Drawing.Size(140, 46);
            this.booksViewBtn.TabIndex = 1;
            this.booksViewBtn.Text = "BOOKS";
            this.booksViewBtn.UseVisualStyleBackColor = false;
            this.booksViewBtn.Click += new System.EventHandler(this.booksViewBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.White;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.Black;
            this.dashboardBtn.Location = new System.Drawing.Point(14, 216);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(140, 46);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "DASHBOARD";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registered Members";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(199, 65);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(578, 307);
            this.dataGridViewUsers.TabIndex = 3;
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.BackColor = System.Drawing.Color.Red;
            this.AddMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberBtn.ForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.Location = new System.Drawing.Point(417, 396);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(194, 43);
            this.AddMemberBtn.TabIndex = 4;
            this.AddMemberBtn.Text = "Add Members";
            this.AddMemberBtn.UseVisualStyleBackColor = false;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.BackColor = System.Drawing.Color.Red;
            this.removeUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserBtn.ForeColor = System.Drawing.Color.White;
            this.removeUserBtn.Location = new System.Drawing.Point(639, 396);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(131, 43);
            this.removeUserBtn.TabIndex = 5;
            this.removeUserBtn.Text = "Remove";
            this.removeUserBtn.UseVisualStyleBackColor = false;
            this.removeUserBtn.Click += new System.EventHandler(this.removeUserBtn_Click);
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.BackColor = System.Drawing.Color.Red;
            this.ExitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLbl.ForeColor = System.Drawing.Color.White;
            this.ExitLbl.Location = new System.Drawing.Point(772, 9);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(16, 16);
            this.ExitLbl.TabIndex = 6;
            this.ExitLbl.Text = "X";
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // All_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitLbl);
            this.Controls.Add(this.removeUserBtn);
            this.Controls.Add(this.AddMemberBtn);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "All_Members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_Members";
            this.Load += new System.EventHandler(this.All_Members_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button issueReturn;
        private System.Windows.Forms.Button booksViewBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button AddMemberBtn;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.Label ExitLbl;
        private System.Windows.Forms.Timer timer2;
    }
}