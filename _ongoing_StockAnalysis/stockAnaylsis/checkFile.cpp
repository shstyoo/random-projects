// Created by Steve Yoo
// 9/16/2014
// File Checker

#include <string>
#include <fstream>
#include <iostream>

#include "mainHeader.h"

// For usage help check "mainHeader.h" and search for "checkFile"
int checkFile(string filename, int type){

    // Writing to a file
    if(type == 0){

        // Create an ofstream object called output_stream for our writing needs
        ofstream output_stream;

        // Specify the parameters for output_stream
        output_stream.open(filename, ios::out);

        // Check whether or not output_stream was able to open the file successfully
        if(output_stream.fail()){
            cout << endl << "File failed to open!" << endl << endl;
            return 0;
        }
        else{
            cout << endl << "Opening file to write..." << endl << endl;
            return 1;
        }

        // Close our output_stream to free up resources
        output_stream.close();
    }

    // Reading from a file
    else if(type == 1){

        // Create an ifstream object called input_stream for our reading needs
        ifstream input_stream;

        // Specify the parameters for input_stream
        input_stream.open(filename, ios::in);

        // Check whether or not input_stream was able to open the file successfully
        if(input_stream.fail()){
            cout << endl << "File failed to open!" << endl << endl;
            return 0;
        }
        else{
            cout << endl << "Opening file to read..." << endl << endl;
            return 1;
        }

        // Close input_stream
        input_stream.close();
    }

    // Keep in mind fstream doesn't use ios::in/ios::out... it uses fstream::in/fstream::out...
    // Reading and writing
    else if(type == 2){

        // Create an fstream object called io_stream to read/write from file
        fstream io_stream;

        // Specify the parameters for io_stream;
        io_stream.open(filename);

        //Check whether or not io_stream was able to open the file successfully
        if(io_stream.fail()){
            cout << endl << "File failed to open!" << endl << endl;
            return 0;
        }
        else{
            cout << endl << "Opening file to read/write..." << endl << endl;
            return 1;
        }

        //Close io_stream
        io_stream.close();
    }
    else{
        cout << "Error in \"checkFile.cpp\" and all classes and functions that may call it" << endl;
        cout << "Error type: This type for \"checkFile\" does not exist" << endl;
    }
}
