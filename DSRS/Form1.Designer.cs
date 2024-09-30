namespace DSRS
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
            this.admin_btn = new System.Windows.Forms.Button();
            this.psngr_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.admin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.Location = new System.Drawing.Point(844, 566);
            this.admin_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(149, 59);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Admin";
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // psngr_btn
            // 
            this.psngr_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.psngr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psngr_btn.Location = new System.Drawing.Point(844, 460);
            this.psngr_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.psngr_btn.Name = "psngr_btn";
            this.psngr_btn.Size = new System.Drawing.Size(149, 59);
            this.psngr_btn.TabIndex = 1;
            this.psngr_btn.Text = "Passenger";
            this.psngr_btn.UseVisualStyleBackColor = false;
            this.psngr_btn.Click += new System.EventHandler(this.psngr_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dhaka Subway Reservation System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSRS.Properties.Resources.Metro_subway_Rio_de_Janeiro__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.psngr_btn);
            this.Controls.Add(this.admin_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dhaka Subway Reservation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button psngr_btn;
        private System.Windows.Forms.Label label1;
    }
}

