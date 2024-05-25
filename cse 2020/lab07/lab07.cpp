#include "Employee.cpp"
#include "DoublyLinkedQueue.cpp"
#include <iostream>
using namespace std;

int
main ()
{
  
  Queue < int >queueInteger;
  
cout << "Enqueue positive numbers (Enter 0 to stop): \n";
  
    do
    {
      
int intVal;
      
cin >> intVal;
      
if (intVal == 0)
	{
	  
break;
	
}
      
queueInteger.enqueue (intVal);
    
}
  while (true);
  
cout << "print queue: ";
  
queueInteger.print ();	
  int k;
  
cout << endl << "How many numbers to be removed from queue: ";
  
    cin >> k;
  
    while (k-- > 0 && !queueInteger.empty ())
    {
      
queueInteger.dequeue ();
    
}
  
cout << endl << "print queue: ";
  
queueInteger.print ();	
  cout << endl << endl;
  
 
    Queue < string > queueString;
  
cout << "Enqueue string (enter exit to stop): \n";
  
    do
    {
      
string stringVal;
      
cin >> stringVal;
      
if (stringVal == "exit")
	{
	  
break;
	
}
      
queueString.enqueue (stringVal);
    
}
  while (true);
  
cout << endl << "print queue: ";
  
queueString.print ();
  cout << endl << "How many strings to be removed from queue: ";
  
cin >> k;
  
    while (k-- > 0 && !queueString.empty ())
    {
      
queueString.dequeue ();
    
}
  
cout << endl << "print queue: ";
  
queueString.print ();	
  cout << endl << endl;
  

    Queue < Employee > queueEmployee;
  
cout << "Enqueue employee's id, name, dept (enter id 0 to stop): \n";
  
    do
    {
      
string employeeName;
      
int employeeId;
      
string employeeDept;

cout << "Enter employee Id: ";
      
cin >> employeeId;
      
if (employeeId == 0)
	{
	  
break;
	cout << endl;
}
      
cout << "Enter Employee name: ";
      
cin >> employeeName;
      

      
cout << "Enter employee department: ";
      
cin >> employeeDept;
      
Employee employeeVal (employeeName, employeeId, employeeDept);
      
queueEmployee.enqueue (employeeVal);
    
}
  while (true);
  
cout << endl << "print queue: ";
  
queueEmployee.print ();
  cout << endl << "How many strings to be removed from queue: ";
  
cin >> k;
  
    while (k-- > 0 && !queueString.empty ())
    {
      
queueEmployee.dequeue ();
    
}
  
cout << endl << "print queue: ";
  
queueEmployee.print ();
}