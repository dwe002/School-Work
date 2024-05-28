#include <iostream>

using namespace std;

int main()
{
    string firstName, secondName, thirdName;


    cout << "Enter three strings: ";

    cin >> firstName;

    cin >> secondName;

    cin >> thirdName;

    if(firstName < secondName && firstName < thirdName)
    {
        cout << firstName << endl;

        if(secondName < thirdName)
        {
            cout << secondName << endl;
            cout << thirdName << endl;
        }

        else
        {
            cout << thirdName << endl;
            cout << secondName << endl;
        }
    }


    if(secondName < firstName && secondName < thirdName)
    {
        cout << secondName << endl;

        if(firstName < thirdName)
        {
            cout << firstName << endl;
            cout << thirdName << endl;
        }

        else
        {
            cout << thirdName << endl;
            cout << firstName << endl;
        }
    }


    if(thirdName < firstName && thirdName < secondName)
    {
        cout << thirdName << endl;

        if(firstName < secondName)
        {
            cout << firstName << endl;
            cout << secondName << endl;
        }

        else
        {
            cout << secondName << endl;
            cout << firstName << endl;
        }
    }


    return 0;
}
