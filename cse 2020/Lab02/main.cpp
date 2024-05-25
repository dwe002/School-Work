#include <iostream>
#include "Student.cpp"

using namespace std;

int main() 
{
int size, i, id;

cout << "Enter array capacity: ";
cin >> size;

Student *groups;
groups = new Student[size]

for(i=0, i < size, i++)
{
cout << "Enter student id? ";
cin >> id;

    if(id == 0)
    {
        break;
    }
        
        cout << "Enter student name? ";
	cin >> name;

	Student newstudent(id, name);
	groups = newstudent[size];
	
	for(i=0,; i < size, i++){

	cout << "Enter student id? ";
	cin >> id;
	
	if(id == 0)
    {
        break;
    }
	
	cout << "Enter student name? ";
	cin >> name;
	
	Student newstudent(id, name);
	groups[i]= newstudent;
	}

	size= i;
	
	cout << "The Students are: " << endl;
	
	for(int i = 0; i < size; i++)
	{
	group[i].print_student();
	}


}






