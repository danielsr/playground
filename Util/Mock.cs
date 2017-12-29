using System;
using System.Text;

namespace Util
{
    public class Mock
    {
        public static int[] GetIntArray(int size, int min, int max)
        {
            int[] arr = new int[size];

            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(min, max);
            }

            return arr;
        }
    }

}