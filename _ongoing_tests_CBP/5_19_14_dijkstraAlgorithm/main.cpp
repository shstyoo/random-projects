#include <iostream>
#include <stack>
#include <sstream>

using namespace std;

/*This code works! However, it is interesting to note
that program doesn't work unless the input has every
character separated by a space!
E.g.    (1+(2*3)) will output a segmentation fault whereas
        ( 1 + ( 2 * 3 ) ) will have the program output
the correct answer.*/

int main(){
    stack<string> ops;
    stack<double> vals;
    string input;
    getline(cin, input);
    istringstream scanner(input);
    while(true){
        double num;
        if(scanner >> num) vals.push(num);
        if(scanner.fail() && scanner.eof())     break;
        else{
            scanner.clear();
            string token;
            scanner >> token;
            if(token == "(")                    ;
            else if(token == "+")               ops.push(token);
            else if(token == "*")               ops.push(token);
            /*Feel free to add more operations here (Log, sin, cos...)*/
            else if(token == ")"){
                string op = ops.top();
                ops.pop();
                if(op == "+"){
                    double a, b;
                    a = vals.top();
                    vals.pop();
                    b = vals.top();
                    vals.pop();
                    vals.push(a+b);
                }
                else if(op == "*"){
                    double a, b;
                    a = vals.top();
                    vals.pop();
                    b = vals.top();
                    vals.pop();
                    vals.push(a*b);
                }
                /*Add more operations here*/
            }
        }
    }
    return vals.top();
}
