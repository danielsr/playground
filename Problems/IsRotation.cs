using System;
using Util;

namespace Problems
{
    public class IsRotation
    {
        public static bool GetIsRotation(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            int key = arr1[0], keyIndex = -1;

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == key)
                {
                    keyIndex = i;
                    break;
                }
            }

            if (keyIndex == -1)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                int j = (keyIndex + i) % arr1.Length; // here is the secret: Mod
                if (arr1[i] != arr2[j])
                {
                    return false;
                }
            }

            return true;
        }

        public static void Test()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = new int[] { 4, 5, 6, 7, 1, 2, 3 };
            bool ret = GetIsRotation(arr1, arr2);

            Console.WriteLine("Arr 1: " + arr1.ToStringSpaced());
            Console.WriteLine("Arr 2: " + arr2.ToStringSpaced());
            Console.WriteLine("Return: " + ret.ToString());
        }
    }
}