#include "StreetAddress.h"

streetAddress::streetAddress()
{

house_number = 0;
street = "";
city = "";
state = "";
postal_code = "";

}

streetAddress::streetAddress(int i, string s1, string s2, string s3, string s4)
{

house_number = i;
street = s1;
city = s2;
state = s3;
postal_code = s4;

}


void streetAddress::print()
{
    cout << "House Number: " << house_number << endl;
    cout << "Street: " << street << endl;
    cout << "City: " << city << endl;
    cout << "State: " << state << endl;
    cout << "Postal Code: " << postal_code << endl << endl;
}
