using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[4][];


            jagged_arr[0] = new int[] { 1, 23 };
            jagged_arr[1] = new int[] { 2, 34 };
            jagged_arr[2] = new int[] { 3, 23 };
            jagged_arr[3] = new int[] { 4, 45 };


            for (int n = 0; n < jagged_arr.Length; n++)
            {


                System.Console.Write("Row({0}): ", n);

                for (int k = 0; k < jagged_arr[n].Length; k++)
                {
                    System.Console.Write("{0} ", jagged_arr[n][k]);
                }
            }
        }
    }
}