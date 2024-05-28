
#include <iostream>
#include <string>
#include "LinkedList.h"
#include "LinkedList.cpp"
  

using namespace std;

 
int
main () 
{
  
 
 
LinkedList < int >intll;
  
int x = 1;
  
 
cout << "Create a list of integers:" << endl;
  
while (x != 0)
    
    {
      
 
cin >> x;
      
if (x == 0)
	
break;
      
intll.insert_front (x);
    
 
}
  
 
 
 
cout << endl << "The size of linked list is: " << intll.
    get_size () << endl;
  
cout << "The linked list is:" << endl;
  
intll.print ();
  
 
 
 
int key;
  
cout << endl << endl << "Enter the key: ";
  
cin >> key;
  
cout << "Is the key in the list? " << intll.find (key) << endl;
  
 
 
 
int k;
  
cout << endl << "How many values you want to remove? ";
  
cin >> k;
  
 
for (int i = 0; i < k; i++)
    
intll.remove_front ();
  
 
cout << "The linked list is:" << endl;
  
intll.print ();
  
cout << endl << endl;
  
 
 
LinkedList < string > strll;
  
string s_val = "";
  
 
cout << "Create a list of strings:" << endl;
  
while (s_val != "exit")
    
    {
      
cin >> s_val;
      
if (s_val == "exit")
	
break;
      
strll.insert_front (s_val);
    
}
  
 
 
cout << endl << "The size of linked list is: " << strll.
    get_size () << endl;
  
cout << "The linked list is:" << endl;
  
strll.print ();
  
 
 
 
cout << endl << endl << "How many values you want to remove? ";
  
cin >> k;
  
 
for (int i = 0; i < k; i++)
    
strll.remove_front ();
  
cout << "The list is:" << endl;
  
strll.print ();
  
cout << endl;

return 0;

}
 