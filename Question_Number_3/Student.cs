using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Number_3
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int TiutionPaid { get; set; }
        public int TiutionLeft { get; set; }
        public int Grade { get; set; }

        public Student(int id, string firstName, string lastName, int age, int tiutionPaid, int tiutionLeft, int grade)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            TiutionPaid = tiutionPaid;
            TiutionLeft = tiutionLeft;
            Grade = grade;
        }
    }
}
