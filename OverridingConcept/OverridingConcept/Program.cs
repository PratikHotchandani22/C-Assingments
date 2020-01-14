using System;

namespace OverridingConcept
{
    class Program
    {

        //Creating a method in the derived class with the same signature as a method in the base class is called as method overriding.
        //3 different types of  keywords in method overridng are:
        /*
         * 1. virtual
         * 2. override  
         * 3. base
         * 
         */
        static void Main(string[] args)
        {

            BaseClass baseClass = new BaseClass();
            baseClass.show();

            baseClass = new SubClass();
            baseClass.show();
        }
    }

    class BaseClass
    {
        public virtual void show()
        {
            Console.WriteLine("from base class");
        }
    }

    class SubClass: BaseClass
    {
         public override void show()
        {
            Console.WriteLine("from derived class");
        }
    }
}
