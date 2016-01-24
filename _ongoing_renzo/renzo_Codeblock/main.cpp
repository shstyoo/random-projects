#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;

int superman(int super);

int main()
{
    string ans;
    cout << "suckadick";
    int cont = 1;
    while (cont != 0)
    {

    cin >> ans;
    if(ans == "A") cout << "suckmoredick A" << endl;
    else if (ans == "B") cout << "suckmoredick B" << endl;
    else if (ans == "C") cout << superman(4);
    else cout << "incorrect option cunt" << endl;

    }
    return 0;
}

int superman (int super)
{
    cout << "renzo u suk";
    return 1;
}
