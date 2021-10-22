using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Number_3
{

    public delegate void DiscountDelegate();

    public class DiscountManagement
    {
        public event DiscountDelegate discountEvent;
    }
    
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }

    public class StudentList
    {
        public static List<Student> studenList = new List<Student>();
    }
}
