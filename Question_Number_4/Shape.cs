using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Number_4
{

    public delegate void ShapeDelegate();

    public class Shape
    {
        public static event ShapeDelegate Outch;
        public virtual int MyPlace { get; set; }
        public static void Hit()
        {
            Console.WriteLine("Outch you hit the squre!!!");
        }

        public static void CheckIfHit(Shape shape, int loc)
        {
            bool daleg = true;
            if (shape is Square)
            {
                if (shape.MyPlace >= loc)
                {
                    Outch = Hit;
                    Outch();
                    daleg = false;
                }
            }
            else if (shape is Point)
            {
                if (shape.MyPlace == loc)
                {
                    Outch = Hit;
                    Outch();
                    daleg = false;
                }
            }
            if (daleg)
            {
                Console.WriteLine("Everything is alright, keep going!");
            }

        }
    }

    public class Point : Shape
    {
        public override int MyPlace { get; set; }

        public Point(int place)
        {
            MyPlace = place;
        }
    }

    public class Square : Shape
    {
        public override int MyPlace { get; set; }

        public Square(int length, int width)
        {
            MyPlace = length * width;
        }
    }

}
