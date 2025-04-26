using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAttendanceSystem.Models
{
    public class Student : User
    {
        public string StudentId { get; set; }
        public string Course { get; set; }

        public Student(int id, string name, string email, string password, string studentId, string course)
            : base(id, name, email, password, "Student")
        {
            StudentId = studentId;
            Course = course;
        }
    }

}
