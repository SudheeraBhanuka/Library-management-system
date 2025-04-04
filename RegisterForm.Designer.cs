﻿namespace GUI_CW
{
    partial class RegisterForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.signin_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(208, 457);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.Red;
            this.signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_btn.FlatAppearance.BorderSize = 0;
            this.signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.signin_btn.ForeColor = System.Drawing.Color.White;
            this.signin_btn.Location = new System.Drawing.Point(28, 600);
            this.signin_btn.Margin = new System.Windows.Forms.Padding(2);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(281, 40);
            this.signin_btn.TabIndex = 20;
            this.signin_btn.Text = "SIGN IN";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 575);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Register Account";
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Red;
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(28, 517);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(281, 40);
            this.register_btn.TabIndex = 19;
            this.register_btn.Text = "REGISTER";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(28, 423);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxt.Multiline = true;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(281, 30);
            this.passwordTxt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(30, 348);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(281, 30);
            this.usernameTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 31);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Register";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(28, 273);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(281, 30);
            this.emailTxt.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email Address:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_CW.Properties.Resources.Screenshot_2024_12_02_154904;
            this.pictureBox1.Location = new System.Drawing.Point(108, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 679);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label6;
    }
}