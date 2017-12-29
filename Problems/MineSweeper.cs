using System;
using System.Collections.Generic;
using Util;

namespace Problems
{
    public class MineSweeper
    {

        private static int[,] GetField(List<int[]> bombs, int rows, int cols)
        {
            // Create the Field
            int[,] field = new int[rows, cols];

            // Plant the bombs
            foreach (int[] bomb in bombs)
                field[bomb[0], bomb[1]] = -1;

            // Measure the risk
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    if (field[x, y] != -1)
                    {
                        int bombCount = 0;

                        for (int x2 = (x - 1); x2 <= (x + 1); x2++)
                        {
                            for (int y2 = (y - 1); y2 <= (y + 1); y2++)
                            {
                                if (x2 >= 0 && x2 < rows && y2 >= 0 && y2 < cols)
                                {
                                    if (field[x2, y2] == -1)
                                        bombCount++;
                                }
                            }
                        }

                        field[x, y] = bombCount;
                    }
                }
            }

            // Return 
            return field;
        }

        public static void Test()
        {

            List<int[]> bombs = new List<int[]>();
            bombs.Add(new int[] { 2, 2 });
            bombs.Add(new int[] { 2, 4 });
            int[,] ret = GetField(bombs, 4, 4);

            Console.WriteLine(ret.ToStringSpaced());
        }

    }
}