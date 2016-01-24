#include <iostream>
#include <string>
#include <locale>

#include "mainHeader.h"
std::string makeThingsUpper(std::string input){
    std::locale loc;
    std::string str = input;
    std::string output;
    for (std::string::size_type i=0; i<str.length(); ++i){
        output = std::toupper(str[i], loc);
    }
    return output;
}
