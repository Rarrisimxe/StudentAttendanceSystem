using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentAttendanceSystem.Data
{

    public class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private static readonly string CONNECTION_STRING = "Data Source=(localdb)\\local;Initial Catalog=StudentAttendanceDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }


            public DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public static bool AddStudent(string name, string email, string course, string rollNo)
        {
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                string query = "INSERT INTO dbo.StudentsRec VALUES (@Name, @Email, @Course, @RollNo)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@RollNo", rollNo);

                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        public DataTable ExecuteSelectQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


    }
}

