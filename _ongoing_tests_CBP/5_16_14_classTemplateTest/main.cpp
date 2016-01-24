#include <iostream>
#include <algorithm>

using namespace std;
/*                      PROGRAMMER NOTES
The program contains the skeleton for an array of strings initialized
by *box. So far functionality includes create, destroy, delete, and view.
There is also arrays *box and *boxList. *box has been created in the
constructor already. However *boxList has not yet been implemented, and
must be once the STACK implementation is complete (See below).
*************************************************************************
Currently program requires the implementation of a STACK for both
deleting items and adding items. Also requires a STACK for the viewing
of the list of crates a user can create during runtime. Also requires
implementation for creating a file that can store crate names and
content.
*/
//Global Variables
int boxSize;

//Class Crate Declarations
class crate{
private:
    string *box;
    string *boxList;
public:
    crate(int);
    void viewItems();
    bool deleteItems();
    bool addItems();
    ~crate();
};
//Crate Constructor (Requires N to set initial crate size)
crate::crate(int n){
    boxSize = n;
    box = new string(n);
    for(int i=0;i<n;i++){
        box[i] = "0";
    }
}
//Crate Member Functions
void crate::viewCrates(){

}
void crate::viewItems(){
    for(int i=0;i<boxSize;i++){
        cout << i << ". " << box[i] << endl;
    }
}
bool crate::deleteItems(){
    //implementation for deleting crate items (stack using pop-push)
}
bool crate::addItems(){
    //implementation for adding crate items (stack using pop-push)
}
crate::~crate(){
    delete box;
}

int main()
{
    bool cont = true;
    bool cont2 = false;
    int boxSize2;
    string choice, choice2;
    do{
        cout << "Type a command (Type help to see available commands)" << endl << ">";
        cin >> choice;
        transform(choice.begin(), choice.end(), choice.begin(), ::toupper);
        if(choice == "HELP"){
            cout << "Your available commands are: " << endl << "View, Create, Destroy, Delete" << endl;
        }
        else if(choice == "VIEW"){
            if(cont2==false){
                cout << "There are no crates to view. You must CREATE one first" << endl;
            }
            else{

            }
        }
        else if(choice == "CREATE"){
            cout << "Enter crate name: ";
            cin >> choice2;
            transform(choice2.begin(), choice2.end(), choice2.begin(), ::toupper);
            cout << "Enter crate size: ";
            cin >> boxSize2;
            crate choice2(cSize);
        }
        else if(choice == "DELETE"){
            if(cont2==false){
                cout << "There are no crates to delete. You must CREATE one first" << endl;
            }
            else{

            }
        }
        else if(choice == "DESTROY"){
            if(cont2==false){
                cout << "There are no crates to destroy. You must CREATE one first" << endl;
            }
            else{

            }
        }
        else{
            cout << "Incorrect input, type help to see available commands" << endl;
        }

    }while(!cont);
}
