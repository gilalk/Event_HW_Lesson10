using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Number_3
{

    public delegate string DiscountDelegate(); 

    public class Discounts
    {
        public event DiscountDelegate GetDiscount;
    }
    
    class StudentList
    {
        List<Student> studentList = new List<Student>();

        public string FifthStudentDiscount()
        {
            return "You got 5% discount";
        }
    }
}
