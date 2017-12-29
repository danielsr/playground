using System;
using System.Collections.Generic;
using Util;

namespace Problems
{
    public class MostFreq
    {
        public static int GetMostFreq(int[] arr)
        {
            int mostFreq = 0, maxCount = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;

                if (dict.ContainsKey(arr[i]))
                    count = dict[arr[i]] += count;
                else
                    dict.TryAdd(arr[i], count);

                if (count > maxCount)
                {
                    mostFreq = arr[i];
                    maxCount = count;
                }
            }

            return mostFreq;
        }

        public static void Test()
        {
            int[] nums = Mock.GetIntArray(5, 0, 10);
            int ret = GetMostFreq(nums);

            Console.WriteLine("Given nums: " + nums.ToStringSpaced());
            Console.WriteLine("Return: " + ret.ToString());
        }
    }
}