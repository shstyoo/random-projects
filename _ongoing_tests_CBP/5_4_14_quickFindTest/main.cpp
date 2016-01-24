#include <iostream>

using namespace std;

//Global Variables
int idSize;

class quickFindUF{
private:
    int id[];
public:
    quickFindUF(int);
    bool connected (int, int);
    void unionPoint (int, int);
    void print();
};

//quickFindUF Member Functions
quickFindUF::quickFindUF(int n){
    idSize = 0;
    id[n];
    for(int i=0; i<n; i++){
        id[i] = i;
        idSize++;
    }
}
bool quickFindUF::connected(int p, int q){
    return id[p] == id[q];
}
void quickFindUF::unionPoint(int p, int q){
    int pid = id[p];
    int qid = id[q];
    for(int i=0; i<idSize; i++){
        if(id[i] == pid) id[i] = qid;
    }
}
void quickFindUF::print(){
    for(int i=0; i<idSize; i++){
        cout << id[i] << endl;
    }
}

int main()
{
    quickFindUF test(10);
    test.unionPoint(1,2);
    test.unionPoint(4,3);
    test.unionPoint(0,9);
    test.unionPoint(8,9);
    test.unionPoint(5,7);
    test.unionPoint(6,8);
    test.unionPoint(5,6);
    test.print();
    cout << test.connected(1,2) << endl;
    cout << test.connected(3,4) << endl;
    cout << test.connected(2,3) << endl;
    cout << test.connected(3,5) << endl;
    cout << test.connected(7,8) << endl;
    cout << test.connected(0,7) << endl;
}
