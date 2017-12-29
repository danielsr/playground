using System;
using System.Collections.Generic;
using Util;

namespace Problems
{
    public class TwoThatMultiplies
    {
        public static int[] GetTwo(int[] arr, int target)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if ((target % arr[i]) == 0)
                    {
                        int compl = target / arr[i];

                        if (dict.ContainsKey(compl))
                            return new int[] { arr[i], compl };

                        dict.TryAdd(compl, i);
                    }
                }
            }

            throw new Exception("No two that multiplies");
        }

        public static void Test()
        {
            int[] nums = Mock.GetIntArray(30, 0, 10);
            int target = 10;
            int[] ret = TwoThatMultiplies.GetTwo(nums, target);

            Console.WriteLine("Given nums: " + nums.ToStringSpaced());
            Console.WriteLine("Target: " + target.ToString());
            Console.WriteLine("Return: " + ret.ToStringSpaced());
        }
    }
}