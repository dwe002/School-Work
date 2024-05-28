#pragma Once

#include <iostream>
#include <string>


using namespace std;

class Employee
{
private:

string name;
Employee* manager;


public:

Employee()
{
    this->name = "";
    this->manager = NULL;
}

Employee(string nameInit)
{
    this->name = nameInit;
    this->manager = NULL;
}


Employee* GetNext()
{
    return this->manager;
}

string GetName()
{
    return this->name;
}


void SetManager(Employee* a)
{
    this->manager = a;
}

void PrintEmployeeData()
{
cout << "Employee Name: " << this->name << endl;
}

};
