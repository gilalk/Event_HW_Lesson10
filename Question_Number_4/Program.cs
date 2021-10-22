using System;

namespace Question_Number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(4, 5);
            var point = new Point(6);

            Console.WriteLine("Please enter location to check up:\n");
            int myLoc = int.Parse(Console.ReadLine());
            Shape.CheckIfHit(square, myLoc);

            Console.WriteLine("Please enter location to check up:\n");
            int myLoc2 = int.Parse(Console.ReadLine());
            Shape.CheckIfHit(point, myLoc2);
        }

    }
}
