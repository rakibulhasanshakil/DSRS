namespace DSRS
{
    partial class CustomerForgotPassword
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
            this.account_searching_panel = new System.Windows.Forms.Panel();
            this.search_panel_back_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.password_reset_panel = new System.Windows.Forms.Panel();
            this.password_reset_panel_back_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_password_tb = new System.Windows.Forms.TextBox();
            this.password_update_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.new_password_tb = new System.Windows.Forms.TextBox();
            this.account_searching_panel.SuspendLayout();
            this.password_reset_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // account_searching_panel
            // 
            this.account_searching_panel.BackgroundImage = global::DSRS.Properties.Resources.Media;
            this.account_searching_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.account_searching_panel.Controls.Add(this.search_panel_back_btn);
            this.account_searching_panel.Controls.Add(this.search_btn);
            this.account_searching_panel.Controls.Add(this.label1);
            this.account_searching_panel.Controls.Add(this.search_tb);
            this.account_searching_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.account_searching_panel.Location = new System.Drawing.Point(0, 0);
            this.account_searching_panel.Margin = new System.Windows.Forms.Padding(4);
            this.account_searching_panel.Name = "account_searching_panel";
            this.account_searching_panel.Size = new System.Drawing.Size(683, 279);
            this.account_searching_panel.TabIndex = 0;
            // 
            // search_panel_back_btn
            // 
            this.search_panel_back_btn.Location = new System.Drawing.Point(223, 166);
            this.search_panel_back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_panel_back_btn.Name = "search_panel_back_btn";
            this.search_panel_back_btn.Size = new System.Drawing.Size(100, 28);
            this.search_panel_back_btn.TabIndex = 3;
            this.search_panel_back_btn.Text = "Back";
            this.search_panel_back_btn.UseVisualStyleBackColor = true;
            this.search_panel_back_btn.Click += new System.EventHandler(this.search_panel_back_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(377, 166);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(100, 28);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Email or Password";
            // 
            // search_tb
            // 
            this.search_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.Location = new System.Drawing.Point(73, 100);
            this.search_tb.Margin = new System.Windows.Forms.Padding(4);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(417, 28);
            this.search_tb.TabIndex = 0;
            // 
            // password_reset_panel
            // 
            this.password_reset_panel.BackgroundImage = global::DSRS.Properties.Resources.Media;
            this.password_reset_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password_reset_panel.Controls.Add(this.password_reset_panel_back_btn);
            this.password_reset_panel.Controls.Add(this.name_lbl);
            this.password_reset_panel.Controls.Add(this.label3);
            this.password_reset_panel.Controls.Add(this.confirm_password_tb);
            this.password_reset_panel.Controls.Add(this.password_update_btn);
            this.password_reset_panel.Controls.Add(this.label2);
            this.password_reset_panel.Controls.Add(this.new_password_tb);
            this.password_reset_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.password_reset_panel.Location = new System.Drawing.Point(0, 279);
            this.password_reset_panel.Margin = new System.Windows.Forms.Padding(4);
            this.password_reset_panel.Name = "password_reset_panel";
            this.password_reset_panel.Size = new System.Drawing.Size(683, 300);
            this.password_reset_panel.TabIndex = 1;
            this.password_reset_panel.Visible = false;
            // 
            // password_reset_panel_back_btn
            // 
            this.password_reset_panel_back_btn.Location = new System.Drawing.Point(284, 256);
            this.password_reset_panel_back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.password_reset_panel_back_btn.Name = "password_reset_panel_back_btn";
            this.password_reset_panel_back_btn.Size = new System.Drawing.Size(100, 28);
            this.password_reset_panel_back_btn.TabIndex = 9;
            this.password_reset_panel_back_btn.Text = "Back";
            this.password_reset_panel_back_btn.UseVisualStyleBackColor = true;
            this.password_reset_panel_back_btn.Click += new System.EventHandler(this.password_reset_panel_back_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(124, 32);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(44, 16);
            this.name_lbl.TabIndex = 8;
            this.name_lbl.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password";
            // 
            // confirm_password_tb
            // 
            this.confirm_password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_tb.Location = new System.Drawing.Point(105, 194);
            this.confirm_password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_password_tb.Name = "confirm_password_tb";
            this.confirm_password_tb.Size = new System.Drawing.Size(417, 28);
            this.confirm_password_tb.TabIndex = 6;
            // 
            // password_update_btn
            // 
            this.password_update_btn.Location = new System.Drawing.Point(475, 256);
            this.password_update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.password_update_btn.Name = "password_update_btn";
            this.password_update_btn.Size = new System.Drawing.Size(100, 28);
            this.password_update_btn.TabIndex = 5;
            this.password_update_btn.Text = "Reset";
            this.password_update_btn.UseVisualStyleBackColor = true;
            this.password_update_btn.Click += new System.EventHandler(this.password_update_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password";
            // 
            // new_password_tb
            // 
            this.new_password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password_tb.Location = new System.Drawing.Point(105, 110);
            this.new_password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.new_password_tb.Name = "new_password_tb";
            this.new_password_tb.Size = new System.Drawing.Size(417, 28);
            this.new_password_tb.TabIndex = 3;
            // 
            // CustomerForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(704, 278);
            this.Controls.Add(this.password_reset_panel);
            this.Controls.Add(this.account_searching_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForgotPassword";
            this.Load += new System.EventHandler(this.CustomerForgotPassword_Load);
            this.account_searching_panel.ResumeLayout(false);
            this.account_searching_panel.PerformLayout();
            this.password_reset_panel.ResumeLayout(false);
            this.password_reset_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel account_searching_panel;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Panel password_reset_panel;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirm_password_tb;
        private System.Windows.Forms.Button password_update_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox new_password_tb;
        private System.Windows.Forms.Button search_panel_back_btn;
        private System.Windows.Forms.Button password_reset_panel_back_btn;
    }
}