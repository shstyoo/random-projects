#include <iostream>
#include <string>

#include "mainHeader.h"

_displayMenu::_displayMenu()
{
    numOptions = 0;
}

//Encapsulate numOptions(Prevent clients from accessing it directly)
int _displayMenu::setNumOptions(){
    int choice;
    cout << "How many options does this menu contain? [Max 10]" << endl;
    cin >> choice;
    if(choice > 0 && choice <= 10){
        cout << "Your menu will contain: " << choice << " options" << endl;
        numOptions = choice;
    }
    else{
        cin.clear();
        cin.ignore(1000, '\n');
        cout << "Please enter an integer" << endl;
    }
}

int _displayMenu::getNumOptions(){

}

string _displayMenu::getOptionArray(){

}
