using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_one_dimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] check = { 1, 1, 1, 3 };
            //Console.WriteLine(maxArr(check));

            int[] check = { 4, -8, 5, 6 };
            Program program = new Program();
            Console.WriteLine(program.IsSidra(check)); // cheack about that

        }
        public static int SumArr(int[] arr)
        {
            return SumArr(arr, arr.Length);
        }


        public static int SumArr(int[] arr, int i)//הפעולה מקבלת מערך של מספרים שלמים arr ו אינדקס i שהוא התא האחרון במערך
        {
            if (i == 0)
            {
                return arr[0];

            }
            return arr[i] + SumArr(arr, i - 1);
        }



        public static int SumPlus(int[] arr)
        {
            return SumPlus(arr, arr.Length - 1);
        }
        public static int SumPlus(int[] arr, int i)
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

                return 1 + SumPlus(arr, i - 1);
            }


            return SumPlus(arr, i - 1);
        }

        public static bool numIn(int[] arr, int num)
        {
            return numIn(arr, arr.Length - 1, num);
        }

        public static bool numIn(int[] arr, int i, int num)
        {
            if (i == 0)
            {
                if (arr[i] == num)
                {
                    return true;
                }

                return false;
            }

            if (arr[i] == num)
            {
                return true;
            }

            return numIn(arr, i - 1, num);
        }

        public static bool allEqual(int[] arr)
        {
            return allEqual(arr, arr.Length - 1);
        }

        public static bool allEqual(int[] arr, int i)
        {

            if (i == 1)
            {
                if (arr[i] == arr[i-1])
                {
                    return true;
                }

                return false;
            }

            if (arr[i] == arr[i-1])
            {
               
                return numIn(arr, i - 1);
            }
            return false;
        }


        public  int maxArr(int[] arr)
        {
            return maxArr(arr, arr.Length - 1);
        }


        public int maxArr(int[] arr, int i)
        {
            if (i == 0)
            {
                return arr[i];
            }

            int currentMax = arr[i];
            int previousMax = maxArr(arr, i - 1);

            if (currentMax > previousMax)
            {
                return currentMax;
            }
            else
            {
                return previousMax;
            }
        }


        public bool IsSorted(int[] arr)
        {
            return IsSorted(arr, arr.Length - 1);
        }

        private bool IsSorted(int[] arr, int i)
        {
            if (i <= 0)
            {
                return true; // אם הגענו לתחילת המערך, הוא בהכרח ממוין
            }

            // בדיקה אם האיבר הנוכחי קטן או שווה לאיבר הקודם
            if (arr[i] < arr[i - 1])
            {
                return false;
            }

            // המשך לבדוק את שאר המערך
            return IsSorted(arr, i - 1);
        }


        public bool IsSidra(int[] arr)
        {
            return IsSidra(arr, arr.Length - 1);
        }

        public bool IsSidra(int[] arr, int i)
        {
            if (i <= 1)
            {
                return true; // אם הגענו לתחילת המערך או יש בו רק איבר אחד, הוא בהכרח מהווים סדרה חשבונית
            }

            // בדיקה אם ההפרש בין האיבר הנוכחי לבין האיבר הקודם שונה מההפרש הראשוני
            if ((arr[i] - arr[i - 1]) != (arr[i - 1] - arr[i - 2]))
            {
                return false;
            }

            // המשך לבדוק את שאר המערך
            return IsSidra(arr, i - 1);
        }

    }
}

