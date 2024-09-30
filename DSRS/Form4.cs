using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSRS
{
    public partial class Form4 : Form
    {
        private string customerID;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string customerID) : this()
        {
            this.customerID = customerID;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ticket_booking_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(from_cb.Text))
            {
                MessageBox.Show("Choose Living From City");
                return;
            }

            if (string.IsNullOrWhiteSpace (to_cb.Text))
            {
                MessageBox.Show("Choose the Living To City");
                return;
            }

            if (string.IsNullOrWhiteSpace(class_cb.Text))
            {
                MessageBox.Show("Choose the seat type");
                return;
            }

            if (string.IsNullOrWhiteSpace(numberOfNumber_cb.Text))
            {
                MessageBox.Show("Choose the number of seat");
                return;
            }

            if (from_cb.Text == to_cb.Text)
            {
                MessageBox.Show("Please choose the Different City");
                return;
            }

            string error;
            string query = $@"
                            SELECT *
                            FROM [Train Schedule] 
                            WHERE 1=1 
                            AND [From] = '{from_cb.Text}' 
                            AND [To] = '{to_cb.Text}' 
                            AND [Date] = '{date.Value.ToString("dd-MM-yyyy")}'";

            if (class_cb.Text == "Sitting")
                query += $" AND [Sitting Seat] >= {Int32.Parse(numberOfNumber_cb.Text)}";
            
            else if (class_cb.Text == "Standing")           
                query += $" AND [Standing Seat] >= {Int32.Parse(numberOfNumber_cb.Text)}";


            // MessageBox.Show($"Date: {date.Value.ToString("dd-MM-yyyy")}");

            DataSet dataSet = DataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: From4 Function: ticket_booking_btn_Click \nError: {error}");
                return;
            }

            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("No ticket found");
                return;
            }

            int ticketPrice;

            if (class_cb.Text == "Sitting")
                ticketPrice = Int32.Parse(numberOfNumber_cb.Text) * Int32.Parse(dataSet.Tables[0].Rows[0]["Sitting Price"].ToString());
            else
                ticketPrice = Int32.Parse(numberOfNumber_cb.Text) * Int32.Parse(dataSet.Tables[0].Rows[0]["Standing Price"].ToString());


            this.Hide();
            Form5 form5 = new Form5(scheduleID: dataSet.Tables[0].Rows[0]["Id"].ToString(), customerID: this.customerID, seatType: class_cb.Text, NumberOfSeats: Int32.Parse(numberOfNumber_cb.Text), totalPrice: ticketPrice); 
            form5.Show();

            

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(2);
            form2.Show();

        }
    }
}
