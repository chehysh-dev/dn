using System;

namespace B4_Arjun_Nitin
{
    class area
    {
        public void CalculateArea(int side)
        {
            Console.WriteLine("Area of Square = " + (side * side));
        }

        public void CalculateArea(int length, int breadth)
        {
            Console.WriteLine("Area of Rectangle =" + (breadth * length));
        }

        public double CalculateArea(float p, double rad)
        {
            return (p * rad * rad);
        }
    }

    internal class functionoverloading
    {
        static void Main(string[] args)
        {
            area obj = new area();

            Console.WriteLine("Enter the side");
            int side = Convert.ToInt32(Console.ReadLine());
            obj.CalculateArea(side);

            Console.WriteLine("Enter the length of Rectangle :");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the breadth of Rectangle :");
            int breadth = Convert.ToInt32(Console.ReadLine());
            obj.CalculateArea(length, breadth);

            Console.WriteLine("Enter the Radius of circle :");
            double rad = double.Parse(Console.ReadLine());
            Console.WriteLine("circle" + obj.CalculateArea(3.14f, rad));
        }
    }
}
