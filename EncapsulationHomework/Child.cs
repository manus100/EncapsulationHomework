using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationHomework
{
    class Child : Person
    {
        private string name;
        private int age;

        public Child(string name, int age) : base(name, age)
        {
            //numele il setez prin parinte
            this.Age = age;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 15)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("A child cannot be older than 15");
                }
            }

        }
        



    }
}
