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
    public partial class CustomerForgotPassword : Form
    {
        private string id, name, password;
        public CustomerForgotPassword()
        {
            InitializeComponent();
        }

        private void search_panel_back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(2);
            form2.Show();
        }

        private void CustomerForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void password_reset_panel_back_btn_Click(object sender, EventArgs e)
        {
            account_searching_panel.Visible = true;
            password_reset_panel.Visible = false;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search_tb.Text))
            {
                MessageBox.Show("Enter your email or phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error;
            string query = $@"SELECT [Id], [Name], [Password] FROM [User Information] WHERE [Email] = '{search_tb.Text}' OR [Phone Number] = '{search_tb.Text}'";

            DataSet dataSet = DataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: CustomerForgotPassword function: search_btn_Click \nerror: {error}");
                return;
            }

            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("No user Found");
                return;
            }

            account_searching_panel.Visible = false;
            password_reset_panel.Visible = true;

            id = dataSet.Tables[0].Rows[0]["Id"].ToString();
            this.name = dataSet.Tables[0].Rows[0]["Name"].ToString();
            password = dataSet.Tables[0].Rows[0]["Id"].ToString();

            name_lbl.Text = $"{this.name} reset your password";

        }

        private void password_update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(new_password_tb.Text))
            {
                MessageBox.Show("Enter the password");
                new_password_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(confirm_password_tb.Text))
            {
                MessageBox.Show("Enter the password one more time");
                confirm_password_tb.Focus();
                return;
            }

            if (new_password_tb.Text != confirm_password_tb.Text)
            {
                MessageBox.Show("Confirm password does not match");
                confirm_password_tb.Focus();
                return;
            }

            if (new_password_tb.Text == this.password)
            {
                MessageBox.Show("This is old password. Please enter new one");
                new_password_tb.Focus();
                return;
            }

            string error;
            string query = $@"UPDATE [User Information] SET [Password] = {new_password_tb.Text} WHERE [Id] = {this.id}";

            DataBase.ExecuteNonQuery( query, out error );

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: CustomerForgotPassword Function: password_update_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show($"{this.name} password reset successfully");
            this.Hide();    
            Form2 form2 = new Form2(2);
            form2.Show();
        }
    }
}
