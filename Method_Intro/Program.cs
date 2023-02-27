using System;

namespace Method_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //--------------------------------------------------------------------
            int count = 0;
            int[] arr = { 4, 4, 5, 3, 44, 55, 2, 78, 9 };
            int num = 4;
            Method(arr, num);

            void Method(int[] arr, int num)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (num == arr[i])
                    {
                        Console.WriteLine("Bu eded array-de var");
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (count == arr.Length)
                {
                    Console.WriteLine("Bu eded arrayde yoxdur");
                }
            }








            //task2
            //----------------------------------------------------------------------
            int result = 0;
            Console.WriteLine(BiggerNumber(2, 4, 65, 5, 3, 43299, 342, 1231, 9999));
            int BiggerNumber(params int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > result)
                    {
                        result = arr[i];
                    }
                }
                return result;
            }






        }
    }
}
