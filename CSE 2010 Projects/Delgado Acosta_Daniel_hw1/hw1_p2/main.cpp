#include <iostream>

using namespace std;

int main()
{
    int number;
    int digitOne, digitTwo, digitThree, digitFour, digitFive;

    cout << "Enter an integer number: ";
    cin >> number;
    cout << endl;

    digitOne = number / 10000 % 10;
    digitTwo = number / 1000 % 10;
    digitThree = number / 100 % 10;
    digitFour = number / 10 % 10;
    digitFive = number % 10;

    cout << "This is the number separated by each digit: " << digitOne << " " << digitTwo << " " << digitThree << " " << digitFour << " " << digitFive<< endl;

    return 0;
}
