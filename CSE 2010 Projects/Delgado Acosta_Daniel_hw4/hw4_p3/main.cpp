#include <iostream>
#include <string>
#include "Employee.h"

using namespace std;

void printChainOfCommand(Employee* lL)
{
    Employee* currentNode = lL;
    cout << "Chain of Command of " << (*lL).GetName() << ": " << endl;
    //currentNode = currentNode->GetNext();
    while (currentNode->GetNext() != NULL)
    {

        cout << "  -";
        currentNode->PrintEmployeeData();
        currentNode = currentNode->GetNext();
    }

    cout << "  -";
    currentNode->PrintEmployeeData();
    cout << endl;


    return;
}


int main()
{
    Employee employee1("Steve(CEO)");
    Employee employee2("John");
    Employee employee3("Harry");
    Employee employee4("Josh");
    Employee employee5("Jameson");
    Employee employee6("Dereck");

    employee2.SetManager(&employee1);
    employee3.SetManager(&employee1);
    employee4.SetManager(&employee2);
    employee5.SetManager(&employee2);
    employee6.SetManager(&employee3);

    printChainOfCommand(&employee1);
    printChainOfCommand(&employee2);
    printChainOfCommand(&employee3);
    printChainOfCommand(&employee4);
    printChainOfCommand(&employee5);
    printChainOfCommand(&employee6);

    return 0;
}
