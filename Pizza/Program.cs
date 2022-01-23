using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Dough dough1 = new Dough(FlourTypeEnum.Wholegrain, BakingTypeEnum.Homemade, 2500);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Dough myDough = new Dough(FlourTypeEnum.White, BakingTypeEnum.Chewy, 100);
            Console.WriteLine(myDough.GetCalories());

            try
            {
                Topping topping1 = new Topping(TypeOfToppingEnum.Sauce, 1000);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Topping topping2 = new Topping(TypeOfToppingEnum.Meat, 30);
            Console.WriteLine(topping2.GetCalories());

            Pizza myPizza = new Pizza("Ella", myDough, topping2);
          
        }
    }
}
