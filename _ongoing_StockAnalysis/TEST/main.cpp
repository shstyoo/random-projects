#include <stdio.h>
#include <sqlite3.h>
#include <string>
#include <iostream>

#include "uniform_int.hpp"

/*
static int callback(void *NotUsed, int argc, char **argv, char **azColName){
    int i;
    for(i=0;i<argc;i++){
        printf("%s = %s\n", azColName[i], argv[i] ? argv[i] : "NULL");
    }
    printf("\n");
    return 0;
}

int main()
{
    sqlite3 *db;
    char *zErrMsg = 0;
    int rc;

    rc = sqlite3_open("test.db", &db);

    if( rc ){
        fprintf(stderr, "Can't Open database: %s\n", sqlite3_errmsg(db));
        exit(0);
    }
    else{
        fprintf(stderr, "Opened Database Successfully \n");
    }
    sqlite3_close(db);
}*/

int main(){
    std::cout << uniform_int(IntType min = 0, IntType max = 99);
}

