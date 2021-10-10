using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class StudentsList
    {
       public static List<Student> students = new();
    }
}
