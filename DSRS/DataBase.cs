using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSRS
{
    internal class DataBase
    {
        public static bool ExecuteNonQuery(string query, out string error)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        error = string.Empty;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public static DataSet DataAccess(string query, out string error)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();
                            sqlDataAdapter.Fill(dataSet);

                            error = string.Empty;
                            connection.Close();
                            return dataSet;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
    }
}
