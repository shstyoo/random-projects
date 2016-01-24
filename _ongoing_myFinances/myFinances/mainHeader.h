#ifndef MAINHEADER_H_INCLUDED
#define MAINHEADER_H_INCLUDED

class bankAccount(){
public:
    bankAccount(string);
    ~bankAccount();

    void addBalance(&double);
    void rmvBalance(&double);
    double getBalance();
    void getHistory();
    void printBalToFile();

private:
    string acctName;
    double balance;
    string description;
};

int checkFile(string filename, int type);

#endif // MAINHEADER_H_INCLUDED
