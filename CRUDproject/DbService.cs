using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CRUDproject
{
    public class DbService
    {
        private string connectionString = "Data Source=DESKTOP-IIVQAN1;Initial Catalog=CrudApp;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        // Method to execute INSERT, UPDATE, DELETE queries
        public int ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Method to fetch data (SELECT queries)
        public DataTable FetchData(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
