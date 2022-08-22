//problem6

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look older than {0} ", age);
        }
    }
}

//problem7

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}

//problem8

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }
    }

}

//problem10

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("output:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
        }
    }

}

//problem12

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            string nullStr = null;
            Console.WriteLine(String.IsNullOrEmpty(nullStr));

            string emptyStr1 = "";
            Console.WriteLine(String.IsNullOrEmpty(emptyStr1));

            string emptyStr2 = String.Empty;
            Console.WriteLine(String.IsNullOrEmpty(emptyStr2));

            string str = "hello";
            Console.WriteLine(String.IsNullOrEmpty(str));

        }
    }

}

//problem13

using System;

public class Distance
{
    public static double MeterToKilometer(double meter)
    {
        double KM = 0;

        KM = meter / 1000;

        return KM;
    }

    public static double KilometerToMeter(double km)
    {
        double METER = 0;

        METER = km * 1000;

        return METER;
    }

    static void Main()
    {
        double meter = 0;
        double km = 0;

        Console.Write("Enter the value of meter : ");
        meter = double.Parse(Console.ReadLine());

        km = MeterToKilometer(meter);
        Console.WriteLine("Kilometer : " + km + "km");

        Console.Write("Enter the value of kilometer : ");
        km = double.Parse(Console.ReadLine());

        meter = KilometerToMeter(km);
        Console.WriteLine("Meter : " + meter + "m");

    }
}

//problem16

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            String emplynm = "";
            int deptnum = 0;
            string name = String.Empty;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                string greet = string.Concat(s, name);
                Console.Write(greet);
                Console.WriteLine("enter the deptnum");
                deptnum = Convert.ToInt32(Console.ReadLine());
                if (deptnum != 0 && (deptnum >= 1 || deptnum < 10))
                {
                    Console.WriteLine("thanks for input");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Enter the employee name");
                        emplynm = Console.ReadLine();
                        Console.WriteLine("enter his designation");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("enter the valid deptnum");
                }
            }

        }
    }
}


