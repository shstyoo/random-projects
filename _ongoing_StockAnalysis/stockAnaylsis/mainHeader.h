// Created by Steve Yoo
// 9/11/2014
// Header file to link all our files together

#ifndef MAINHEADER_H_INCLUDED
#define MAINHEADER_H_INCLUDED
#include <string>
#include <stack>

#include "userClass.h"

using namespace std;

/// Program-Wide Variables
// Keeps track of last visited index throughout the entire program
extern stack<int> lastVisited;

// This is the name of the database used to store all our information
extern string userDatabase;

// Call on a menu screen (using the proper index provided in "displayMenu.cpp"!)
int displayMenu(int a); // a = index!!

// Clear the console screen
void clearScreen();

// Call on a menu screen for user account control (using index provided in "userAccCtrl.cpp"!)
void usrAccCtrl(int index);

// Check whether or not a file opened successfully
/** filename specifies the name of the file
*** type specifies what kind of operation you are performing on the file
*** FILE OPERATION          NUBMER (TO PUT IN TYPE)
*** Writing to a File       0
*** Reading from a File     1
*** Reading and Writing     2
***/
int checkFile(string filename, int type);

// Used to read in the CSV files that are downloaded from Google
void csvReader();


#endif // MAINHEADER_H_INCLUDED
