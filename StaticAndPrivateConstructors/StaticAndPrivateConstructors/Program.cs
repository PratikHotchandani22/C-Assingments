using System;

namespace StaticAndPrivateConstructors
{
    class Program : Interns
    {
        //Private constructors are still instance constructors - they are not static. 
        //privare constructors are no different from public constructors, except they define who can call them, just like the difference between a public and private regular method
        static void Main(string[] args)
        {
            Interns interns1 = new Interns(); //wont work because of private keyword.
            Interns interns2 = new Interns();
            //Interns interns3 = new Interns(5);
            interns1.ValueofX();

        }
    }

    class Interns
    {
        int x = 1;

        static Interns()
        {
            Console.WriteLine("Static constructor called");
        }

       public Interns()
        {
            //this.x = x; // can not be done because it is a static variable
            Console.WriteLine("Public constructor called");
        }

        private Interns(int x)
        {
            this.x = x;
            Console.WriteLine("Private constructor called");

        }
        
        public void ValueofX()
        {
            Console.WriteLine("value of x is: " + x);
        }

    }


}
