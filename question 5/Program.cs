// See https://aka.ms/new-console-template for more information

namespace RECTANGLE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x coordinate:");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y coordinate:");
            double y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x1 coordinate:");
            double x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1 coordinate:");
            double y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x2 coordinate:");
            double x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2 coordinate:");
            double y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Inside(x, y, x1, y1, x2, y2));

            // (b) checking if point (1, 1) lies in one of the given rectanlges

            Console.WriteLine("(b)checking if point(1, 1) lies in one of the given rectanlges");

            /*
             * (0.3, 0.5) (1.1, 0.7) and (0.5, 0.2) (1.1, 2).
            */
            x = 1;
            y = 1;

            x1 = 0.3;
            y1 = 0.5;
            x2 = 1.1;
            y2 = 0.7;

            Console.WriteLine("(b)checking if point(1, 1) lies in rectangle 1: ");
            Console.WriteLine(Inside(x, y, x1, y1, x2, y2));

            x1 = 0.5;
            y1 = 0.2;
            x2 = 1.1;
            y2 = 2;

            Console.WriteLine("(b)checking if point(1, 1) lies in rectangle 2: ");
            Console.WriteLine(Inside(x, y, x1, y1, x2, y2));
        }

        public static bool Inside(double x, double y, double x1, double y1, double x2, double y2)
        {
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
