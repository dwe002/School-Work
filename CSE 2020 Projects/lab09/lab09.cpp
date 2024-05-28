#include <iostream>
#include "bst.cpp"
using namespace std;

int main () 
{

  BinarySearchTree < int >iTree;
  
int value, lowValue, highValue;
  
    cout << "insert the values (stop when entering 0): " << endl;
  
  do
    {
      
cin >> value;
      
if (value != 0)
	
iTree.insert (value);
    
}
  while (value != 0);
  
    cout << endl << "print the values:" << endl;
  
iTree.printBST ();
  
    cout << endl << endl << "remove the values (stop when entering 0):" << endl;
  
  do
    {
      
cin >> value;
      
if (value != 0)
	
iTree.remove (value);
    
}
  while (value != 0);
  
    cout << endl << "print the values:" << endl;
  
iTree.printBST ();

    cout << endl << endl << "Please enter the range: ";
  
cin >> lowValue >> highValue;
  
    cout << "Print the element between the range: " << endl;
  
iTree.printRange (lowValue, highValue);
  
cout << endl << endl;
  
    BinarySearchTree < string > sTree;
  
string word;
  
    cout << "insert the strings (stop when entering \"exit\"):" << endl;
  
  do
    {
      
cin >> word;
      
if (word != "exit")
	
sTree.insert (word);
    
}
  while (word != "exit");
  
    cout << endl << "print the values:" << endl;
  
sTree.printBST ();
  
return 0;

}