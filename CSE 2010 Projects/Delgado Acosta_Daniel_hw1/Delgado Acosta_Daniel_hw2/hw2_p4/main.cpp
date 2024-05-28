#include <iostream>

using namespace std;

int main()
{
    bool first = true;
    int value;
    int minimum;

    while (cin >> value)
    {

        if (first)
        {

            minimum = value;
            first = false;

        }
        else if(value < minimum)
        {

            minimum = value;

        }
    }

    cout << minimum << endl;

    return 0;
}
