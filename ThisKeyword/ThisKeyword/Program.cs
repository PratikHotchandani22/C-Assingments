using System;

namespace ThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(01,21,"Pratik","WEST");
            Employee emp2 = new Employee(02, 22, "Ankit", "WEST");
            emp1.showDetails();
            emp2.showDetails();


        }
    }

    class Employee
    {
        public int id;
        public int age;
        public string name;
        public string departName;

        public Employee(int id1, int age1, string name1, string departName1)
        {
            this.id = id1;
            this.name = name1;
            this.age = age1;
            this.departName = departName1;
        }

        public void showDetails()
        {
            Console.WriteLine("Name of employee is: " + name + " age of employee is: " + age + " id of employee is: " + id + " Department name of employee is: " + departName);
        }
    }
}
