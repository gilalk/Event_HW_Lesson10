using System;

namespace Question_Number_7
{

    public delegate void LuckyNumberDelegate();
    class Program
    {
        public static event LuckyNumberDelegate LuckyNumberEvent;
        public static event EventHandler<int> NumOfTries;

        static void Main(string[] args)
        {
            bool stop = true;
            int counter = 0;

            while (stop)
            {
                Console.Write("Enter number:\n");
                int luckyNum = int.Parse(Console.ReadLine());
                counter++;
                if (luckyNum == 999)
                {
                    stop = false;
                    LuckyNumberEvent += LuckyNumberFunction;
                    NumOfTries += CountTheNumOfTries;
                    LuckyNumberEvent();
                    NumOfTries(null, counter);
                }
            }
        }

        public static void LuckyNumberFunction()
        {
            Console.WriteLine("Lucky Number Was Entered!!!");
        }

        public static void CountTheNumOfTries(object sender, int x)
        {
            Console.WriteLine($"Number Of Tries: {x}");
        }
    }
}

