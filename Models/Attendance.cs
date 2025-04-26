using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAttendanceSystem.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public int StaffId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } // "Present" or "Absent"
    }
}