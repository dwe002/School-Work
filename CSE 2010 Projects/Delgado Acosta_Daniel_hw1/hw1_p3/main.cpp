#include <iostream>

using namespace std;

int main()
{
    double money;
    int dollars, cents;

    cout << "Enter an amount of money: ";
    cin >> money;

    dollars = money;

    cents = ((money - dollars) * 100) + 0.5;

    cout << endl;
    cout << "dollars: " << dollars << endl;
    cout << "cents: " << cents << endl;



    return 0;
}
