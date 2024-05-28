#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    cout << fixed << setprecision(2);

    double trainFare;
    double distance;
    double milesPerGallon;
    double costOfDriving;

    cout << "Enter the cost of a train ticket: ";
    cin >> trainFare;
    cout << "Enter the distance in miles between home and work: ";
    cin >> distance;
    cout << "Enter the miles per gallon of your car: ";
    cin >> milesPerGallon;
    cout << endl;

    costOfDriving = (distance / milesPerGallon * 4) + (distance * 0.05);

    if (trainFare > costOfDriving)
    {

        cout << "The train fare is " <<trainFare << endl;
        cout << "The cost of driving is " << costOfDriving << endl;
        cout << "It is cheaper to drive to work." << endl;


    }


    else
    {

        cout << "The train fare is " <<trainFare << endl;
        cout << "The cost of driving is " << costOfDriving << endl;
        cout << "It is cheaper to take the train." << endl;


    }







    return 0;
}
