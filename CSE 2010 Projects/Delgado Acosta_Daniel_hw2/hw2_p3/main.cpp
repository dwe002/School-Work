#include <iostream>

using namespace std;

int main()
{

    string reverse;
   cout << "Enter a string to print in reverse" << endl;

   cin >> reverse;

   {
   for(int i = reverse.length() - 1; i >= 0; i--)
   {
      cout << reverse.at(i);
   }
    cout << endl;

   }


    return 0;
}
