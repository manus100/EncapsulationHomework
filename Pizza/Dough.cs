using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
   public enum FlourTypeEnum
    {
        White =150,
        Wholegrain =100
    }

    enum BakingTypeEnum
    {
        Crispy = 90,
        Homemade = 100,
        Chewy =110        
    }



    class Dough
    {
        FlourTypeEnum flourType;
        BakingTypeEnum bakingType;
        const int minWeight = 1;
        const int maxWeight = 200;
        int weight;


        public Dough(FlourTypeEnum flourType, BakingTypeEnum bakingType, int weight)
        {
            FlourType = flourType;
            BakingType = bakingType;
            Weight = weight;
          
        }

        //pentru ca am folosit enum-uri practic nu mai pot avea erori pt flourType si backingType...
        public FlourTypeEnum FlourType
        {
            get => this.flourType;
            private set
            {
                if (!Enum.IsDefined(typeof(FlourTypeEnum), value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public BakingTypeEnum BakingType
        {
            get => this.bakingType;
            private set
            {
                if (!Enum.IsDefined(typeof(BakingTypeEnum), value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingType = value;
            }
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException("Invalid type of dough. Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

     
        private decimal GetFlourType()
        {
            return (decimal)flourType / 100;
        }

        private decimal GetBakingType()
        {
            return (decimal)bakingType / 100;
        }

        public decimal GetCalories()
        {  
            return this.weight * 2 * GetFlourType() * GetBakingType();
        }

    }
}


/*Create the Dough class. It has FlourType which can be white or wholegrain. It has BakingType which can be crispy, chewy or homemade
Modifiers: • White – 150; • Wholegrain – 100; • Crispy – 90; • Chewy – 110; • Homemade – 100;

Step 2. Validate Data for the Dough Class Change the internal logic of the Dough class by adding a data validation in the setters. 
Make sure that if invalid flour type or an invalid baking technique is given a proper exception is thrown with the message "Invalid type of dough.". 
The allowed weight of a dough is in the range [1..200] grams. If it is outside of this range throw an exception with the message "Dough weight should be in the range [1..200].". 
Exception Messages "Invalid type of dough." "Dough weight should be in the range [1..200]."

*/