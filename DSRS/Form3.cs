using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;

namespace DSRS
{
    public partial class Form3 : Form
    {
        private bool admin;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(bool admin) : this()
        {
            this.admin = admin;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string Gender()
        {
            if (male_rb.Checked) return "Male";
            if (female_rb.Checked) return "Female";
            if (others_rb.Checked) return "OThers";
            else return null;
        }
        private void registration_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_txt.Text))
            {
                MessageBox.Show("Please enter your name");
                name_txt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(dob_txt.Text))
            {
                MessageBox.Show("Please enter your date of birth");
                dob_txt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Gender()))
            {
                MessageBox.Show("Please enter your gender");
                return;
            }

            if (string.IsNullOrWhiteSpace(nid_txt.Text))
            {
                MessageBox.Show("Please enter your nid number");
                nid_txt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email_txt.Text))
            {
                MessageBox.Show("Please enter your email");
                email_txt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(number_txt.Text))
            {
                MessageBox.Show("Please enter your phone number");
                number_txt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password_txt.Text))
            {
                MessageBox.Show("Please enter password");
                password_txt.Focus();   
                return;
            }

            if (string.IsNullOrWhiteSpace(confirm_password_txt.Text))
            {
                MessageBox.Show("Please enter the password on more time");
                confirm_password_txt.Focus();
                return;
            }

            if (password_txt.Text != confirm_password_txt.Text)
            {
                MessageBox.Show("Password does not match");
                confirm_password_txt.Focus();
                return;
            }

            if (!Utility.Validity.IsEmailValid(email_txt.Text))
            {
                MessageBox.Show("Invalid Email");
                email_txt.Focus();
                return;
            }

            if (!Utility.Validity.IsPhoneNumberValid(number_txt.Text))
            {
                MessageBox.Show("Invalid Phone number");
                number_txt.Focus();
                return;
            }

            
            if (admin)
            {
                AdminResister();
                return;
            }

            CustomerResister(); 
            
        }

        private void CustomerResister()
        {
            string query, error;
            // Check if the email is already registered
            query = $@"
                    SELECT TOP 1 * FROM [User Information] WHERE [Email] = '{email_txt.Text}'";
            DataSet dataSet = DataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: From3 Function: registration_btn_Click 1\nError: {error}", "Email");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This EMAIL is already registered");
                email_txt.Focus();
                return;
            }

            // Check if the phone number is already registered
            query = $"SELECT TOP 1 * FROM [User Information] WHERE [Phone Number] = '{number_txt.Text}'";
            dataSet = DataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: Form3 Function:  registration_btn_Click 2 \nError: {error}", "Phone Number");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This PHONE NUMBER is already registered");
                number_txt.Focus();
                return;
            }
            query = $@"INSERT INTO [User Information] (Name, Email, [Phone Number], NID, DOB, Gender, Password)
                              VALUES ('{name_txt.Text}', '{email_txt.Text}', '{number_txt.Text}', '{nid_txt.Text}', '{dob_txt.Text}', '{Gender()}', '{password_txt.Text}')";
            DataBase.ExecuteNonQuery(query, out error);


            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class name form3 function login_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show($"{name_txt.Text} your account successfully created");
            this.Hide();
            Form2 loginForm = new Form2(2);
            loginForm.Show();
        }

        private void AdminResister()
        {
            string query, error;
            // Check if the email is already registered
            query = $@"
                    SELECT TOP 1 * FROM [Admin Information] WHERE [Email] = '{email_txt.Text}'";
            DataSet dataSet = DataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: From3 Function: registration_btn_Click 1\nError: {error}", "Email");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This EMAIL is already registered");
                email_txt.Focus();
                return;
            }

            // Check if the phone number is already registered
            query = $"SELECT TOP 1 * FROM [Admin Information] WHERE [Phone Number] = '{number_txt.Text}'";
            dataSet = DataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: Form3 Function:  registration_btn_Click 2 \nError: {error}", "Phone Number");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This PHONE NUMBER is already registered");
                number_txt.Focus();
                return;
            }
            query = $@"INSERT INTO [Admin Information] (Name, Email, [Phone Number], NID, DOB, Gender, Password)
                              VALUES ('{name_txt.Text}', '{email_txt.Text}', '{number_txt.Text}', '{nid_txt.Text}', '{dob_txt.Text}', '{Gender()}', '{password_txt.Text}')";
            DataBase.ExecuteNonQuery(query, out error);


            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class name form3 function login_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show($"{name_txt.Text} your account successfully created");
            this.Hide();
            Form7 loginForm = new Form7();
            loginForm.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (this.admin)
            {
                this.Hide();
                Form7 form7 = new Form7();
                form7.Show();
                return;
            }

            this.Hide();
            Form2 loginForm = new Form2(2);
            loginForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
