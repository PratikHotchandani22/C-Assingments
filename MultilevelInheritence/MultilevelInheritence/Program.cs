using System;

namespace MultilevelInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            //because of multilevel inheritence, we can get function of directors and managers from the object of interns
            Interns interns = new Interns();
            interns.displayPositionInterns();
            interns.displayPositionManager();
            interns.displayPositionDirector();
        }
    }


    class Directors
    {
        public void displayPositionDirector()
        {
            Console.WriteLine("I am director.");
        }
    }


    class Managers : Directors
    {
        public void displayPositionManager()
        {
            Console.WriteLine("I am manager.");
        }

    }

    class Interns : Managers
    {
        public void displayPositionInterns()
        {
            Console.WriteLine("I am an intern.");
        }
    }
}
