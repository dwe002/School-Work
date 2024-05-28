#pragma once
#ifndef RECTANGLE_H_INCLUDED
#define RECTANGLE_H_INCLUDED
#include <iostream>

using namespace std;

class Rectangle
{

public:
    void SetWidth(double);
    void SetHeight(double);

    Rectangle();


    Rectangle(double, double);

    double get_perimeter();
    double get_area();
    void resize(double);
    void print();

private:
    double width;
    double height;

};


#endif // RECTANGLE_H_INCLUDED
