using System;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Box box1 = new Box(10, 0, 10M);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            Box box2 = new Box(10, 3.5M, 5);
            Console.WriteLine(box2.ToString());
            Console.WriteLine("Box surface area: " + box2.GetSurfaceArea());
            box2.GetLaterarSurfaceArea();
            box2.GetVolume();
           

        }
    }
}
