namespace DSRS
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.to_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.ticket_booking_btn = new System.Windows.Forms.Button();
            this.from_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.class_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numberOfNumber_cb = new System.Windows.Forms.ComboBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dhaka Subway Reservation System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // to_cb
            // 
            this.to_cb.FormattingEnabled = true;
            this.to_cb.Items.AddRange(new object[] {
            "Basundhara RiverView",
            "Hazaribagh",
            "Khilkhet",
            "Sadarghat",
            "Tongi",
            "Uttara Sector 13"});
            this.to_cb.Location = new System.Drawing.Point(523, 433);
            this.to_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.to_cb.Name = "to_cb";
            this.to_cb.Size = new System.Drawing.Size(244, 24);
            this.to_cb.Sorted = true;
            this.to_cb.TabIndex = 8;
            this.to_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(523, 471);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(243, 22);
            this.date.TabIndex = 10;
            // 
            // ticket_booking_btn
            // 
            this.ticket_booking_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_booking_btn.Location = new System.Drawing.Point(507, 602);
            this.ticket_booking_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticket_booking_btn.Name = "ticket_booking_btn";
            this.ticket_booking_btn.Size = new System.Drawing.Size(145, 55);
            this.ticket_booking_btn.TabIndex = 11;
            this.ticket_booking_btn.Text = "Book Ticket";
            this.ticket_booking_btn.UseVisualStyleBackColor = true;
            this.ticket_booking_btn.Click += new System.EventHandler(this.ticket_booking_btn_Click);
            // 
            // from_cb
            // 
            this.from_cb.FormattingEnabled = true;
            this.from_cb.Items.AddRange(new object[] {
            "Basundhara RiverView",
            "Hazaribagh",
            "Khilkhet",
            "Sadarghat",
            "Select a place",
            "Tongi",
            "Uttara Sector 13"});
            this.from_cb.Location = new System.Drawing.Point(523, 391);
            this.from_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.from_cb.Name = "from_cb";
            this.from_cb.Size = new System.Drawing.Size(244, 24);
            this.from_cb.Sorted = true;
            this.from_cb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Class";
            // 
            // class_cb
            // 
            this.class_cb.FormattingEnabled = true;
            this.class_cb.Items.AddRange(new object[] {
            "Sitting",
            "Standing"});
            this.class_cb.Location = new System.Drawing.Point(523, 505);
            this.class_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.class_cb.Name = "class_cb";
            this.class_cb.Size = new System.Drawing.Size(244, 24);
            this.class_cb.Sorted = true;
            this.class_cb.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "No. of ticket";
            // 
            // numberOfNumber_cb
            // 
            this.numberOfNumber_cb.FormattingEnabled = true;
            this.numberOfNumber_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.numberOfNumber_cb.Location = new System.Drawing.Point(523, 542);
            this.numberOfNumber_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfNumber_cb.Name = "numberOfNumber_cb";
            this.numberOfNumber_cb.Size = new System.Drawing.Size(244, 24);
            this.numberOfNumber_cb.Sorted = true;
            this.numberOfNumber_cb.TabIndex = 17;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(923, 619);
            this.back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 38);
            this.back_btn.TabIndex = 18;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSRS.Properties.Resources.Media;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 682);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.numberOfNumber_cb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.class_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticket_booking_btn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.to_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.from_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox to_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button ticket_booking_btn;
        private System.Windows.Forms.ComboBox from_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox class_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox numberOfNumber_cb;
        private System.Windows.Forms.Button back_btn;
    }
}