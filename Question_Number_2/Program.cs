using System;

namespace Question_Number_2
{
    class Program
    {

        public static event LuckyNumberDelegate LuckyNumberEvent;

        static void Main(string[] args)
        {
            bool stop = true;

            while (stop)
            {
                Console.WriteLine("Enter number:\n");
                int luckyNum = int.Parse(Console.ReadLine());
                if(luckyNum == 999)
                {
                    stop = false;
                    LuckyNumberEvent += LuckyNumberFunction;
                    LuckyNumberEvent();
                }
            }
        }

        public static void LuckyNumberFunction()
        {
            Console.WriteLine("Lucky Number Was Entered!!!");
        }
    }
}
