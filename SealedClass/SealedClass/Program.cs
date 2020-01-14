using System;

namespace SealedClass
{
    class Program
    {
        //Sealed classes are used to restrict the inheritance feature of object oriented programming.
        
        static void Main(string[] args)
        {
            Wolverine wolverine = new Wolverine();
            wolverine.Adamantium();

            CaptainAmerica captainAmerica = new CaptainAmerica();
            captainAmerica.Vibranium();
        }
    }

    sealed class Wolverine
    {
        public void Adamantium()
        {
            Console.WriteLine("haha i have adamantium");
        }
    }

    sealed class CaptainAmerica
    {
        public void Vibranium()
        {
            Console.WriteLine("haha i have vibranium");
        }
    }

    /*
     * 
    public class SuperHeroes : CaptainAmerica
    {

    }
    this can not be done because CaptainAmerica is a sealed class

    */

        /*
    public class SuperHeroes: Wolverine
    {

    }
    Even this can not be inherited because Wolverine is a Sealed class
    */
}
