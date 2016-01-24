using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeRunner
{
    class runMaze
    {
        public static void loadMaze(int[,] a)
        {
            Console.WriteLine("Maze Loaded");
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            int startPosX = 0;
            int startPosY = 0;
            int depth = 10;
            for (int x = 0; x < row; x++)
            {
                if (a[x, 0] == 0)
                {
                    startPosX = x;
                    break;
                }
            }
            menu.displayMenu(3);
            run(a, startPosX, startPosY, depth);

        }

        public static void run(int[,] a, int x, int y, int depth)
        {
            int counter = 0;
            if(counter == depth)
            {
                Console.WriteLine("There is no solution at this depth");
            }
            else
            {
                menu.displayMenu(4);
                counter++;
                // Right
                if(a[++x, y] == 0)
                {
                    run(a, x, y, depth);
                    --x;
                }
                else
                {
                    --x;
                }

                // Left
                if (a[--x, y] == 0)
                {
                    run(a, x, y, depth);
                    ++x;
                }
                else
                {
                    ++x;
                }

                // Up
                if (a[x, ++y] == 0)
                {
                    run(a, x, y, depth);
                    --y;
                }
                else
                {
                    --y;
                }

                // Down
                if (a[x, --y] == 0)
                {
                    run(a, x, y, depth);
                    ++y;
                }
                else
                {
                    ++y;
                }
            }
        }
    }
}
