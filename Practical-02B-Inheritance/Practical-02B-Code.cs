using System;

namespace B4_Arjun_Nitin
{
    class vehicle
    {
        string name = "Audi";

        public void dispvehicle()
        {
            Console.WriteLine("vehicle name =" + name);
        }
    }

    class car : vehicle
    {
        string model = "2026";

        public void dispcar()
        {
            dispvehicle();
            Console.WriteLine("Car model =" + model);
        }
    }

    class sportscar : car
    {
        int speed = 450;

        public void dispsportscar()
        {
            dispcar();
            Console.WriteLine("Max speed =" + speed);
        }
    }

    class bike : vehicle
    {
        string type = "classic";

        public void dispbike()
        {
            dispvehicle();
            Console.WriteLine("bike type =" + type);
        }
    }

    internal class inheritance
    {
        static void Main(string[] args)
        {
            sportscar s = new sportscar();
            bike b = new bike();

            s.dispsportscar();
            b.dispbike();
        }
    }
}
