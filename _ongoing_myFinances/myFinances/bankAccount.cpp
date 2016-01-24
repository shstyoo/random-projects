#include "mainHeader.h"
#include <fstream>

bankAccount::bankAccount(string name){
    ofstream myFile;
    if(!myFile){
        acctName = name;
        balance = 0.00;

        // Create a new file with balance
        ofstream myFile;
        myFile.open(name+".txt", ios::trunc);
        myFile << acctName + "," + balance;
        myFile.close();
        std::cout << "New file write to: " + name + " is complete" << std::endl;

        // Create a new file with transaction history
        ofstream myFile2;
        myFile2.open(name + "History.txt", ios::app);
        std::cout << "New file write to: " + name + "History.txt is complete" << std::endl;
        myFile2.close();
    }
    else{
        checkFile(name+".txt", 2);
        std::cout << "Opening: " + name + " is complete" << std::endl;
    }
}

bankAccount::~bankAccount(){
    //dtor
}

void bankAccount::addBalance(&balance){
    double add;
    std::cout << "How much would you like to add?" << std::endl << "->: " << std::endl << std::endl;
    cin >> add;
    std::cout << "Your old balance is: " << balance << "." << std::endl;
    balance += add;
    std::cout << "Your new balance is: " << balance << "." << std::endl << std::endl;
    std::cout << "Would you like to add a description for this transaction?" << std::endl << "->: " << std::endl;
}

void bankAccount::rmvBalance(&balance){
    double rmv;
    std::cout << "How much would you like to remove?" << std::endl << "->: " << std::endl << std::endl;
    cin >> rmv;
    std::cout << "Your old balance is: " << balance << "." << std::endl;
    balance -= rmv;
    std::cout << "Your new balance is: " << balance << "." << std::endl;
}

double bankAccount::getBalance(){

}

void bankAccount::getHistory(){

}

void bankAccount::printBalToFile(){

}
