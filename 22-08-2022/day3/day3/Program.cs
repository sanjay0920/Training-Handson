//problem1

using System;
    namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.Write("Input 10 elements in the array :");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("");
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
            int i, n;
            int[] a = new int[100];
            Console.Write("Input the number of element store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(" array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("array in reverse are :");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("");
        }
    }
}

//problem3

using System;
    namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            int[] a = new int[100];
            Console.Write("Input the number of elements in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements  in the array is : {0}", sum);
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
            int[] arr1 = new int[100];
            int i, max, min, n;
            Console.Write("Input the number of elements in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            max = arr1[0];
            min = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }


                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}", max);

            Console.Write("Minimum element is : {0}", min);
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
            int[] arr1 = new int[10];
            int n, i, j, tmp;
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("Elements of array in sorted ascending order:");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("");
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
           int[] arr = new int[] {
            1,3,5,200,22,2244,213,111
         };
         
         int res = 100;
         Console.WriteLine("Integer {0}: ", res);
         Console.WriteLine("Numbers larger than {0} = ", res);
         for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > res) {
               Console.WriteLine(arr[i]);	
            }
         }
        }
    }
}

//problem15

using System;
using System.Collections.Generic;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
           int[] arr = new int[] {1, 5, 3, 4, 3, 5, 6};
           int min = -1;
          
        HashSet<int> set = new HashSet<int>();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (set.Contains(arr[i]))
            {
                min = i;
            }
 
            else 
            {
                set.Add(arr[i]);
            }
        }
        if (min != -1)
        {
          Console.WriteLine("The first repeating element is " + arr[min]);
        }
        else
        {
          Console.WriteLine("There are no repeating elements");
        }
    }
}
}





