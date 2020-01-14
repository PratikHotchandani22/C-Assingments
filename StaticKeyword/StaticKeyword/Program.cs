using System;

namespace StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer.Myid = 1;
            Customer.GetDetails();
            Customer.ShowDetails();


        }
    }
    public static class Customer
    {
        //only staic classes allowed
        //    public void getDetails()
        //    {

        //    }

        public static string name;
        public static int id;
        public static int Myid { get; set; }


        public static void GetDetails()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("ented id");
            id = Convert.ToInt32(Console.ReadLine());
        }

        public static void ShowDetails()
        {
            Console.WriteLine("name: " + name + " id: "+ id + " Myid: " + Myid);
        }
    }
}
