using System;
using System.Collections.Generic;
using Util;

namespace Problems
{
    public class MineSweeper2
    {

        public static int[,] GetField(List<int[]> bombs, int rows, int cols)
        {
            // Create the Field
            int[,] field = new int[rows, cols];

            // Plant the bombs 
            foreach (int[] bomb in bombs)
            {
                int x = bomb[0], y = bomb[1];

                field[x, y] = -1;

                for (int x2 = (x - 1); x2 <= (x + 1); x2++)
                {
                    for (int y2 = (y - 1); y2 <= (y + 1); y2++)
                    {
                        if (x2 >= 0 && x2 < rows && y2 >= 0 && y2 < cols)
                        {
                            if (field[x2, y2] != -1)
                                field[x2, y2]++;
                        }
                    }
                }
            }

            // Return 
            return field;
        }

        public static void Test()
        {

            List<int[]> bombs = new List<int[]>();
            bombs.Add(new int[] { 1, 1 });
            bombs.Add(new int[] { 1, 3 });
            int[,] ret = GetField(bombs, 4, 4);

            Console.WriteLine(ret.ToStringSpaced());
        }

    }
}