#include <iostream>
#include <cmath>
#include <string>
#include <stdlib.h>
#include <time.h>

#include "mainHeader.h"

void rockPaperScissors(){

    // Determine whether menu is complete
    bool cont = false;

    // Difficulty level
    int level;

    // Lets program check whether game is won, lost or draw
    int status;

    // User choice
    std::string choice;

    // User choice index
    int _choice;

    // Program output
    std::string output;

    // Program choice
    int _prog_choice;

    // User chooses difficulty
    do{
        std::cout << "Crazy Rock Paper Scissors!" << std::endl;
        std::cout << "CHOOSE YOUR DIFFICULTY!: " << std::endl;

        // User Input
        std::cin >> choice;

        // User difficulty menu
        if(choice == "EASY" || choice == "easy"){
            std::cout << "Really? YOU BIG BABY" << std::endl;
            level = 0;
            break;
        }
        else if(choice == "MEDIUM" || choice == "medium"){
            std::cout << "THINGS ARE HEATING UP!" << std::endl;
            level = 1;
            break;
        }
        else if(choice == "HARD" || choice == "hard"){
            std::cout << "WELCOME TO THE KITCHEN!" << std::endl;
            level = 2;
            break;
        }
        else if(choice == "CRAZY" || choice == "crazy"){
            std::cout << "OUT OF THE KITCHEN... AND INTO THE INFEEEEEEEEEERRRRRNNOOOOOOO" << std::endl;
            level = 3;
            break;
        }
        else{
            std::cout << std::endl << "YOU HAVE TO CHOOSE A REAL OPTION!" << std::endl;
            std::cout << "EASY-MEDIUM-HARD OR....... CRAZY" << std::endl << std::endl;
            std::cin.clear();
            std::cin.ignore(10000, '\n');
        }
    }while(!cont);

    // Game is starting
    std::cout << "CHOOSE YOUR HAND!: " << std::endl;

    // User input
    std::cin >> choice;

    // Rock Paper Scissors game
    do{

        // Program response to each possible outcome
        if(choice == "ROCK" || choice == "rock"){
            if(level == 0){
                double val = (double)rand() /  RAND_MAX;
                std::cout << val;
                if(val < 0.1)                           {output = "PAPER"; _prog_choice = 1;}       // 10% chance to lose
                else if(val < 0.35)                     {output = "ROCK"; _prog_choice = 0;}        // 25% chance to draw
                else                                    {output = "SCISSOR"; _prog_choice = 2;}     // 65% chance to win
                _choice = 0;
                break;
            }
            else if(level == 1){
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.33)                          {output = "PAPER"; _prog_choice = 1;}       // 33% chance to lose
                else if(val < 0.66)                     {output = "ROCK"; _prog_choice = 0;}        // 33% chance to draw
                else                                    {output = "SCISSOR"; _prog_choice = 2;}     // 34% chance to win
                _choice = 0;
                break;
            }
            else if(level == 2){
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.50)                          {output = "PAPER"; _prog_choice = 1;}       // 50% chance to lose
                else if(val < 0.75)                     {output = "ROCK"; _prog_choice = 0;}        // 25% chance to draw
                else                                    {output = "SCISSOR"; _prog_choice = 2;}     // 25% chance to win
                 _choice = 0;
                break;
            }
            else{
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.65)                          {output = "PAPER"; _prog_choice = 1;}       // 65% chance to lose
                else if(val < 0.90)                     {output = "ROCK"; _prog_choice = 0;}        // 25% chance to draw
                else                                    {output = "SCISSOR"; _prog_choice = 2;}     // 10% chance to win
                _choice = 0;
                break;
            }
        }
        else if(choice == "PAPER" || choice == "paper"){
            if(level == 0){
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.1)                           {output = "SCISSOR"; _prog_choice = 2;}       // 10% chance to lose
                else if(val < 0.35)                      {output = "PAPER"; _prog_choice = 1;}         // 25% chance to draw
                else                                    {output = "ROCK"; _prog_choice = 0;}          // 65% chance to win
                _choice = 1;
                break;
            }
            else if(level == 1){
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.33)                          {output = "SCISSOR"; _prog_choice = 2;}       // 33% chance to lose
                else if(val < 0.66)                      {output = "PAPER"; _prog_choice = 1;}         // 33% chance to draw
                else                                    {output = "ROCK"; _prog_choice = 0;}          // 34% chance to win
                _choice = 1;
                break;
            }
            else if(level == 2){
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.50)                      {output = "SCISSOR"; _prog_choice = 2;}          // 50% chance to lose
                else if(val < 0.75)                  {output = "PAPER"; _prog_choice = 1;}            // 25% chance to draw
                else                                {output = "ROCK"; _prog_choice = 0;}             // 25% chance to win
                _choice = 1;
                break;
            }
            else{
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.65)                      {output = "SCISSOR"; _prog_choice = 2;}           // 65% chance to lose
                else if(val < 0.90)                  {output = "PAPER"; _prog_choice = 1;}             // 25% chance to draw
                else                                {output = "ROCK"; _prog_choice = 0;}              // 10% chance to win
                _choice = 1;
                break;
            }
        }
        else if(choice == "SCISSOR" || choice == "scissor"){
            if(level == 0){
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.1)                       {output = "ROCK"; _prog_choice = 0;}          // 10% chance to lose
                else if(val < 0.35)                 {output = "SCISSOR"; _prog_choice = 2;}       // 25% chance to draw
                else                                {output = "PAPER"; _prog_choice = 1;}         // 65% chance to win
                _choice = 2;
                break;
            }
            else if(level == 1){
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.33)                      {output = "ROCK"; _prog_choice = 0;}           // 33% chance to lose
                else if(val < 0.66)                 {output = "SCISSOR"; _prog_choice = 2;}        // 33% chance to draw
                else                                {output = "PAPER"; _prog_choice = 1;}          // 34% chance to win
                _choice = 2;
                break;
            }
            else if(level == 2){
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.50)                      {output = "ROCK"; _prog_choice = 0;}             // 50% chance to lose
                else if(val < 0.75)                 {output = "SCISSOR"; _prog_choice = 2;}          // 25% chance to draw
                else                                {output = "PAPER"; _prog_choice = 1;}            // 25% chance to win
                _choice = 2;
                break;
            }
            else{
                double val = (double)rand() /  RAND_MAX;
                if(val < 0.65)                      {output = "ROCK"; _prog_choice = 0;}             // 65% chance to lose
                else if(val < 0.90)                 {output = "SCISSOR"; _prog_choice = 2;}          // 25% chance to draw
                else                                {output = "PAPER"; _prog_choice = 1;}            // 10% chance to win
                _choice = 2;
                break;
            }
        }
    }while(!cont);

    // Game Outcomes
    if(_choice == 0 && _prog_choice == 0){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "ITS A DRAW" << std::endl << std::endl;
    }
    else if(_choice == 0 && _prog_choice == 1){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "YOU LOSE!" << std::endl << std::endl;
    }
    else if(_choice == 0 && _prog_choice == 2){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "YOU WIN!" << std::endl << std::endl;
    }
    else if(_choice == 1 && _prog_choice == 1){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "ITS A DRAW!" << std::endl << std::endl;
    }
    else if(_choice == 1 && _prog_choice == 2){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "YOU LOSE!" << std::endl << std::endl;
    }
    else if(_choice == 1 && _prog_choice == 0){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "YOU WIN!" << std::endl << std::endl;
    }
    else if(_choice == 2 && _prog_choice == 2){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "ITS A DRAW!" << std::endl << std::endl;
    }
    else if(_choice == 2 && _prog_choice == 0){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "YOU LOSE!" << std::endl << std::endl;
    }
    else if(_choice == 2 && _prog_choice == 1){
        std::cout << "YOU CHOSE: " << choice << std::endl << "COMPUTER CHOSE: " << output << std::endl;
        std::cout << "YOU WIN!" << std::endl << std::endl;
    }
}
