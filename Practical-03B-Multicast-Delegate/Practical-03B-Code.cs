using System;

namespace multicast_delegate
{
    delegate void Mdelegate();

    class DM
    {
        public static void display()
        {
            Console.WriteLine("hello");
        }

        public static void Print()
        {
            Console.WriteLine("hello world");
        }
    }

    class Mtest
    {
        public static void Main()
        {
            Mdelegate m1 = new Mdelegate(DM.display);
            Mdelegate m2 = new Mdelegate(DM.Print);
            Mdelegate m3 = m1 + m2;
            Mdelegate m4 = m2 + m1;
            Mdelegate m5 = m3 - m2;

            Console.WriteLine("delegate M3:");
            m3();

            Console.WriteLine("delegate M4:");
            m4();

            Console.WriteLine("delegate M5:");
            m5();
        }
    }
}
