// Created by Steve Yoo
// 9/10/2014
// Menu creation for the entire program

#include <iostream>
#include <string>
#include <stack>
#include <iomanip>
#include <cstdlib>

#include "mainHeader.h"

using namespace std;

/**
***             What Needs to be finished:
*** 1. if/else statement for user creation and user fetching
*** 2. automation to download .csv from Yahoo/Google Finance (DONE NOW I JUST NEED TO LINK PYTHON SCRIPT TO THIS PROGRAM)
*** 3. add option to let users choose either YHOO or GOOG
*** 4. add option for sharpe ratio/ sortino and stuff
**/

/// Global Variables
// Keeps track of last visited index (throughout entire program)
stack<int> lastVisited;

// cout << endl << "DEBUG STATMENT -----> " << << " <----- DEBUG STATMENT" << endl << endl;
// Menu Display Function
int displayMenu(int a){

    /// MENU ID         MENU INDEXES        MENU INDEX MAP
    int mainIndex       = 0;                //[0]
    int stockIndex      = 1;                //[1][0]
    int portIndex       = 2;                //[2][0]
    int aboutIndex      = 3;                //[3][0]
    int quitIndex       = 4;                //[4][0]
    int sharpeIndex     = 5;                //[1][1][0]
    int marketIndex     = 6;                //[1][2][0]
    int histIndex       = 7;                //[1][3][0]
    int newUsrIndex     = 8;                //[2][1][0]
    int usrIndex        = 9;                //[2][2][0]
    int forgotIndex     = 10;               //[2][3][0]
    int abtRatIndex     = 11;               //[3][1][0]
    int abtMktIndex     = 12;               //[3][2][0]
    int abtProgIndex    = 13;               //[3][3][0]

    // Keeps menu running in loop until user inputs a choice (which changes cont to true)
    bool cont = false;

    // Stores user choice for each menu loop (string)
    string choice;
    // Stores user choice for each menu loop (int)
    int _choice;

    // Stores int for counter (various purposes)
    int counter = 0;

    /** HOW TO NAVIGATE THE MENUS THROUGH INDEXES
    *** The first number in the brackets signifies a key press
    *** [0] = No key press, [1] = 1 has been pressed, [2] = 2 has been pressed... etc...
    *** The order in which the brackets appear matter. For example, to get to the index:
    *** [1][3][0]
    *** You need to press 1, then 3, then nothing to get to that menu screen
    *** If you need to get to the menu screen that requires a user to press 1, 3, 4, 2
    *** The resulting index is: [1][3][4][2][0]
    **/

    // Main Menu [0]
    if(a == mainIndex){
        do{

            //Elements of Main Menu [0]
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(14) << "*" << "  MAIN MENU  " << setfill('*') << setw(13) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** 1. Stock Analysis" << endl;
            cout << "*** 2. Portfolio Management" << endl;
            cout << "*** 3. About" << endl;
            cout << "*** 4. Quit" << endl;
            cout << "*** 5. Back" << endl;
            cout << "*** 6. Clear Screen" << endl;
            cout << "->: ";

            //User choice input
            cin >> _choice;

            //Case/Switch for user input
            switch(_choice){
            case 1:
                lastVisited.push(mainIndex); //This pushes the last visited page onto the stack, allowing users to go back (and retain history)
                displayMenu(1);
                break;
            case 2:
                lastVisited.push(mainIndex);
                displayMenu(2);
                break;
            case 3:
                lastVisited.push(mainIndex);
                displayMenu(3);
            case 4:
                lastVisited.push(mainIndex);
                displayMenu(4);
                break;
            case 5:
                if(lastVisited.empty() == true){
                    cout << "There is nothing to go back to!" << endl << endl;
                    break;
                }
                else{
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                }
            case 6:{
                clearScreen();
                displayMenu(0);
                break;
            }
            default:
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
        }while(!cont);
    }

    // Menu [1][0]
    else if(a == stockIndex){
        do{
            //Elements of Stock Analysis Menu [1][0]
            cout <<                                                                                               endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(11) << "*" << "  Stock Analysis  " << setfill('*') << setw(11) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** 1. Sharpe/Sortino Ratio" << endl;
            cout << "*** 2. Market Statistics(Real Time)" << endl;
            cout << "*** 3. Historical Analysis" << endl;
            cout << "*** 4. Back" << endl;
            cout << "*** 5. Return to Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //Case/Switch for user input
            switch(_choice){
            case 1:{
                lastVisited.push(stockIndex);
                displayMenu(sharpeIndex);
                break;
            }
            case 2:{
                lastVisited.push(stockIndex);
                displayMenu(marketIndex);
                break;
            }
            case 3:{
                lastVisited.push(stockIndex);
                displayMenu(histIndex);
                break;
            }
            case 4:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
                cout << "There is nothing to go back to!" << endl;
                break;
            }
            case 5:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(stockIndex);
                displayMenu(0);
                break;
            case 6:{
                displayMenu(4);
                break;
            }
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [2][0]
    else if(a == portIndex){
        do{
            //Elements of Portfolio Menu [2][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(8) << "*" << "  Portfolio Management  " << setfill('*') << setw(8) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** 1. New User" << endl;
            cout << "*** 2. Existing User" << endl;
            cout << "*** 3. Forgot Username/Password" << endl;
            cout << "*** 4. Back" << endl;
            cout << "*** 5. Return to Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //Case/Switch for user input
            switch(_choice){
            case 1:{
                lastVisited.push(portIndex);
                displayMenu(newUsrIndex);
                break;
            }
            case 2:{
                lastVisited.push(portIndex);
                displayMenu(usrIndex);
                break;
            }
            case 3:{
                lastVisited.push(portIndex);
                displayMenu(forgotIndex);
                break;
            }
            case 4:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 5:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(portIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [3][0]
    else if(a == aboutIndex){
        do{
            //Elements of About Menu [3][0]
            cout <<                                                                                      endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(16) << "*" << "  About  " << setfill('*') << setw(15) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** 1. How are the ratios calculated?" << endl;
            cout << "*** 2. How are the market values retrieved?" << endl;
            cout << "*** 3. Program Information" << endl;
            cout << "*** 4. Back" << endl;
            cout << "*** 5. Return to Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //Case/Switch for user input
            switch(_choice){
            case 1:{
                lastVisited.push(aboutIndex);
                displayMenu(abtRatIndex);
                break;
            }
            case 2:{
                lastVisited.push(aboutIndex);
                displayMenu(abtMktIndex);
                break;
            }
            case 3:{
                lastVisited.push(aboutIndex);
                displayMenu(abtProgIndex);
                break;
            }
            case 4:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 5:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(aboutIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [4][0]
    else if(a == quitIndex){
        int counter = 0;
        do{

            //Quit Screen
            cout << endl << "**************************";
            cout << endl << "******** Quitting ********" << endl;
            cout <<         "**************************" << endl;
            cout << "Are you sure you would like to quit?" << endl;
            cout << "->[y/n]: ";
            cin >> choice;

            //If choice is Y or y, quit the program
            if(choice == "y" || choice == "Y" || choice == "1"){
                cout << "Now Quitting...";
                exit(0);
            }

            //If choice is N or n, return to main menu
            else if(choice == "n" || choice == "N" || choice == "2"){
                cout << endl << "Returning to Main Menu" << endl << endl;
                displayMenu(0);
            }

            //If user inputs incorrectly, loop until counter runs, or until correct response is input
            else{
                cout << endl << "Incorrect Response!" << endl;

                //If the counter is at 2 - 4, error message will appear
                if(counter >= 2 && counter < 5){
                    cout << "You have " << 5 - counter << " tries before returning to the Main Menu" << endl;
                    counter ++;
                    cont = false;
                }

                //If the counter is greater than, or equal to 5, program will return to main menu
                else if(counter >= 5){
                    cout << endl <<"Returning to Main Menu" << endl << endl;
                    displayMenu(0);
                }

                //If the counter is 0 - 1, the quit menu will appear again
                else{
                    counter++;
                    cont = false;
                }
            }
        }while(!cont);
    }

    // Menu [1][1][0]
    else if(a == sharpeIndex){
        do{
            //Elements of Sharpe Ratio Menu [1][1][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(8) << "*" << "  Sharpe/Sortino Ratio  " << setfill('*') << setw(8) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** 1. Enter Stock Symbol" << endl;
            cout << "*** 2. Back" << endl;
            cout << "*** 3. Return to Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //Case/Switch for user input
            switch(_choice){
            case 1:{
                system("\"pythonScript\\build\\exe.win32-2.7\\googleFinancePhantomJS.exe\"");
                lastVisited.push(sharpeIndex);
                break;
            }
            case 2:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 3:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(sharpeIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [1][2][0]
    else if(a == marketIndex){
        do{
            //Elements of Market Stats Menu [1][2][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(8) << "*" << "  RealTime Market Stats  " << setfill('*') << setw(7) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** This is an ticker feed of: " << "ENTER MARKET HERE (NYSE, $DJI, NASDAQ..." << endl; //Don't forget to finish
            cout << "*** Type 2 to go back at any time, or 3 to return to the Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //Case/Switch for user input
            switch(_choice){
            case 1:{
                //Print out YHOO or GOOG Market Data
                lastVisited.push(marketIndex);
                break;
            }
            case 2:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 3:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(marketIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [1][3][0]
    else if(a == histIndex){
        do{
            //Elements of Historical Stats Menu [1][3][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(7) << "*" << "  Historical Market Stats  " << setfill('*') << setw(6) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** Insert up to 10 Stock Symbols separated by commas (AAPL,GOOG,XOM...)" << endl;
            cout << "*** Followed by 2 dates separated by commas in the format: mmddyyy,mmddyyy" << endl;
            cout << "*** Be sure that there are no spaces in your entries for both symbols and dates" << endl;
            cout << "*** Type 2 to go back at any time, or 3 to return to the Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //STEVE DON'T FUCKING USE CASE/SWITCH FOR histIndex OR marketIndex!!! MAKE IF/ELSE TO ACCOMODATE NEW INPUT PARAM
            //Case/Switch for user input
            switch(_choice){
            case 1:{
                //Take in 2 cin statements, one for stock symbols, the other for the date range
                lastVisited.push(histIndex);
                break;
            }
            case 2:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 3:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(histIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [2][1][0]
    else if(a == newUsrIndex){
        do{
            // Elements of New Account Menu [2][1][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; // Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(11) << "*" << "  Create Account  " << setfill('*') << setw(11) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            // Menu Items
            cout << "*** When prompted please enter your desired Username, Password, and select a" << endl;
            cout << "*** secret question and answer to store your User data." << endl;
            cout << endl;
            cout << "*** Type 2 to go back at any time, or 3 to return to the Main Menu" << endl;
            cout << "*** Otherwise, type 1 to continue" << endl;
            cout << "->: ";

            // User Input
            cin >> choice;

            // If user decides to continue, we call the usrAccCtrl function
            if(choice == "1"){
                lastVisited.push(newUsrIndex);
                usrAccCtrl(0);
            }
            else if(choice == "2"){
                while(!lastVisited.empty()){
                    // This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    // This removes the just accessed last visited site
                    lastVisited.pop();
                    // This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            else if(choice == "3"){
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(newUsrIndex);
                displayMenu(mainIndex);
            }
            else if(choice == "6"){
                displayMenu(quitIndex);
                break;
            }
            else{
                cout << "Incorrect Choice!!" << endl;
                cout << "PLease Try Again" << endl;

                // Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                // Google: How can I avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
            }
        }while(!cont);
    }

    // Menu [2][2][0]
    else if(a == usrIndex){
        do{
            //Elements of Login Menu [2][2][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(16) << "*" << "  Login  " << setfill('*') << setw(15) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** Please enter your Username and Password when prompted" << endl;
            cout << "*** If you have forgotten your Username or Password type 4" << endl;
            cout << "*** Otherwise, Type 2 to go back at any time, or 3 to return to the Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //STEVE DON'T FUCKING USE CASE/SWITCH FOR newUsrIndex OR usrIndex!!! MAKE IF/ELSE TO ACCOMODATE NEW INPUT PARAM
            //Also read the MENU ITEMS text box to make sure what if/else conditionals to use brah
            //ALSO!!!! Make sure users are given either admin privileges (allowed to access debug mode, etc...) or are just
            //Power Users (only navigation is through menu, and no access to special options).
            //Case/Switch for user input
            switch(_choice){
            case 1:{
                //Create if/else, as well as !!!!!FILE I/O!!!!!! to access user info
                lastVisited.push(usrIndex);
                break;
            }
            case 2:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 3:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(usrIndex);
                displayMenu(0);
                break;
            }
            case 4:{
                displayMenu(forgotIndex);
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [2][3][0]
    else if(a == forgotIndex){
        do{
            //Elements of Forgot Info Menu [1][3][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(11) << "*" << "  Forgot Account  " << setfill('*') << setw(11) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** 1. Forgot Username" << endl;
            cout << "*** 2. Forgot Password" << endl;
            cout << "*** Type 3 to go back at any time, or 4 to return to the Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //JUST CREATE AN IF ELSE STATEMENT THAT READS IN 1 OR 2 and finds EXISTING user info and asks for
            //Questions like birthday/Secret Question, etc....
            //Case/Switch for user input
            switch(_choice){
            case 1:{
                //Create if/else, as well as !!!!!FILE I/O!!!!!! to access EXISTING user info
                lastVisited.push(forgotIndex);
                break;
            }
            case 2:{
                //CREATE IF ELSE STATEMENTS BRA
                lastVisited.push(forgotIndex);
                break;
            }
            case 3:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 4:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(forgotIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [3][1][0]
    else if(a == abtRatIndex){
        do{
            //Elements of About: Rating Menu [3][1][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(8) << "*" << "  About: Sharpe/Sortino  " << setfill('*') << setw(7) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** Sharpe Ratio is found by this equation: k * (avg daily_rets) / (stdev)..." << endl;
            cout << "*** k is based on trading days [k = sqrt(250)] or months [k = sqrt(12)]..." << endl;
            cout << "*** in any given trading year. " << endl << endl;
            cout << "*** ADD IN INFOMRATION ABOUT SORTINO RATIO" << endl << endl;
            cout << "*** avg daily_rets is found by pooling data (over a period of time)..." << endl;
            cout << "*** and averaging the daily returns a stock makes either in days or months" << endl << endl;
            cout << "*** stdev is calculated using cmath..." << endl;
            cout << "*** (for more detailed information visit C++ API for <cmath>" << endl << endl;
            cout << "*** Type 2 to go back at any time, or 3 to return to the Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            switch(_choice){
            case 1:{
                lastVisited.push(abtRatIndex);
                break;
            }
            case 2:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 3:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(abtRatIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [3][2][0]
    else if(a == abtMktIndex){
        do{
            //Elements of About: Market Data Menu [3][2][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(14) << "*" << "  About: Market Data  " << setfill('*') << setw(14) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** Market Data is downloaded from Google, or Yahoo Finance" << endl << endl;
            cout << "*** NYSE, $DJI, NASDAQ, and others may not reflect true..." << endl;
            cout << "*** \"Real Time\" statistics due to program limitations" << endl << endl;
            cout << "*** Type 2 to go back at any time, or 3 to return to the Main Menu" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //Steve Add in option somewhere in this program to allow users to choose either Yahoo or Google finance
            //Case/Switch for user input
            switch(_choice){
            case 1:{
                lastVisited.push(abtMktIndex);
                break;
            }
            case 2:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 3:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(abtMktIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

    // Menu [3][3][0]
    else if(a == abtProgIndex){
        do{
            //Elements of About: Program Menu [3][3][0]
            cout <<                                                                                                   endl;
            cout << setfill('*') << setw(40) << "*" << endl; //Menu Formatting (each menu has 40 spaces to use)
            cout << setfill('*') << setw(14) << "*" << "  About This Program  " << setfill('*') << setw(14) << "*" << endl;
            cout << setfill('*') << setw(40) << "*" << endl;
            //Menu Items
            cout << "*** Date Created: 9/15/2014" << endl;
            cout << "*** Date Last Modified: 10/15/2014" << endl;
            cout << "*** Program created by: Steve Yoo" << endl;
            cout << "*** Created for: Yasha, because he is a bitch" << endl;
            cout << "*** Type 2 to back, 3 to return to Main Menu, or 4 to enter debug mode" << endl;
            cout << "->: ";

            //User Input
            cin >> _choice;

            //Create IF/ELSE statements for 2, 3, and 4 options. Also create interface for DEBUGGER mode.
            //EX. Debugger just contains info on current lastVisited<stack> information, user account accesses
            //User account permission changes, etc...
            //Debugger mode should also require special privileges to run, and unless specified in user info, is off limits

            //Case/Switch for user input
            switch(_choice){
            case 1:{
                //Create if/else, as well as !!!!!FILE I/O!!!!!! to create and store user info
                lastVisited.push(abtProgIndex);
                break;
            }
            case 2:{
                while(!lastVisited.empty()){
                    //This views the last visited site using .top()
                    int temp1 = lastVisited.top();
                    //This removes the just accessed last visited site
                    lastVisited.pop();
                    //This jumps back to the last visited site we pulled from stack
                    cout << endl;
                    displayMenu(temp1);
                    break;
                }
            }
            case 3:{
                cout << endl << "Returning to Main Menu" << endl << endl;
                lastVisited.push(abtProgIndex);
                displayMenu(0);
                break;
            }
            case 6:{
                displayMenu(4);
                break;
            }
            default:{
                cout << "Incorrect Choice!!" << endl;
                cout << "Please Try Again" << endl;

                //Cin goes into a failed state (infinite loop) so this just asks cin to discard 1000 characters when someone puts in an incorrect statement
                //Google: How can i avoid char input for an int variable (stack overflow) for help
                cin.clear();
                cin.ignore(1000, '\n');
                cont = false;
            }
            }
        }while(!cont);
    }

}


