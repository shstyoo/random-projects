#include <iostream>

using namespace std;

//Global Variable Declarations
int idSize;

//quickUnionUF Member Functions
class quickUnionUF{
private:
    int *id;
    int *sz;
    int root(int);
public:
    quickUnionUF(int);
    bool connected(int, int);
    void unionPoint(int, int);
    void print();
};

//quickUnionUF Member Function declarations
quickUnionUF::quickUnionUF(int n){ //Set id of each object to itself (N Array accesses)
    idSize = n;
    id = new int(n);
    sz = new int(n);
    for(int i=0;i<n;i++){
        id[i] = i;
    }
    for(int i=0;i<n;i++){
        sz[i] = 1;
    }
}
int quickUnionUF::root(int n){ //Chase parent pointers until reach root (depth of p and q array)
    while(n != id[n]){
        n = id[n];
    }
    return n;
}
bool quickUnionUF::connected(int p, int q){ //Check if p and q have the same root (depth of p and q array)
    return root(p) == root(q);
}
void quickUnionUF::unionPoint (int p, int q){
    int i = root(p);
    int j = root(q);
    //Weighted will check the size of the tree rooted at i, then add the sz[i] to sz[j] or vise versa depending on which sz[] is bigger
    //      Condition           Execution
    if      (i == j)            { return; }
    else if (sz[i] < sz[j])     { id[i] = j; sz[j] += sz[i]; }
    else                        { id[j] = i; sz[i] += sz[j]; }
}
void quickUnionUF::print(){
    for(int i=0; i<idSize; i++){
        cout << i << " - " << id[i] << endl;
    }
    cout << "-----------------------------" << endl;
    for(int i=0; i<idSize; i++){
        cout << i << " - " << sz[i] << endl;
    }
    cout << "-----------------------------" << endl;

}

int main()
{
    quickUnionUF test(10);
    test.print();
    test.unionPoint(4,0);
    test.unionPoint(5,7);
    test.unionPoint(7,0);
    test.unionPoint(1,3);
    test.unionPoint(8,3);
    test.unionPoint(2,9);
    test.unionPoint(6,2);
    test.print();
    cout << endl << test.connected(4,5) << ", ";
    cout << test.connected(9,5) << ", ";
    cout << test.connected(2,1) << ", ";
    cout << test.connected(1,8) << ", ";
    cout << test.connected(0,5) << ", ";
    cout << test.connected(9,2) << endl;
}

