﻿namespace GUI_CW
{
    partial class IssueBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.memberIDtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookIDtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateIssued = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 50);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Book";
            // 
            // memberIDtxt
            // 
            this.memberIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDtxt.Location = new System.Drawing.Point(17, 106);
            this.memberIDtxt.Name = "memberIDtxt";
            this.memberIDtxt.Size = new System.Drawing.Size(251, 26);
            this.memberIDtxt.TabIndex = 6;
            this.memberIDtxt.TextChanged += new System.EventHandler(this.memberIDtxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member ID:";
            // 
            // bookIDtxt
            // 
            this.bookIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDtxt.Location = new System.Drawing.Point(18, 178);
            this.bookIDtxt.Name = "bookIDtxt";
            this.bookIDtxt.Size = new System.Drawing.Size(251, 26);
            this.bookIDtxt.TabIndex = 8;
            this.bookIDtxt.TextChanged += new System.EventHandler(this.bookIDtxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book ID:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(18, 304);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.ReadOnly = true;
            this.nameTxt.Size = new System.Drawing.Size(251, 26);
            this.nameTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Full Name:";
            // 
            // bookNameTxt
            // 
            this.bookNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameTxt.Location = new System.Drawing.Point(19, 368);
            this.bookNameTxt.Name = "bookNameTxt";
            this.bookNameTxt.ReadOnly = true;
            this.bookNameTxt.Size = new System.Drawing.Size(251, 26);
            this.bookNameTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Book:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(189, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Issue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Date:";
            // 
            // dateIssued
            // 
            this.dateIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIssued.Location = new System.Drawing.Point(19, 236);
            this.dateIssued.Name = "dateIssued";
            this.dateIssued.Size = new System.Drawing.Size(251, 26);
            this.dateIssued.TabIndex = 25;
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateIssued);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookIDtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memberIDtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBook";
            this.Text = "IssueBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memberIDtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookIDtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateIssued;
    }
}