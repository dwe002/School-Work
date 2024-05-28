#include <iostream>
#include <iomanip>
#include <string>
#include <string.h>

using namespace std;




    char* find_first(char s[], char c)
    {
        for (int i = 0; i < strlen(s); i++)
        {
            if (s[i] == c)
                {
                    return &s[i];
                }
        }
        return nullptr;
    }


int main()
{
    char string[] = "Mary had a little lamb around the world.";
    char c = 'w';

    char* thePostionWhereCIsFound = find_first(string, c);

    if (thePostionWhereCIsFound == nullptr)
    {

        cout << c << " not found.";
    }
    else
    {
        cout << c << " found at position : " << thePostionWhereCIsFound - string << '.';
    }


    return 0;
}



