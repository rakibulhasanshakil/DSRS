namespace DSRS
{
    partial class Form2
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
            this.password_txt = new System.Windows.Forms.TextBox();
            this.userid_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registration_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resetpassword_lLbl = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_txt
            // 
            this.password_txt.CausesValidation = false;
            this.password_txt.Location = new System.Drawing.Point(501, 469);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.Multiline = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(217, 36);
            this.password_txt.TabIndex = 0;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // userid_txt
            // 
            this.userid_txt.Location = new System.Drawing.Point(501, 420);
            this.userid_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userid_txt.Multiline = true;
            this.userid_txt.Name = "userid_txt";
            this.userid_txt.Size = new System.Drawing.Size(217, 36);
            this.userid_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // registration_btn
            // 
            this.registration_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_btn.Location = new System.Drawing.Point(389, 619);
            this.registration_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registration_btn.Name = "registration_btn";
            this.registration_btn.Size = new System.Drawing.Size(177, 41);
            this.registration_btn.TabIndex = 3;
            this.registration_btn.Text = "Registration";
            this.registration_btn.UseVisualStyleBackColor = true;
            this.registration_btn.Click += new System.EventHandler(this.registration_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(405, 562);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(149, 41);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetpassword_lLbl
            // 
            this.resetpassword_lLbl.AutoSize = true;
            this.resetpassword_lLbl.Location = new System.Drawing.Point(605, 508);
            this.resetpassword_lLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetpassword_lLbl.Name = "resetpassword_lLbl";
            this.resetpassword_lLbl.Size = new System.Drawing.Size(109, 16);
            this.resetpassword_lLbl.TabIndex = 7;
            this.resetpassword_lLbl.TabStop = true;
            this.resetpassword_lLbl.Text = "Forgot Password";
            this.resetpassword_lLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetpassword_lLbl_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSRS.Properties.Resources.Media;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 682);
            this.Controls.Add(this.resetpassword_lLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registration_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userid_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox userid_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registration_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel resetpassword_lLbl;
        private System.Windows.Forms.Button button2;
    }
}