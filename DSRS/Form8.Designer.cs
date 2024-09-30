namespace DSRS
{
    partial class Form8
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
            this.label4 = new System.Windows.Forms.Label();
            this.to_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.from_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.standing_seat_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sitting_seat_tb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.train_data_dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tran_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standing_seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sittingseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.train_name_tb = new System.Windows.Forms.TextBox();
            this.date_tb = new System.Windows.Forms.TextBox();
            this.time_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.standing_ticket_price_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sitting_price_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.train_data_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date";
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
            this.to_cb.Location = new System.Drawing.Point(613, 106);
            this.to_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.to_cb.Name = "to_cb";
            this.to_cb.Size = new System.Drawing.Size(244, 24);
            this.to_cb.Sorted = true;
            this.to_cb.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "To";
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
            this.from_cb.Location = new System.Drawing.Point(613, 64);
            this.from_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.from_cb.Name = "from_cb";
            this.from_cb.Size = new System.Drawing.Size(244, 24);
            this.from_cb.Sorted = true;
            this.from_cb.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "From";
            // 
            // standing_seat_tb
            // 
            this.standing_seat_tb.Location = new System.Drawing.Point(612, 202);
            this.standing_seat_tb.Margin = new System.Windows.Forms.Padding(4);
            this.standing_seat_tb.Name = "standing_seat_tb";
            this.standing_seat_tb.Size = new System.Drawing.Size(87, 22);
            this.standing_seat_tb.TabIndex = 24;
            this.standing_seat_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.standing_seat_tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 44);
            this.label2.TabIndex = 25;
            this.label2.Text = "No Of Seat\r\n(Standing)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(757, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 44);
            this.label5.TabIndex = 27;
            this.label5.Text = "No Of Seat\r\n(Sitting)";
            // 
            // sitting_seat_tb
            // 
            this.sitting_seat_tb.Location = new System.Drawing.Point(893, 202);
            this.sitting_seat_tb.Margin = new System.Windows.Forms.Padding(4);
            this.sitting_seat_tb.Name = "sitting_seat_tb";
            this.sitting_seat_tb.Size = new System.Drawing.Size(87, 22);
            this.sitting_seat_tb.TabIndex = 26;
            this.sitting_seat_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sitting_seat_tb_KeyPress);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(916, 42);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 28);
            this.add_btn.TabIndex = 28;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(916, 78);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(100, 28);
            this.delete_btn.TabIndex = 28;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(916, 108);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(100, 28);
            this.update_btn.TabIndex = 28;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // train_data_dgv
            // 
            this.train_data_dgv.AllowUserToAddRows = false;
            this.train_data_dgv.AllowUserToDeleteRows = false;
            this.train_data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.train_data_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tran_name,
            this.from,
            this.to,
            this.date,
            this.standing_seat,
            this.sittingseat});
            this.train_data_dgv.Location = new System.Drawing.Point(372, 329);
            this.train_data_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.train_data_dgv.Name = "train_data_dgv";
            this.train_data_dgv.ReadOnly = true;
            this.train_data_dgv.RowHeadersWidth = 51;
            this.train_data_dgv.Size = new System.Drawing.Size(705, 338);
            this.train_data_dgv.TabIndex = 29;
            this.train_data_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.train_data_dgv_CellClick);
            this.train_data_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.train_data_dgv_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // tran_name
            // 
            this.tran_name.HeaderText = "Train Name";
            this.tran_name.MinimumWidth = 6;
            this.tran_name.Name = "tran_name";
            this.tran_name.ReadOnly = true;
            this.tran_name.Width = 125;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.MinimumWidth = 6;
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Width = 125;
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.MinimumWidth = 6;
            this.to.Name = "to";
            this.to.ReadOnly = true;
            this.to.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // standing_seat
            // 
            this.standing_seat.HeaderText = "Standing Seat";
            this.standing_seat.MinimumWidth = 6;
            this.standing_seat.Name = "standing_seat";
            this.standing_seat.ReadOnly = true;
            this.standing_seat.Width = 125;
            // 
            // sittingseat
            // 
            this.sittingseat.HeaderText = "Seating Seat";
            this.sittingseat.MinimumWidth = 6;
            this.sittingseat.Name = "sittingseat";
            this.sittingseat.ReadOnly = true;
            this.sittingseat.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Train Name";
            // 
            // train_name_tb
            // 
            this.train_name_tb.Location = new System.Drawing.Point(613, 18);
            this.train_name_tb.Margin = new System.Windows.Forms.Padding(4);
            this.train_name_tb.Name = "train_name_tb";
            this.train_name_tb.Size = new System.Drawing.Size(243, 22);
            this.train_name_tb.TabIndex = 30;
            // 
            // date_tb
            // 
            this.date_tb.Location = new System.Drawing.Point(612, 144);
            this.date_tb.Margin = new System.Windows.Forms.Padding(4);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(147, 22);
            this.date_tb.TabIndex = 30;
            // 
            // time_tb
            // 
            this.time_tb.Location = new System.Drawing.Point(868, 146);
            this.time_tb.Margin = new System.Windows.Forms.Padding(4);
            this.time_tb.Name = "time_tb";
            this.time_tb.Size = new System.Drawing.Size(147, 22);
            this.time_tb.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(800, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(480, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Price(Standing)";
            // 
            // standing_ticket_price_tb
            // 
            this.standing_ticket_price_tb.Location = new System.Drawing.Point(652, 255);
            this.standing_ticket_price_tb.Margin = new System.Windows.Forms.Padding(4);
            this.standing_ticket_price_tb.Name = "standing_ticket_price_tb";
            this.standing_ticket_price_tb.Size = new System.Drawing.Size(107, 22);
            this.standing_ticket_price_tb.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(771, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 22);
            this.label9.TabIndex = 35;
            this.label9.Text = "Price(Sitting)";
            // 
            // sitting_price_tb
            // 
            this.sitting_price_tb.Location = new System.Drawing.Point(943, 252);
            this.sitting_price_tb.Margin = new System.Windows.Forms.Padding(4);
            this.sitting_price_tb.Name = "sitting_price_tb";
            this.sitting_price_tb.Size = new System.Drawing.Size(107, 22);
            this.sitting_price_tb.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 36;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSRS.Properties.Resources.businessman_standing_with_setting_icon_on_yellow_background_project_management_and_processing_concept_business_planning_and_strategy_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sitting_price_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.standing_ticket_price_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.time_tb);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.train_name_tb);
            this.Controls.Add(this.train_data_dgv);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sitting_seat_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.standing_seat_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.to_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.from_cb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.train_data_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox to_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox from_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox standing_seat_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sitting_seat_tb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.DataGridView train_data_dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox train_name_tb;
        private System.Windows.Forms.TextBox date_tb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tran_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn standing_seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sittingseat;
        private System.Windows.Forms.TextBox time_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox standing_ticket_price_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sitting_price_tb;
        private System.Windows.Forms.Button button1;
    }
}