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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            DataLoad();
        }

        private void DataLoad()
        {
            string error;
            string query = "SELECT * FROM [User Information]";

            DataSet dataSet = DataBase.DataAccess(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class name form9 function DaataLoad \nError: {error}");
                return;
            }

            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("No user input");
                return;
            }

            customer_data_dgv.Rows.Clear();

            foreach (DataRow item in dataSet.Tables[0].Rows)
            {
                customer_data_dgv.Rows.Add(item["Id"].ToString(), item["Name"].ToString(), item["Email"].ToString(), item["Phone Number"].ToString(), item["DOB"].ToString(), item["NID"].ToString(), item["Password"].ToString());
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void customer_data_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
