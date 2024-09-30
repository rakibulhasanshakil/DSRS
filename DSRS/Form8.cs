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
    public partial class Form8 : Form
    {
        private string scheduleID;
        public Form8()
        {
            InitializeComponent();
            DataLoad();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(train_name_tb.Text))
            {
                MessageBox.Show("Please enter the train name");
                return true;
            }
            if (string.IsNullOrWhiteSpace(from_cb.Text))
            {
                MessageBox.Show("Choose Living From City");
                return true;
            }

            if (string.IsNullOrWhiteSpace(to_cb.Text))
            {
                MessageBox.Show("Choose the Living To City");
                return true;
            }

            if (string.IsNullOrWhiteSpace(date_tb.Text))
            {
                MessageBox.Show("Please enter the date");
                return true;
            }
            if (string.IsNullOrWhiteSpace(standing_seat_tb.Text))
            {
                MessageBox.Show("Choose the number of standing seat");
                return true;
            }

            if (string.IsNullOrWhiteSpace(sitting_seat_tb.Text))
            {
                MessageBox.Show("Choose the number of sitting seat");
                return true;
            }

            if (string.IsNullOrWhiteSpace(standing_ticket_price_tb.Text))
            {
                MessageBox.Show("Eter the number of sanding ticket price");
                return true;
            }
            if (string.IsNullOrWhiteSpace(sitting_price_tb.Text))
            {
                MessageBox.Show("Enter the number of sitting seat price");
                return true;
            }
            if (from_cb.Text == to_cb.Text)
            {
                MessageBox.Show("Please choose the Different City");
                return true;
            }

            return false;

        }
        private void add_btn_Click(object sender, EventArgs e)
        {

            if (IsEmpty())
                return;

            string error;
            string query = $@"
                                INSERT INTO [Train Schedule] ([Train Name], [From], [To], [Date], [Time], [Sitting Seat], [Standing Seat], [Sitting Price], [Standing Price])
                                VALUES ('{train_name_tb.Text}', '{from_cb.Text}', '{to_cb.Text}', '{date_tb.Text}', '{time_tb.Text}', {sitting_seat_tb.Text}, {standing_seat_tb.Text}, {sitting_price_tb.Text}, {standing_ticket_price_tb.Text});";

            DataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: Form8 Function: add_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show("This trainn is registered");
            DataLoad();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
                return;

            string error;
            string query = $@"
                            UPDATE [Train Schedule]
                            SET [Train Name] = '{train_name_tb.Text}', 
                                [From] = '{from_cb.Text}', 
                                [To] = '{to_cb.Text}', 
                                [Date] = '{date_tb.Text}', 
                                [Time] = '{time_tb.Text}', 
                                [Sitting Seat] = {sitting_seat_tb.Text}, 
                                [Standing Seat] = {standing_seat_tb.Text}, 
                                [Sitting Price] = {sitting_price_tb.Text}, 
                                [Standing Price] = {standing_ticket_price_tb.Text}
                            WHERE [ID] = '{scheduleID}'"; // Update by unique schedule ID

            DataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: Form8 Function: update_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show("Train schedule updated successfully");
            DataLoad();
        }

        private void DataLoad()
        {
            string error;
            string query = "SELECT * FROM [Train Schedule]";

            DataSet dataSet = DataBase.DataAccess(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class name form8 function DaataLoad \nError: {error}");
                return;
            }

            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("No train data");
                return;
            }

            train_data_dgv.Rows.Clear();

            foreach (DataRow item in dataSet.Tables[0].Rows)
                train_data_dgv.Rows.Add(item["Id"].ToString(), item["Train Name"].ToString(), item["From"].ToString(), item["To"].ToString(), item["Date"].ToString(), item["Sitting Seat"].ToString(), item["Standing Seat"].ToString());
            
        }

        private void standing_seat_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // Suppress the key press  

        }

        private void sitting_seat_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // Suppress the key press  

        }

        private void train_data_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the Id value from the selected row's first column
                DataShow(train_data_dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            }
        }

        private void DataShow(string trainID)
        {
            scheduleID = trainID;
            string error;
            string query = $@"SELECT * FROM [Train Schedule] WHERE ID = '{trainID}'";

            DataSet dataSet = DataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: From8 Function: DataShow \nError: {error}");
                return;
            }

            train_name_tb.Text = dataSet.Tables[0].Rows[0]["Train Name"].ToString();
            from_cb.Text = dataSet.Tables[0].Rows[0]["From"].ToString();
            to_cb.Text = dataSet.Tables[0].Rows[0]["To"].ToString();
            date_tb.Text = dataSet.Tables[0].Rows[0]["Date"].ToString();
            time_tb.Text = dataSet.Tables[0].Rows[0]["Time"].ToString();
            sitting_seat_tb.Text = dataSet.Tables[0].Rows[0]["Sitting Seat"].ToString();
            standing_seat_tb.Text = dataSet.Tables[0].Rows[0]["Standing Seat"].ToString();
            standing_ticket_price_tb.Text = dataSet.Tables[0].Rows[0]["Standing Price"].ToString();
            sitting_price_tb.Text = dataSet.Tables[0].Rows[0]["Sitting Price"].ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string error;
            string query = $"DELETE FROM [Train Schedule] WHERE ID = '{scheduleID}'";


            DataBase.ExecuteNonQuery(query, out error);
            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Form8 Function: delete_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show("Deleted");
            ClearData();
            DataLoad();
        }

        private void ClearData()
        {
            train_name_tb.Clear();
            from_cb.SelectedIndex = -1; 
            to_cb.SelectedIndex = -1;
            date_tb.Clear();
            time_tb.Clear();
            standing_seat_tb.Clear();
            sitting_seat_tb.Clear();
            sitting_price_tb.Clear() ;
            standing_ticket_price_tb.Clear() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void train_data_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
