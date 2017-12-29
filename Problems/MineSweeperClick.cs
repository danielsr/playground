using System;
using System.Collections.Generic;
using Util;

namespace Problems
{
    public class MineSweeperExpand
    {
        public static void Click(int[,] field, int[] click)
        {
            List<int[]> check = new List<int[]>();

            int rows = field.GetLength(0), cols = field.GetLength(1); ;

            if (field[click[0], click[1]] == 0)
                check.Add(click);

            while (check.Count > 0)
            {
                int x = check[0][0], y = check[0][1];

                for (int x2 = (x - 1); x2 <= (x + 1); x2++)
                {
                    for (int y2 = (y - 1); y2 <= (y + 1); y2++)
                    {
                        if (x2 >= 0 && x2 < rows && y2 >= 0 && y2 < cols)
                        {
                            if (field[x2, y2] == 0)
                            {
                                field[x2, y2] = -2;
                                int[] item = new int[] { x2, y2 };
                                if (!check.Contains(item))
                                    check.Add(item);
                            }
                        }
                    }
                }

                //field[x, y] = -2;
                check.RemoveAt(0);
            }
        }

        public static void Test()
        {
            // Creating the Field
            List<int[]> bombs = new List<int[]>();
            bombs.Add(new int[] { 1, 2 });
            bombs.Add(new int[] { 2, 2 });
            int[,] field = MineSweeper2.GetField(bombs, 5, 5);

            // Click
            int[] click = new int[] { 0, 0 };
            Click(field, click);

            Console.WriteLine(field.ToStringSpaced());
        }

    }
}