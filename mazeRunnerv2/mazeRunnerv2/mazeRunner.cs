// Created by Seunghyun Yoo
// At:      10.16.2014
// Latest:  10.19.2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeRunnerv2
{
    class mazeRunner
    {
        // Initialize the 2D array pre solve
        private int[,] maze;
        // Initialize the 2D array post solve
        private int[,] mazeSolved;
        // Our starting X/Y Coordinates
        private int yC = 0;
        private int xC = 0;
        // Minimum required depth to solve a maze
        private int solDepth = 0;
        // Boolean for a found solution
        private bool isSolved = false;
        // Enum for Directions
        private enum direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT,
        };

        // Constructor takes 2D array and the starting depth of our search
        public mazeRunner(int[,] a)
        {
            // Initialize our maze and mazeSolved with length and width of a
            maze = new int[a.GetLength(0), a.GetLength(1)];
            mazeSolved = new int[a.GetLength(0), a.GetLength(1)];

            // 2 nested loops to initialize a copy of the array
            for (int x = 0; x < a.GetLength(0); x++)
            {
                for(int y = 0; y < a.GetLength(1); y++)
                {
                    maze[x, y] = a[x, y];
                    mazeSolved[x, y] = a[x, y];
                }
            }

            // Set our minimum depth
            solDepth = a.GetLength(0);

            // Find our maze specific starting Y coordinate
            for (int x = 0; x < a.GetLength(1); x++)
            {
                if (a[0, x] == 0)
                {
                    yC = x;
                    mazeSolved[0, yC] = 3;
                    break;
                }
            }

            // Find our maze specific starting X coordinate
            /*
             * THIS CODE ISN'T REALLY NEEDED YET
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                if(maze[x,0] == 0)
                {
                    xC = x;
                    break;
                }
            }
            */
        }

        // This is the recursive method that solves the maze
        public void solve()
        {
            // Default Case for Vertical (TOP->BOTTOM) search
            // xC == 15 && yC == 19
            if(xC == solDepth - 1)
            {
                isSolved = true;
            }
            
            // Recursive Statement
            else
            {
                // Search Down
                if(xC < maze.GetLength(0) - 1 && isSolved == false)
                {
                    if (mazeSolved[++xC, yC] == 0)
                    {
                        mazeSolved[xC, yC] = 2;
                        solve();
                        if(isSolved == true)
                        { mazeSolved[xC, yC] = 3; }
                    }
                    --xC;
                }

                // Search Right
                if (yC < maze.GetLength(1) - 1 && isSolved == false)
                {
                    if (mazeSolved[xC, ++yC] == 0)
                    {
                        mazeSolved[xC, yC] = 2;
                        solve();
                        if (isSolved == true)
                        { mazeSolved[xC, yC] = 3; }
                    }
                    --yC;
                }
                
                // Search Up
                if (xC > 0 && isSolved == false)
                {
                    if (mazeSolved[--xC, yC] == 0)
                    {
                        mazeSolved[xC, yC] = 2;
                        solve();
                        if (isSolved == true)
                        { mazeSolved[xC, yC] = 3; }
                    }
                    ++xC;
                }

                // Search Left
                if (yC > 0 && isSolved == false)
                {
                    if (mazeSolved[xC, --yC] == 0)
                    {
                        mazeSolved[xC, yC] = 2;
                        solve();
                        if (isSolved == true)
                        { mazeSolved[xC, yC] = 3; }
                    }
                    ++yC;
                }

            }
        }

        public void print()
        {
            // Set Length and Width of Maze Array
            int rowLength = maze.GetLength(0);
            int colLength = maze.GetLength(1);

            // Print each row and column out in a pretty way
            Console.Write(Environment.NewLine);
            Console.WriteLine("Before Solving");
            for(int x = 0; x < rowLength; x++)
            {
                for(int y = 0; y < colLength; y++)
                {
                    Console.Write(string.Format("{0}", maze[x, y]) + " ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("After Solving");
            for (int x = 0; x < rowLength; x++)
            {
                for (int y = 0; y < colLength; y++)
                {
                    Console.Write(string.Format("{0}", mazeSolved[x, y]) + " ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
