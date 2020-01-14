using System;

namespace StaticAndThis
{
    class Program
    {
        //The this keyword refers to the current instance of the class. Static member functions do not have any instance, so we can not use this keyword in static method.
        static void Main(string[] args)
        {

            ThisClass thisClass = new ThisClass();
            StaticClassExample.sayName();
            thisClass.sayName();
            ThisClass.sayNameStatic();  //static methods inside non static class should be called like this.
        }

    }

    //static classes are only allowed to have static methods.
    static class StaticClassExample
    {
        public static void sayName()
        {
            Console.WriteLine("my name is pratik and i am from StaticClassExample method sayName");
        }
    }

    //non-static class can have both static and not static methods
    public class ThisClass
    {
        public void sayName()
        {
            Console.WriteLine("my name is pratik and i am from ThisClass sayName");

        }

        public static void sayNameStatic()
        {
            Console.WriteLine("my name is pratik and i am from ThisClass sayNameStatic");

        }


    }



}
