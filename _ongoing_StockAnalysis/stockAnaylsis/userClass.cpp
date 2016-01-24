// Created by Steve Yoo
// 9/16/2014
// Class: User

#include "userClass.h"

// NOTE: The userDatabase.txt" attaches a '+' before each index
userClass::userClass()
{
    // Iterates through the "userDatabase.txt" and finds the index of the user to write too
    //ifstream input_stream;

    //input_stream.open(filename, ios::in)

    // When a class user is created, all fields are "NULL" and user level is guest(3)
    username            = "NULL";
    password            = "NULL";
    recoveryQuestion    = "NULL";
    recoveryAnswer      = "NULL";
    firstName           = "NULL";
    lastName            = "NULL";
    birthday            = "NULL";
    ssn                 = "NULL";
    userLvl             = 3;
    //index

    // This is where we write to "userDatabase.txt" the empty user
    // Before appending the null fields to "userDatabase.txt" we want to check if there are any other empty slots



}

// This public method gets or sets a username.
void userClass::getUsername(){

}
void userClass::setUsername(){

}
