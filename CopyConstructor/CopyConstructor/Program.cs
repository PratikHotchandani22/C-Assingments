using System;

namespace CopyConstructor
{
    class Program
    {
        //copying data from one object to another

        static void Main(string[] args)
        {
            GlobalTechPark gtp = new GlobalTechPark("WEST",1);
            GlobalTechPark gtp2 = new GlobalTechPark(gtp);
            Console.WriteLine("details from parameterized constructor");
            gtp.showDetails();
            Console.WriteLine("details from copy constructor");
            gtp2.showDetails();


        }
    }

    class GlobalTechPark
    {
        string CompanyName;
        int CompanyId;


        //copy constructor
        public GlobalTechPark(GlobalTechPark gtp)
        {
            CompanyName = gtp.CompanyName;
            CompanyId = gtp.CompanyId;
        }

        //parameterized constructor
        public GlobalTechPark(string name, int id)
        {
            this.CompanyName = name;
            this.CompanyId = id;
        }

        public void showDetails()
        {
            Console.WriteLine("name: " + CompanyName + "id : " + CompanyId );
        }

    }

}
