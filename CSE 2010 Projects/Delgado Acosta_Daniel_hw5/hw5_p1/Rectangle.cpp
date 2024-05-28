#include "Rectangle.h"
#include <iostream>

Rectangle::Rectangle()
{
    width = 0;
    height = 0;
}

Rectangle::Rectangle(double a, double b)
{
    width = a;
    height = b;
}

void Rectangle::SetWidth(double w)
{
    width = w;
}

void Rectangle::SetHeight(double h)
{
    height = h;
}

double Rectangle::get_perimeter()
{
    return 2 * (width + height);
}

double Rectangle::get_area()
{
    return width * height;
}

void Rectangle::resize(double factor)
{
    width = width * factor;
    height = height * factor;
}

void Rectangle::print()
{
    cout << "width: " << width << endl;
    cout << "height: " << height << endl;
}
