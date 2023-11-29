using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_one_dimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] check = { -1, 34, 56 };
            Console.WriteLine(SumPlus(check, check.Length-1));






        }
        public static int SumArr(int[] arr)
        {
            return SumArr(arr,arr.Length);
        }


        public static int SumArr(int[] arr,int i)//הפעולה מקבלת מערך של מספרים שלמים arr ו אינדקס i שהוא התא האחרון במערך
        {
            if (i == 0)
            {
                return arr[0];

            }
            return arr[i]+SumArr(arr,i-1);
        }



        public static int SumPlus(int[] arr)
        {
            return SumArr(arr, arr.Length);
        }
        public static int SumPlus(int[]arr,int i)
        {

            if (i == 0)
            {
                if (arr[0] > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }

            if (arr[i] > 0)
            {

                return 1 + SumArr(arr, i - 1);
            }

            
            return SumPlus(arr, i-1);
        }







    }
}
