using System;
using Util;

namespace Problems
{
    public class Rotating90
    {
        private static int[,] Rotate(int[,] arr)
        {
            int[,] ret = (int[,])arr.Clone();

            int len = arr.GetLength(0);

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    int[] newPos = NewPos(new int[] { i, j }, len);
                    ret[newPos[0], newPos[1]] = arr[i, j];
                }
            }

            return ret;
        }

        private static int[] NewPos(int[] pos, int len)
        {
            return new int[] { pos[1], len - 1 - pos[0] };
        }

        public static void Test()
        {
            int[,] arr = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            arr = Rotate(arr);

            Console.WriteLine(arr.ToStringSpaced());
        }

    }
}