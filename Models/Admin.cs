using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAttendanceSystem.Models
{
    public class Admin : User
    {
        public Admin(int id, string name, string email)
            : base(id, name, email, "defaultPassword", "Admin")
        {
        }
    }
}