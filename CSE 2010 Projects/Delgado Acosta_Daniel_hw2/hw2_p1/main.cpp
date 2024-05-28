#include <iostream>

using namespace std;

int main()
{
    int score;

    cout << "Enter a score between 0 and 100 for a letter grade" << endl;
    cin >> score;

    if(score >= 93 && score <= 100)
    {
        cout << "Your grade is: A";
    }
    else if(score >= 90 && score <= 92)
    {
        cout << "Your grade is: A-";
    }
    else if(score >= 86 && score <= 89)
    {
        cout << "Your grade is: B+";
    }
    else if(score >= 83 && score <= 85)
    {
        cout << "Your grade is: B";
    }
    else if(score >= 80 && score <= 82)
    {
        cout << "Your grade is: B-";
    }
    else if(score >= 76 && score <= 79)
    {
        cout << "Your grade is: C+";
    }
    else if(score >= 73 && score <= 75)
    {
        cout << "Your grade is: C";
    }
    else if(score >= 70 && score <= 72)
    {
        cout << "Your grade is: C-";
    }
    else if(score >= 66 && score <= 69)
    {
        cout << "Your grade is: D+";
    }
    else if(score >= 63 && score <= 65)
    {
        cout << "Your grade is: D";
    }
    else if(score >= 60 && score <= 62)
    {
        cout << "Your grade is: D-";
    }
    else if(score >= 0 && score <= 59)
    {
        cout << "Your grade is: F";
    }
    else
    {
        cout << "Score has to be between 0 and 100";
    }

    cout << endl;

    return 0;
}
