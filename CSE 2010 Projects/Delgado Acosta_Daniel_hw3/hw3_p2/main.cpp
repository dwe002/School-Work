#include <iostream>

using namespace std;

bool is_vowel(char c)
{
     if (c == 'A' || c == 'a'
         || c =='E' || c =='e'
         || c =='I' || c =='i'
         || c =='O' || c =='o'
         || c =='U' || c =='u')
     {
         return true;
         }

     else

        return false;
        }

int count_vowels(string str)
{

    int numVowels = 0;

    for (int i = 0; i < str.size(); i++)
    {
        if (is_vowel(str.at(i)))
        {
            numVowels++;
        }
    }

    return numVowels;
}

int main()
{
    string string1 = "eigenvector";
    string string2 = "eigenvalue";


    cout << "The word '" << string1 << "' has " << count_vowels(string1) << " vowels." << endl;
    cout << "The word '" << string2 << "' has " << count_vowels(string2) << " vowels." << endl;


    return 0;
}
