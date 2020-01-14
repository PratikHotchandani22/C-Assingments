using System;

namespace AccessModifiers
{
    public class Program 
    {
        static void Main(string[] args)
        {
            X obj2 = new X();
            Y obj1 = new Y();
            Z obj3 = new Z();
            Console.WriteLine("value of protected x from class X is: " + obj1.ValueOfX()) ;
            Console.WriteLine("value of public x1 from class X is: " + obj2.x1);
            Console.WriteLine("value of internal x3 from class X is: " + obj3.ValueOFX3());
            Console.WriteLine("value of protected internal x4 from class X is: " + obj1.ValueOfX4());
            Console.WriteLine("value of private x5 from class X is: " + obj2.ValueOfX5());
            Console.WriteLine("value of private protected x6 from class X is: " + obj1.ValueOfX6());

        }

    }

    class X
    {
        protected int x = 100;
        public int x1 = 20;
        internal int x3 = 500; 
        protected internal int x4=50; // x4 can only be called by a class which inherits class X and is in the same namespace.
        private int x5 = 10; // x5 is private, so we can not call it from any other class.
        private protected int x6 = 1000; //x6 is private protected, so we can only access from its derived classes, so in this case from class Y.


        //so printing x5 from the same class.
        public int ValueOfX5()
        {
            return x5;
        }


    }

    class Y : X
    {
        public int ValueOfX()
        {
            return x; // here variable x is protected in class X, since y inherits class X,we can access protected x in class y. 
        }

        //since Class Y inherits class X and is in the same namespace, we can access it from here.

        public int ValueOfX4()
        {
            return x4;
        }

        public int ValueOfX6()
        {
            return x6;
        }

    }

    class Z
    {
        X Xobj = new X();
        public int ValueOFX3()
        {
            return Xobj.x3;
        }

    }

    
}
