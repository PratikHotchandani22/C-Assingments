using System;

namespace AbstractAndVirtual
{
    class Program
    {

        //virtual methods provide run time polymorphism, it can have implementation but it can be overridden by subclasses
        //abstract methods do not have implementation in them, abstract classes can have non-abstract members and it is necessary for all the methods to be implemented if an abstract class is inherited.
        // there is no thing as virtual class, there can only be virtual methods. 
        // there can be both classes and methods in case of abstract keyword
        //abstract class must contain atleast one abstract method.

        static void Main(string[] args)
        {
            Student student = new Student();
            student.sayName();
            DerivedStudent derivedStudent = new DerivedStudent();
            derivedStudent.sayName();
            DerivedManager derivedManager = new DerivedManager();
            derivedManager.sayName();
            
        }
    }


    public class Student
    {
        //since virual class can have implementation, we can implement it here.
        public virtual void sayName()
        {
            Console.WriteLine("My name is Pratik and i am from a virtual method sayName()");
        }
    }

    public class DerivedStudent : Student
    {
        public override void sayName()
        {
            Console.WriteLine("My name is not pratik and i am from a derived class of virtual method sayName()");
        }
    }

    public abstract class Manager
    {
        public abstract void sayName();
        public void sayNameAgain()
        {
            //we only need a body for non abstract methods inside an abstract class.
        }
    }

    public class DerivedManager : Manager
    {
        public override void sayName()
        {
            Console.WriteLine("I am from DerivedManager class which was derived from abstract Manager class, i was implemented in DerivedManger class and was only made in abstract manager class");

        }

        //since sayNameAgain is not of abstract type, we dont need to implement it.



    }
}
