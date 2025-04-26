using StudentAttendanceSystem.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace StudentAttendanceSystem.Models
{
    public class AuthManager
    {
        private DatabaseHelper dbHelper;

        public AuthManager()
        {
            dbHelper = new DatabaseHelper(); 
        }

        public string ValidateLogin(string email, string password)
        {
            string query = "SELECT Role FROM Users WHERE Email = @Email AND Password = @Password";

            SqlParameter[] parameters = {
            new SqlParameter("@Email", email),
            new SqlParameter("@Password", password)
        };

            DataTable result = dbHelper.ExecuteSelectQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["Role"].ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
