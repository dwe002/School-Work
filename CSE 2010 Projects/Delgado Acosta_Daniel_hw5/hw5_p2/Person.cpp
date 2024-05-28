#include "Person.h"
#include <iostream>

using namespace std;

person::person()
{
    name = "";
    streetAddress temp;
    address = temp;

}


person::person(string s, streetAddress sa)
{
    name = s;
    address = sa;
}


void person::print()
{
    cout << "Name: " << name << endl;
    address.print();
}
