using System;
using System.Collections.Generic;
using System.Linq;
using Util;

namespace Problems
{
    public class CommonElements
    {
        public static int[] GetCommon(int[] arr1, int[] arr2)
        {
            List<int> res = new List<int>();
            int p1 = 0, p2 = 0;
            while (p1 < arr1.Length && p2 < arr2.Length)
            {
                if (arr1[p1] == arr2[p2]) {
                    res.Add(arr1[p1]);
                    p1++;
                    p2++;
                }
                else if (arr1[p1] > arr2[p2]) {
                    p2++;
                }
                else {
                    p1++;
                }
            }
            return res.ToArray();
        }
        public static void Test()
        {
            int[] arr1 = new int[] { 1, 3, 4, 6, 7, 9 };
            int[] arr2 = new int[] { 1, 2, 5, 9, 10 };
            int[] ret = GetCommon(arr1, arr2);

            Console.WriteLine("Arr 1: " + arr1.ToStringSpaced());
            Console.WriteLine("Arr 2: " + arr2.ToStringSpaced());
            Console.WriteLine("Return: " + ret.ToStringSpaced());
        }
    }
}