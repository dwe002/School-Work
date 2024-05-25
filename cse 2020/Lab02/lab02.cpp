#include <iostream>
#include "Student.cpp"

using namespace std;

int main() 
{
int capacity;

cout << "Enter array capacity: ";
cin >> capacity;

student* groups = new Student[capacity];

cout << "Enter student id? ";
cin >> id;

	while (id != 0)
 	{
	cout << "Enter student name? ";
	cin >> name;

	Student newstudent(id, name);
	groups[size] = newstudent;
	size++;

	cout << "Enter student id? ";
	cin >> id;
	}

	for(int i = 0; i < size; i++)
	{
	group[i].print();
	} 


}






