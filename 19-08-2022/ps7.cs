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