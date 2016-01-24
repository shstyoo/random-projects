// Created by Seunghyun Yoo
// 10/1/2014
// Main function

#include <iostream>
#include <string>

#include "mainHeader.h"

using namespace std;

int main()
{
    displayMenu aMenu;
    aMenu.getMenu(1);
    cout << aMenu.getIndex(aMenu.setIndex()) << endl;
    cout << aMenu.getIndexName(aMenu.setIndexName()) << endl;
    aMenu.historyFunc();
    aMenu.quit();

    cout << "Basic SQLite C++ functionality" << endl;


    string name;
    cout << "Enter database name" << endl;
    cin >> name;

    cout << "Creating database..." << endl;
    userDatabase *db;
    cout << "Pointer to db database created" << endl;

    cout << "Creating new database called Database.sqlite" << endl;
    db = new userDatabase("Database.sqlite");

    db->query("CREATE TABLE tb (a INTEGER, b INTEGER);");
    db->query("INSERT INTO tb VALUES(1, 2);");
    db->query("INSERT INTO tb VALUES(5, 4);");
    vector<vector<string>> result = db->query("SELECT a, b FROM tb;");
    for(vector<vector<string>>::iterator it = result.begin(); it < result.end(); ++it){
        vector<string> row = *it;
        cout << "Values: (A=" << row.at(0) << ", B=" << row.at(1) << ")" << endl;
    }
    db->close();
}
