using StudentAttendanceSystem.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace StudentAttendanceSystem.Models
{
    public class Report
    {
        private DatabaseHelper dbHelper;

        public Report()
        {
            dbHelper = new DatabaseHelper();
        }

       
        public DataTable GetDailyReport(DateTime date)
        {
            string query = "SELECT s.StudentID, s.Name, a.Status, a.Date " +
                           "FROM Students s " +
                           "JOIN Attendance a ON s.StudentID = a.StudentID " +
                           "WHERE a.Date = @Date";

            SqlParameter[] parameters = {
            new SqlParameter("@Date", date)
        };

            return dbHelper.ExecuteSelectQuery(query, parameters);
        }

        
        public DataTable GetFullAttendanceReport()
        {
            string query = "SELECT s.StudentID, s.Name, a.Date, a.Status " +
                           "FROM Students s " +
                           "JOIN Attendance a ON s.StudentID = a.StudentID " +
                           "ORDER BY a.Date DESC";

            return dbHelper.ExecuteSelectQuery(query, null);
        }
    }
}
