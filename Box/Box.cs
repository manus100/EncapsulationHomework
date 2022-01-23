using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Box
    {
        int length;  //default e private
        decimal width;
        decimal height;

        public Box(int length, decimal width, decimal height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public int Length
        {
            get
            {
                return this.length;
            }
         private set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Length must be greater than 0!");
                }
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
           private set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Width must be greater than 0!");
                }
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height must be greater than 0!");
                }
            }
        }

        public decimal GetSurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public void GetLaterarSurfaceArea()
        {
            Console.WriteLine($"Lateral surface area: { 2 * length * height + 2 * width * height}"); 
        }

        public override string ToString() 
        {
            return "Box length: " + Length + " width: " + Width + " height: " + Height;
        }

        public void GetVolume()
        {
            Console.WriteLine($"Volume: {length * width * height}");
        }
    }
}

/*You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three parameters, 
 that are mandatory.

All three size need to be > 0
Add a method named GetSurfaceArea that computes the surface area using the formula: 2 * length * width + 2 * length * height + 2 * width * height;
Add a method named GetLaterarSurfaceArea that computes and displays the surface area using the formula:
2 * length * height + 2 * width * height;
Override ToString() method to display information about this class
Add a method named GetVolume that computes and displays the volume using the formula: length * width * height; Requirements: Encapsulate end validate the members.
*/