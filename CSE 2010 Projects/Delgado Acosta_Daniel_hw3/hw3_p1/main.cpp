#include <iostream>

using namespace std;

string repeat(string str, int n)
{

    string strReturn ="";
    for (int i = 0; i < n; i++)
    {
        strReturn += str;
    }
    return strReturn;
}


int main()
{

    cout << repeat("ho", 3) << endl;


    return 0;
}

