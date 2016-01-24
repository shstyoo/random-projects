// Created by Steve Yoo
// 9/30/2014
// User Database using SQLite
// Code was written in reference to: http://www.dreamincode.net/forums/topic/122300-sqlite-in-c/

#include "mainHeader.h"
#include <iostream>

// ctor
userDatabase::userDatabase(char* filename){
    database = NULL;
    open(filename);
}

// dtor
userDatabase::~userDatabase(){

}

// Checks to see if database open is successful
bool userDatabase::open(char* filename){
    if(sqlite3_open(filename, &database) == SQLITE_OK)
        return true;

    return false;
}

/**
*** A vector of a vector of strings (is basically a 2 dimensional array)
*** The upside is that vectors do not have to have a fixed size
*** Keep in mind that vector<vector<string>> results is different from int result
**/

vector<vector<string>> userDatabase::query(char* query){
    sqlite3_stmt *statement;
    vector<vector<string>> results;

    if(sqlite3_prepare_v2(database, query, -1, &statement, 0) == SQLITE_OK){
        int cols = sqlite3_column_count(statement);
        int result = 0;
        while(true){
            result = sqlite3_step(statement);

            if(result == SQLITE_ROW){
                vector<string> values;
                for(int col = 0; col < cols; col++){
                    values.push_back((char*)sqlite3_column_text(statement, col));
                }
                results.push_back(values);
            }
            else{
                break;
            }
        }
    sqlite3_finalize(statement);
    }
    string error = sqlite3_errmsg(database);
    if(error != "not an error") cout << query << " " << error << endl;

    return results;
}

// Close database after manipulation (prevents memory leaks)
void userDatabase::close(){
    sqlite3_close(database);
}
