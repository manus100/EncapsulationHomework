using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationHomework
{
    class Person
    {
          string name;   //default sunt private
          int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }

       
        public string  Name
        {
            get
            {
                return this.name;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be a positive number!");
                }
            }
        }

    }
}
