#include <iostream>
#include <stdlib.h>
#include <time.h>

#include "mainHeader.h"

int main(){

    // Set srand() for random seed from time
    srand(time(NULL));

    // Determines whether menu is complete
    bool cont = false;

    // Menu loop
    do{
        // User choice declaration
        int choice;

        // Main Menu
        std::cout << "This shit be crazy" << std::endl;
        std::cout << "1. Crazy tic tac toe" << std::endl;
        std::cout << "2. Crazy rock paper scissors" << std::endl;
        std::cout << "Crazy selection!: ";

        // User selection
        std::cin >> choice;

        // Conditional statement for user choice
        if(choice == 1){
            std::cout << "Starting crazy tic tac toe..." << std::endl;
            ticTacToe();
        }
        else if(choice == 2){
            std::cout << "Starting crazy rock paper scissors..." << std::endl;
            rockPaperScissors();
        }
        else{
            std::cout << "Whoa, even this program isn't as crazy as you" << std::endl;
            std::cout << "Why don't you pick a real option" << std::endl;

            // Clears cin if incorrect answer has been inputted
            std::cin.clear();
            std::cin.ignore(1000, '\n');
        }
    }while(!cont);
}
