// Created by Steve Yoo
// clearScreen code taken from cplusplus.com
// http://www.cplusplus.com/articles/4z18T05o/
// 9/05/2014

#include <windows.h>

#include "mainHeader.h"
// This is the Windows specific way to clear the console screen (the most widely accepted
// way to do it is to just print a bazillion endl, or '\n' statements


void clearScreen(){
    HANDLE                      hStdOut;
    CONSOLE_SCREEN_BUFFER_INFO  csbi;
    DWORD                       count;
    DWORD                       cellCount;
    COORD                       homeCoords = { 0, 0 };

    hStdOut = GetStdHandle( STD_OUTPUT_HANDLE );
    if (hStdOut == INVALID_HANDLE_VALUE) return;

    /* Get the number of cells in the current buffer */
    if (!GetConsoleScreenBufferInfo( hStdOut, &csbi )) return;
    cellCount = csbi.dwSize.X *csbi.dwSize.Y;

    /* Fill the entire buffer with spaces */
    if (!FillConsoleOutputCharacter(
        hStdOut,
        (TCHAR) ' ',
        cellCount,
        homeCoords,
        &count
        )) return;

    /* Fill the entire buffer with the current colors and attributes */
    if (!FillConsoleOutputAttribute(
        hStdOut,
        csbi.wAttributes,
        cellCount,
        homeCoords,
        &count
        )) return;

    /* Move cursor home */
    SetConsoleCursorPosition( hStdOut, homeCoords );
}
