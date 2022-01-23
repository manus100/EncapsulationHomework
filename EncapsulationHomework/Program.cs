using System;

namespace EncapsulationHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person firstPerson = new Person("Tudor", -2);
            } 
            catch (ArgumentException)
            {
                Console.WriteLine("Age must be a positive number!");
            }

            Person secondPerson = new Person("Bogdan", 34);
            

            try
            {
                Child firstChild = new Child("Maria", 16);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("A child cannot be older than 15!");
            }

            Child secondChild = new Child("Andreea", 7);
           
        }
    }
}
