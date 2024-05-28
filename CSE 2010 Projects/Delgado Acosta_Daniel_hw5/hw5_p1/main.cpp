#include <iostream>
#include "Rectangle.h"
#include <iostream>

using namespace std;

int main()
{
    Rectangle rectangle1;

    rectangle1.SetWidth(2.0);
    rectangle1.SetHeight(4.0);

    rectangle1.print();

    cout << "perimeter: " << rectangle1.get_perimeter() << endl;
    cout << "area: " << rectangle1.get_area() << endl;

    cout << endl << "After resize: " << endl;
    rectangle1.resize(3);
    rectangle1.print();

    cout << "perimeter: " << rectangle1.get_perimeter() << endl;
    cout << "area: " << rectangle1.get_area() << endl;


    return 0;
}
