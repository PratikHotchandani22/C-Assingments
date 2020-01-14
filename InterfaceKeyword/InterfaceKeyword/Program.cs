using System;

namespace InterfaceKeyword
{
    class Program 
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.getDetails();

            square.printDetails();
        }

    }


    public interface area
    {
        public void getDetails();
        public void printDetails();
        
    }

    class Square : area
    {
        double l, w, area;
        public void getDetails()
        {
            Console.WriteLine("Enter length");
           
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width");
            w = Convert.ToDouble(Console.ReadLine());

            calculateArea(l, w);
           
        }

        public void calculateArea(double l, double w)
        {
            area = l * w;
            
        }

        public void printDetails()
        {
            Console.WriteLine("area is: "+ area);
        }
    }
}
