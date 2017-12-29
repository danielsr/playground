using System;
using System.Collections;
using System.Collections.Generic;
using Util;

namespace Problems
{
    public class IsOneAway
    {
        private static bool GetIsOneAway(string s1, string s2)
        {
            if (Math.Abs(s1.Length - s2.Length) > 1)
                return false;
            else if (s1.Length == s2.Length)
                return EqualLen(s1, s2);
            else if (s1.Length > s2.Length)
                return DifLen(s1, s2);
            else
                return DifLen(s2, s1);
        }

        private static bool EqualLen(string s1, string s2)
        {
            int diff = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Substring(i, 1) != s2.Substring(i, 1))
                {
                    diff++;
                    if (diff > 1)
                        return false;
                }
            }

            return true;
        }

        private static bool DifLen(string s1, string s2)
        {
            int diff = 0, i = 0;

            while (i < s2.Length)
            {
                if (s1.Substring(i + diff, 1) == s2.Substring(i, 1))
                {
                    i++;
                }
                else
                {
                    diff++;
                    if (diff > 1)
                        return false;
                }
            }

            return true;
        }

        public static void Test()
        {
            string s1 = "abc";
            string s2 = "bcc";
            bool ret = GetIsOneAway(s1, s2);

            Console.WriteLine("Str 1: " + s1);
            Console.WriteLine("Str 2: " + s2);
            Console.WriteLine("Return: " + ret.ToString());
        }
    }
}