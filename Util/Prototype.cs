using System;
using System.Text;

namespace Util
{
    public static class ArrayPrototype
    {
        public static String ToStringSpaced(this int[] arr)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                str.Append(arr[i]);
                if (i < (arr.Length - 1))
                    str.Append(", ");
            }

            return str.ToString();
        }

        public static String ToStringSpaced(this int[,] arr)
        {
            StringBuilder str = new StringBuilder();

            for (int x = 0; x < arr.GetLength(0); x++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    str.Append(arr[x, y]);

                    if (y < arr.GetLength(1) - 1)
                        str.Append(", ");
                }
                str.Append(Environment.NewLine);
            }

            return str.ToString();
        }
    }
}