
//problem1
using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int min;
            int max;
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                max = a;
            else
                max = b;

            if (a < b)
                min = a;
            else
                min = b;

            Console.WriteLine("Minimum number = {0}", min);
            Console.WriteLine("Maximum number = {0}", max);
        }
    }
}

//problem2
using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("enter the 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the 3rd number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if(num1 > num3)
            {
                if (num1 > num2)
                {
                    Console.Write("1st number is greatest");
                }
                else
                {
                    Console.Write("3rd number is greatest");
                }
            }
            else if (num2 > num3)
                Console.Write("2nd number is greatest");
            else
                Console.Write("3rd number is greatest");

        }
    }
}

//problem3
using System;
namespace application
{
    class Program
    {
        static void Main(string[] args)

        {
            string s1, s2;

            Console.WriteLine("Enter the first character : ");
            s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the second character : ");
            s2 = Convert.ToString(Console.ReadLine());

            if (s1 == s2)
                Console.WriteLine("characters are equal");
            else
                Console.WriteLine("Characters are not equal");
        }
    }
}

//problem4

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.Write("Enter a string: ");
            str1 = Console.ReadLine();
            Console.Write("Enter another string: ");
            str2 = Console.ReadLine();



            Console.WriteLine("output");
            if (str1.ToUpper() == str2.ToUpper())
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", str1, str2);
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", str1, str2);

            Console.ReadLine();

        }
    }

}


//problem5
using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Enter the Two Numbers : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is the Greatest Number", a);
            }
            else
            {
                Console.WriteLine("{0} is the Greatest Number ", b);
            }
            Console.ReadLine();
        }
    }
}

//problem6
using System;  
namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);
            else Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();
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
            Console.Write("input the marks of C:");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.Write("input the marks of CPP:");
            int CPP = Convert.ToInt32(Console.ReadLine());
            Console.Write("input the marks of CSharp:");
            int CSharp = Convert.ToInt32(Console.ReadLine());
            double total = C + CPP + CSharp;
            double per = total / 3.0;
            string div;
            if (per < 60)
                div = "first";
            else if (per < 60 && per >= 45)
                div = "second";
            else if (per < 45 && per >= 36)
                div = "third";
            else div = "fail";
            Console.Write("grade:" + div);
            Console.ReadLine();
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
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

//problem9
using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("enter number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
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

            int num, r, sum = 0, t;
            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} ", sum);
        }
    }
}


//problem11
using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.Write("Numbers between 100 and 200 : ");
            for (i = 101; i < 200; i++)
            {


                Console.Write("{0}  ", i);
                sum += i;

            }
            Console.Write("The sum : {0} ", sum);
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
            int i, sum = 0;
            Console.Write("Numbers between 100 and 200, divisible by 9 : ");
            for (i = 101; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0}  ", i);
                    sum += i;
                }
            }
            Console.Write("The sum : {0} ", sum);

        }
    }

}

//problem13

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the numbers");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
                Console.WriteLine("zero");
            else if (i % 2 == 0)
            {
                Console.WriteLine("even");
                if (i % 10 == 0)
                {
                    Console.WriteLine("multiple of 10");
                }
                else
                {
                    Console.WriteLine("not a multiple of 10");
                }
                if (i > 100)
                    Console.WriteLine("too large");
            }
            else
            {
                Console.WriteLine("odd");
                Console.WriteLine("not a multiple of 10");
                if (i > 100)
                    Console.WriteLine("too large");
            }
            Console.ReadLine();

        }
    }

}

//problem14

using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int item = 5;
            switch (item)
            {

                case 1:
                    Console.WriteLine("case 1");
                    break;

                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 9:
                    Console.WriteLine("case 9");
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }
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
            int i;
            string s;
            int sum = 100;
            for (i = 0; i < 4; i++)
            {
                s = Console.ReadLine();
                if (s.Equals("HIT"))
                {
                    sum += 10;
                }
                else if (s.Equals("MISS"))
                {
                    sum -= 20;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }



     