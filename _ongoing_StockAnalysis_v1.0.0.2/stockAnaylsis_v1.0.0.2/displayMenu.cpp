#include <iostream>
#include <string>

#include "mainHeader.h"

// Ctor for our menu. Main body of text goes here
displayMenu::displayMenu(){

}

displayMenu::~displayMenu(){
    // Bleh
}

void displayMenu::getMenu(int a){

    // Main Menu
    if(a == 0){
        cout << "*********" << endl;
        cout << "MAIN MENU" << endl;
        cout << "*********" << endl << endl;
        cout << "1. Login/Register" << endl;
        cout << "2. About" << endl;
        cout << "3. Quit" << endl;
        cout << "->: ";
    }

    // Login/Registration
    else if(a == 1){
        cout << "******************" << endl;
        cout << "Login/Registration" << endl;
        cout << "******************" << endl << endl;
        cout << "1. Login" << endl;
        cout << "2. Register" << endl;
        cout << "3. Back" << endl;
        cout << "4. Quit" << endl;
        cout << "->: ";
    }

    // About
    else if(a == 2){
        cout << "*****" << endl;
        cout << "About" << endl;
        cout << "*****" << endl << endl;
        cout << "************" << endl;
        cout << "Sharpe Ratio" << endl;
        cout << "************" << endl;
        cout << "Sharpe Ratio is found by this equation: k * (avg daily_rets) / (stdev)..." << endl;
        cout << "k is based on trading days [k = sqrt(250)] or months [k = sqrt(12)]..." << endl;
        cout << "in any given trading year. " << endl << endl;
        cout << "******************" << endl;
        cout << "About this Program" << endl;
        cout << "******************" << endl << endl;
        cout << "Created by: Seunghyun Yoo" << endl;
        cout << "Last modified: 10/3/2014" << endl;
        cout << "Designed to help Yasha be less of a bitch" << endl << endl;
        cout << "Type anything to return to main menu" << endl;
        cout << "->: ";
    }

    // Quit screen
    else if(a == 3){
        cout << "Are you sure you want to quit?" << endl;
        cout << "Enter choice [y/n]" << endl;
        cout << "->: ";
    }

    // Login
    else if(a == 4){
        cout << "*****" << endl;
        cout << "Login" << endl;
        cout << "*****" << endl << endl;
    }

    // Registration
    else if(a == 5){
        cout << "************" << endl;
        cout << "Registration" << endl;
        cout << "************" << endl << endl;
    }

    // User Menu
    else if(a == 6){
        cout << "*********" << endl;
        cout << "User Menu" << endl;
        cout << "*********" << endl << endl;
        cout << "1. View Portfolio" << endl;
        cout << "2. Delete stock[s] from portfolio" << endl;
        cout << "2. Add stock[s] to portfolio" << endl;
        cout << "3. View Stock (from Google Finance)" << endl;
        cout << "4. Logout" << endl;
        cout << "5. Quit" << endl;
    }

    // Portfolio View
    else if(a == 7){
        cout << "There is nothing here" << endl;
    }

    // Add Stock
    else if(a == 8){
        cout << "There is nothing here" << endl;
    }

    // Remove stock
    else if(a == 9){
        cout << "There is nothing here" << endl;
    }

    // View Stock
    else if(a == 10){
        cout << "There is nothing here" << endl;
    }

    // Incorrect Choice
    else{
        cout << "Incorrect choice!" << endl;
        cin.clear();
        cin.ignore(1000, '\n');
    }
}

/*
** This function will allow us to fetch the result of whatever the user inputs
*/
void getChoice(int a){
    if(a == 0){
        int choice;
        cin >> choice;
        if(choice == 1){
            getMenu(1);

        }
        else if(choice == 2){

        }
        else if(choice == 3){

        }
    }
    else if(a == 1){

    }
    else if(a == 2){

    }
    else if(a == 3){

    }
    else if(a == 4){

    }
    else if(a == 5){

    }
    else if(a == 6){

    }
    else if(a == 7){

    }
    else if(a == 8){

    }
    else if(a == 9){

    }
    else if(a == 10){

    }
}

/*
** This function will return whatever int index a specific indexName occupies
** You can use the the following syntax to choose which index is chosen:
** getIndex(setIndex())
*/
int displayMenu::getIndex(string a){
    if(a == "Monkey"){
        return 2;
    }
}
string displayMenu::setIndex(){
    indexName = "Monkey";
    return indexName;
}

/*
** This function will return whatever string name a specific index occupies
** You can use the following syntax to choose which index is chosen:
** getIndexName(setIndexName())
*/
string displayMenu::getIndexName(int a){
    if(a == 4){
        return "Monkey";
    }
}
int displayMenu::setIndexName(){
    index = 4;
    return index;
}

void displayMenu::historyFunc(){
    cout << "historyFunc" << endl;
}

void displayMenu::quit(){
    cout << "quit" << endl;
}
