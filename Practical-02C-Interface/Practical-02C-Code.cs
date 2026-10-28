using System;

interface Area
{
    double compute(double x);
}

class square : Area
{
    public double compute(double x)
    {
        return x * x;
    }
}

class circle : Area
{
    public double compute(double x)
    {
        return Math.PI * x * x;
    }
}

class interf
{
    public static void Main(string[] args)
    {
        square sq = new square();
        circle c = new circle();
        Area a;

        a = sq as Area;
        Console.WriteLine("Area of Square=" + a.compute(10.0));

        a = c as Area;
        Console.WriteLine("Area of Circle=" + a.compute(10.0));
    }
}
