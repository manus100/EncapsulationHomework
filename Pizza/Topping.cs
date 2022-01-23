using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    enum TypeOfToppingEnum
    {
        Veggies = 80,
        Sauce = 90,
        Meat = 120,
        Cheese = 150
    }
    class Topping
    {
        int weight;
        const int minWeight = 1;
        const int maxWeight = 50;
        TypeOfToppingEnum typeOfTopping;

        public Topping (TypeOfToppingEnum typeOfTopping, int weight)
        {
            this.TypeOfTopping = typeOfTopping;
            this.Weight = weight;
        }

        public TypeOfToppingEnum TypeOfTopping
        {
            get
            {
                return this.typeOfTopping;
            }
            private set
            {
                if (!Enum.IsDefined(typeof(TypeOfToppingEnum), value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.typeOfTopping = value;
            }
        }


        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"{value} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        private decimal GetToppingValue()
        {
            return (decimal)typeOfTopping / 100;
        }

        public decimal GetCalories()
        {
            return this.Weight * 2 * GetToppingValue();
        }

    }
}


/*Step 3. Create a Topping Class Next, you need to create a Topping class. It can be of four different types – meat, veggies, cheese or a sauce. 
A topping has a weight in grams. The calories per gram of topping are calculated depending on its type. The base calories per gram are 2. 
Every different type of topping has a modifier. For example, meat has a modifier of 1.2, so a meat topping will have 1.2 calories per gram (1 * 1.2). 
Everything that the class should expose is a getter for calories per gram. You are given the modifiers below: 
Modifiers: • Meat – 120; • Veggies – 80; • Cheese – 150; • Sauce – 90; Your task is to create the class with a proper constructor, fields, getters and setters. 
Make sure you use the proper access modifiers. 

Step 4. Validate Data for the Topping Class Change the internal logic of the Topping class by adding a data validation in the setter. Make sure the topping is one of the 
provided types, otherwise throw a proper exception with the message "Cannot place [name of invalid argument] on top of your pizza.".

 The allowed weight of a topping is in the range [1..50] grams. If it is outside of this range throw an exception with the message "[Topping type name] weight should be 
in the range [1..50].". Exception Messages • "Cannot place [name of invalid argument] on top of your pizza." • "[Topping type name] weight should be in the range [1..50]."
Instantiate the class a test in your main method that reads a single dough and a topping after that and prints their calories divided by 100.*/