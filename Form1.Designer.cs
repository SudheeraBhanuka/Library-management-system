namespace GUI_CW
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.ViewUsersBtn = new System.Windows.Forms.Button();
            this.AllBooksViewBtn = new System.Windows.Forms.Button();
            this.IssueReturnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.noOfBooksTxt = new System.Windows.Forms.TextBox();
            this.noOfMembersTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(723, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 25);
            this.button3.TabIndex = 9;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewUsersBtn
            // 
            this.ViewUsersBtn.BackColor = System.Drawing.Color.Red;
            this.ViewUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewUsersBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUsersBtn.ForeColor = System.Drawing.Color.White;
            this.ViewUsersBtn.Location = new System.Drawing.Point(373, 208);
            this.ViewUsersBtn.Name = "ViewUsersBtn";
            this.ViewUsersBtn.Size = new System.Drawing.Size(200, 62);
            this.ViewUsersBtn.TabIndex = 8;
            this.ViewUsersBtn.Text = "Members";
            this.ViewUsersBtn.UseVisualStyleBackColor = false;
            this.ViewUsersBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AllBooksViewBtn
            // 
            this.AllBooksViewBtn.BackColor = System.Drawing.Color.Red;
            this.AllBooksViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllBooksViewBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBooksViewBtn.ForeColor = System.Drawing.Color.White;
            this.AllBooksViewBtn.Location = new System.Drawing.Point(157, 208);
            this.AllBooksViewBtn.Name = "AllBooksViewBtn";
            this.AllBooksViewBtn.Size = new System.Drawing.Size(200, 62);
            this.AllBooksViewBtn.TabIndex = 7;
            this.AllBooksViewBtn.Text = "All Books";
            this.AllBooksViewBtn.UseVisualStyleBackColor = false;
            this.AllBooksViewBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssueReturnBtn
            // 
            this.IssueReturnBtn.BackColor = System.Drawing.Color.Red;
            this.IssueReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IssueReturnBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueReturnBtn.ForeColor = System.Drawing.Color.White;
            this.IssueReturnBtn.Location = new System.Drawing.Point(588, 208);
            this.IssueReturnBtn.Name = "IssueReturnBtn";
            this.IssueReturnBtn.Size = new System.Drawing.Size(200, 62);
            this.IssueReturnBtn.TabIndex = 10;
            this.IssueReturnBtn.Text = "Issue and Return";
            this.IssueReturnBtn.UseVisualStyleBackColor = false;
            this.IssueReturnBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "No of Books :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "No of Members :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 45);
            this.label3.TabIndex = 13;
            this.label3.Text = "Library Management System";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Red;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(151, 450);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // noOfBooksTxt
            // 
            this.noOfBooksTxt.Location = new System.Drawing.Point(355, 330);
            this.noOfBooksTxt.Name = "noOfBooksTxt";
            this.noOfBooksTxt.ReadOnly = true;
            this.noOfBooksTxt.Size = new System.Drawing.Size(57, 20);
            this.noOfBooksTxt.TabIndex = 17;
            // 
            // noOfMembersTxt
            // 
            this.noOfMembersTxt.Location = new System.Drawing.Point(667, 332);
            this.noOfMembersTxt.Name = "noOfMembersTxt";
            this.noOfMembersTxt.ReadOnly = true;
            this.noOfMembersTxt.Size = new System.Drawing.Size(57, 20);
            this.noOfMembersTxt.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_CW.Properties.Resources.Screenshot_2024_12_02_154904;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.White;
            this.logOutBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.Red;
            this.logOutBtn.Location = new System.Drawing.Point(518, 414);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(151, 25);
            this.logOutBtn.TabIndex = 20;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.noOfMembersTxt);
            this.Controls.Add(this.noOfBooksTxt);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IssueReturnBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ViewUsersBtn);
            this.Controls.Add(this.AllBooksViewBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ViewUsersBtn;
        private System.Windows.Forms.Button AllBooksViewBtn;
        private System.Windows.Forms.Button IssueReturnBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox noOfBooksTxt;
        private System.Windows.Forms.TextBox noOfMembersTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logOutBtn;
    }
}

