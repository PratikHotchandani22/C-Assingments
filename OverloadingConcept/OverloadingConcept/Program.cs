using System;

namespace OverloadingConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Area obj = new Area();
            Console.WriteLine("length of a side of square is: ");
            obj.GetArea(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("length of rectangle");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("width of rectangle");
            int w = Convert.ToInt32(Console.ReadLine());
            obj.GetArea(l, w);
        }
    }


    public class Area
    {
        public int area;
        public void GetArea(int x)
        {
            area = x * x;
            Console.WriteLine("area of square is: " + area);
        }

        public void GetArea(int x, int y)
        {
            area = x * y;
            Console.WriteLine("area of rectangle is: " +area);
        }
    }

}
