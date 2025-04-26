using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAttendanceSystem.Models
{
    public class Staff : User
    {
        public string StaffId { get; set; }
        public string Department { get; set; }

        public Staff(int id, string name, string email, string staffId, string department)
            : base(id, name, email, "defaultPassword", "Staff")
        {
            StaffId = staffId;
            Department = department;
        }
    }
}