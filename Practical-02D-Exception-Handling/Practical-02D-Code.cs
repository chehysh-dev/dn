using System;

class invalidage : Exception
{
    public invalidage(String msg) : base(msg)
    {
    }
}

class excepthan
{
    static void ValidateAge(int age)
    {
        if (age < 0 || age > 100)
        {
            throw new invalidage("invalid Age");
        }
    }

    public static void Main(string[] args)
    {
        try
        {
            int a = 10, b = 2;
            Console.WriteLine(a / b);
        }
        catch (DivideByZeroException)
        {
            Console.Write("Deniminator should not be zero");
        }
        finally
        {
            Console.Write("In Finally....");
        }

        try
        {
            Console.Write("\nEnter age: ");
            int age = int.Parse(Console.ReadLine());
            ValidateAge(age);
        }
        catch (invalidage ex)
        {
            Console.WriteLine("Try with other Input !");
        }
    }
}
