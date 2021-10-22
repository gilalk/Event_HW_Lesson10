using System;

namespace Question_Number_3
{
    class Program
    {

        public static event DiscountDelegate discountEvent = DiscountAnnounsment;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Name To Sign Up:\n");
                string name = Console.ReadLine();

                if(name == string.Empty) { break; }

                Student student = new Student(name);
                StudentList.studenList.Add(student);
                if(StudentList.studenList.Count % 5 == 0) 
                { 
                    discountEvent(); 
                }
            }
        }

        public static void DiscountAnnounsment()
        {
            Console.WriteLine("You got 5% discount");
        }
    }
}
