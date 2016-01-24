// Created by Steve Yoo
// 9/09/2014

#ifndef USERCLASS_H
#define USERCLASS_H
#include <string>

#include "mainHeader.h"

class userClass{
private:
    std::string  username, password, recoveryQuestion,
            recoveryAnswer, firstName, lastName,
            birthday, ssn;
    int     userLvl, index;

public:
    userClass();

    // Get and set username
    void getUsername();
    void setUsername();

    // Get and set password
    void getPassword();
    void setPassword();

    // Get and set secret question
    void getQuestion();
    void setQuestion();

    // Get and set secret answer
    void getAnswer();
    void setAnswer();

    // Get and set info
    void getInfo();
    void setInfo();

    /** USER TYPE       USER LEVEL
    *** ADMIN           0 (This is for programmers that wish to debug or edit functionality)
    *** POWER USER      1 (This is for users that can edit SOME information in other accounts (Think system admins)
    *** USER            2 (This is the default level for all accounts unless otherwise specified)
    *** GUEST           3 (This is the temporary level of accounts being created/edited)
    **/
    // Get and set user level (refer to above chart for help)
    void getUserLvl();
    void setUserLvl();



};

#endif // USERCLASS_H
