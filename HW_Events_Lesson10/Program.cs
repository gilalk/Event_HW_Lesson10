using System;

namespace Question_Number_1
{    
    class Program
    {
        
        public static event TooLongNameDelegate TooLongNameEvent;
        
        static void Main(string[] args)
        {
            TooLongNameEvent = PrintLongNameWarning;
            Student student = new Student();

            Console.WriteLine("Please insert name:\n");
            student.Name = Console.ReadLine();
            if (student.Name.Length > 10)
            {
                TooLongNameEvent();
            }
            
        }

        public static void PrintLongNameWarning()
        {
            Console.WriteLine("The added name by the user is incorrect!");
        }
    }
}
