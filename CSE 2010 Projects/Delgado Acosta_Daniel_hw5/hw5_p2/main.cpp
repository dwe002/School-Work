#include <iostream>
#include "StreetAddress.h"
#include "person.h"

using namespace std;

int main()
{
    streetAddress SA1(31267, "Green Street", "Claremont", "Wisconsin", "68754");
    streetAddress SA2(21786, "Omega Drive", "Salma", "Kentucky", "15689");

    string name1 = "Gary Linker";
    string name2 = "Mary Bessy";

       person person1(name1, SA1);
       person person2(name2, SA2);

       person1.print();
       person2.print();

    return 0;
}
