// Created by Steve Yoo
// 9/03/2014

#include <iostream>
#include <string>
#include "mainHeader.h"

using namespace std;

/** What Needs to be finished/implemented:
*** 1. User creation, deletion, and management
*** 2. Portfolio management (adding stocks, deleting stocks)
*** 3. Print functions for various sharpe/sortino and whatnot ratios
*** 4. Admin Debug Mode
*** 5. Different power levels (ADMIN, POWER USER, USER, GUEST) for different program actions
*** 6. Creating a CLASS for displayMenu (current name: _displayMenu)
*** 7. IMPORTANT: CREATE PYTHON/C# PROGRAM THAT THIS PROGRAM WILL UTILIZE TO GRAB INFO FROM WEBSITES (SELENIUM)!!!
**/

/// Program Options
// Specifies the name of the user database
string userDatabase = "userDatabase.txt";

/// Menu Display Function
int displayMenu(int a);

int main()
{
    displayMenu(0);// USES FUNCTIONS
    // Work on OOP and maybe finish using classes for your menus instead of functions
    // _displayMenu menu = new _displayMenu; // USES CLASSES
}

