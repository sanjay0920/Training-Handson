using System;
namespace application
{
    delegate string delegate_method(string str);
    class delegate_test1
        {
            static void Main(string[] args)
            {

                string str;
                int l = 0;


                Console.Write("Input the string : ");
                str = Console.ReadLine();

                foreach (char chr in str)
                {
                    l += 1;

                }

                Console.Write("Length of the string is : {0}\n\n", l);
            }
        }
    }
