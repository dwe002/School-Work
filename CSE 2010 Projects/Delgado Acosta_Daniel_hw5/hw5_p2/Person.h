#pragma once
#ifndef PERSON_H_INCLUDED
#define PERSON_H_INCLUDED
#include "StreetAddress.h"
#include <iostream>

using namespace std;

class person
{
public:

    person();

    person(string, streetAddress);

    void print();

private:
    string name;
    streetAddress address;

};


#endif // PERSON_H_INCLUDED
