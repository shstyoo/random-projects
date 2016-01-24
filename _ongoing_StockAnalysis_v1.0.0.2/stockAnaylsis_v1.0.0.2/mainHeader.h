#ifndef MAINHEADER_H_INCLUDED
#define MAINHEADER_H_INCLUDED

#include <string>
#include <vector>
#include <stack>
#include <sqlite3.h>

using namespace std;

/*
** Interface for userDatabase
*/
class userDatabase{
public:

    // Constructor for a userDatabase
    userDatabase(char* filename);

    // Destructor for a userDatabase
    ~userDatabase();

    // Open an existing database (one will be created if none exist)
    bool open(char* filename);

    /*
    ** Send a query to SQLite C++ interface
    **
    ** Refer to C/C++ SQLite API to understand how, or what
    ** commands to use.
    */
    vector<vector<string>> query(char* query);

    // Close an opened database
    void close();

private:
    sqlite3 *database;
};

/*
** Interface for a menu system
*/
class displayMenu{
public:

    // Constructor for menu class
    displayMenu();

    // Destructor
    ~displayMenu();

    // Gets, and outputs menu at specified index a
    void getMenu(int);


    // Gets user choice for getMenu()
    void getChoice(int);

    // Gets and outputs index of specified indexName
    int getIndex(string a);
    // Sets the index to get indexName of
    string setIndex();

    // Gets and outputs indexName of specified index
    string getIndexName(int a);
    // Sets the indexName to get index of
    int setIndexName();

    // Function for history
    void historyFunc();

    // Ends program (exits menu)
    void quit();

private:
    vector<string> menu;
    stack<int> history;
    int index;
    string indexName;
};

#endif // MAINHEADER_H_INCLUDED
