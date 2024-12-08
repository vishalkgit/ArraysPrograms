using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//7.WAP to replace the negative elements in an array with immediate left elements square
//ar ={ 1,2,-3,2,-4,-6}
//op ={ 1,2,4,2,4,16}
//here-> - 3 is replaced by square of 2 which is 4

namespace ArraysPrograms
{
    public class ReplaceNegative
    {
        static void ReplaceNegativeWithSquare(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i] = arr[i - 1] * arr[i-1];
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] ar = { 1, 2, -3, 2, -4, -6 };
        //    Console.WriteLine("Original Array");
        //    PrintArray(ar);

        //    ReplaceNegativeWithSquare(ar);
        //    PrintArray(ar);
        //}
        
    }
}
