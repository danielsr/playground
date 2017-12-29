using System;
using System.Collections.Generic;
using Util;

namespace Problems
{
    public class NonRepeating
    {
        public static string GetNonRepeating(string str)
        {
            char[] arr = str.ToCharArray();

            List<char> listAll = new List<char>();
            List<char> listUniq = new List<char>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (listAll.IndexOf(arr[i]) < 0)
                {
                    listAll.Add(arr[i]);
                    listUniq.Add(arr[i]);
                }
                else
                {
                    listUniq.Remove(arr[i]);
                }
            }

            if (listUniq.Count > 0)
                return listUniq[0].ToString();
            else
                return null;
        }

        public static void Test()
        {
            string str = "aabbdbcaabbbc";
            string ret = GetNonRepeating(str);

            Console.WriteLine("Str: " + str);
            Console.WriteLine("Return: " + ret);
        }
    }
}