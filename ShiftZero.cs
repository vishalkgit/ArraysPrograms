using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8. Shift all zeros in the beginning of array/ Shift zeros at end

namespace ArraysPrograms
{
    public class ShiftZero
    {
        static void ShiftZeros(int[] arr)
        {
            int n=arr.Length;
            int notZeroIndex = n - 1;

            for (int i = n-1;i>=0;i--)
            {
                if (arr[i]!=0)
                {
                    arr[notZeroIndex] = arr[i];
                    notZeroIndex--;
                }
            }
            while (notZeroIndex > 0)
            {
                arr[notZeroIndex] = 0;
                notZeroIndex--;
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
        //    int[] arr = { 1, 0,2, 0,5,0, 3, 0, 4, 0, 5 };
        //    Console.WriteLine("Original Array");
        //    PrintArray(arr);

        //    ShiftZeros(arr);
        //    Console.WriteLine("Arrayy after shiftinng zeros to beginning");
        //    PrintArray(arr);
        //}
    }
}
