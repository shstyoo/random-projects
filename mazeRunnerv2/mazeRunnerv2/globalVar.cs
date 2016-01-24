// Created by Seunghyun Yoo
// At:      10.16.2014
// Latest:  10.22.2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeRunnerv2
{
    class globalVar
    {
        // INDEXES
        public static int mainMenu      = 0;
        public static int quitScreen    = 1;
        public static int mazeDia       = 2;
        public static int mazeDia2      = 3;

        // INT CHOICES
        public static int zer           = 0;
        public static int one           = 1;
        public static int two           = 2;
        public static int thr           = 3;
        public static int fou           = 4;
        public static int nin           = 9;

        // 2D Array (Default)
        public static int[,] defMaze = new int[,]  {{0,0,0,0,0,0,1,0,0,0,0,0,1,0,1,1,1,0,1,1},
                                                    {0,1,1,1,1,0,1,0,1,0,1,0,1,0,1,0,0,0,1,1},
                                                    {0,1,0,0,0,0,0,0,1,0,1,0,1,0,0,0,1,0,0,0},
                                                    {0,1,1,1,1,0,1,0,1,1,1,0,1,1,1,0,1,1,1,1},
                                                    {0,1,0,1,0,0,1,0,0,0,1,0,1,1,1,0,1,0,0,0},
                                                    {0,0,0,1,1,1,1,1,1,1,1,0,0,0,1,0,1,0,1,0},
                                                    {0,1,0,1,0,1,0,0,0,0,0,0,1,1,1,0,1,0,1,1},
                                                    {0,1,0,1,0,1,1,1,1,1,1,0,1,0,0,0,0,0,0,0},
                                                    {0,1,0,0,0,0,0,0,0,0,1,1,1,0,1,1,1,1,1,0},
                                                    {1,1,0,1,1,0,1,1,1,1,1,0,1,0,1,0,1,0,1,0},
                                                    {0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
                                                    {1,1,0,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,0,1},
                                                    {0,0,0,0,1,1,0,0,0,0,0,0,1,0,0,0,0,0,0,1},
                                                    {0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,0,1},
                                                    {0,1,1,0,1,0,0,0,0,0,0,0,0,0,0,1,0,1,1,1},
                                                    {0,0,1,1,1,1,1,1,0,1,1,1,1,0,1,1,0,0,0,0},};

        // 2D Array (Test)
        public static int[,] testMaze = new int[,] {{1,1,1,1,0,1,1,1,1,1},
                                                    {1,0,1,1,0,1,1,1,0,1},
                                                    {1,0,0,0,0,0,0,0,0,1},
                                                    {1,1,1,0,1,1,0,1,0,1},
                                                    {1,1,1,0,1,1,0,1,1,1},
                                                    {1,1,1,0,1,1,0,0,0,1},
                                                    {1,1,1,0,0,1,1,0,1,1},
                                                    {1,0,0,0,1,1,1,0,0,1},
                                                    {1,0,1,1,1,1,1,1,1,1},};

        public static int[,] testMaze2 = new int[,] {{1,1,0,1},
                                                     {1,0,0,0},
                                                     {1,0,1,1},
                                                     {1,0,0,1},
                                                     {1,1,0,1},};

    }
}
