#include <iostream>

using namespace std;

double* maximum(double* a, int the_size)
{
double the_max = a[0];
if(the_size == 0)
{
    return nullptr;

}

for (int i=0; i < the_size; i++)
{
    if (a[i] > the_max)
        {
            the_max = a[i];
        }
}
return &the_max;
}

int main()
{
    double arr[] = {0.0, 1.0, 2.0, 3.0, 4.0, 5.0};
    int the_size = 6;

    cout << "Maximum value: " << *(maximum(arr, the_size));



    return 0;
}

//apparently this code works on other IDEs, just not on code::blocks. Not sure how to fix it here.
