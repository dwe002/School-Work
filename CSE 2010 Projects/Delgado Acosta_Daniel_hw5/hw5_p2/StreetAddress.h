#pragma once
#ifndef STREETADDRESS_H_INCLUDED
#define STREETADDRESS_H_INCLUDED
#include <iostream>

using namespace std;

class streetAddress
{
public:

    streetAddress();

    streetAddress(int, string, string, string, string);

    void print();

private:
    int house_number;
    string street;
    string city;
    string state;
    string postal_code;

};


#endif // STREETADDRESS_H_INCLUDED
