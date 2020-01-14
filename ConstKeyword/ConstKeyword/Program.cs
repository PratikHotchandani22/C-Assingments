using System;

namespace ConstKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingConst usingConst = new UsingConst();
            Console.WriteLine("value of variable x is: " +usingConst.x);

            //   Console.WriteLine("value of const c1 and c2: " + usingConst.c1 + usingConst.c2); // this can not be done, because it may change with new object
            Console.WriteLine("value of const c1 is: " + UsingConst.c1  + " c2 is:  " + UsingConst.c2);
        }
    }

    public class UsingConst
    {
        public int x=0;
        // public static int c1=x + 5; //can not be done because x is a variable
        public const int c1 = 10;
        public const int c2 = c1 + 5;

    }
}
