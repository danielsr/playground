using System;
using System.Collections.Generic;
using Util;

namespace Problems
{
    // https://leetcode.com/problems/two-sum/description/
    public class TwoSum
    {
        public static int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int compl = target - nums[i];
                if (map.ContainsKey(compl))
                    return new int[] { map[compl], i };
                
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }
            throw new Exception("No two sum solution");
        }

        public static void Test()
        {
            int[] nums = Mock.GetIntArray(30, 0, 10);
            int target = 9;
            int[] ret = TwoSum.GetTwoSum(nums, target);

            Console.WriteLine("Given nums: " +  nums.ToStringSpaced());
            Console.WriteLine("Target: " +  target.ToString());
            Console.WriteLine("Return: " + ret.ToStringSpaced());
        }
        
    }
}