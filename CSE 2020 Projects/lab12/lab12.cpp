#include <iostream>
#include "BinaryHeap.cpp"

using namespace std;


int main ()
{
  BinaryHeap < int >printQueue;
  
  int n, p;
  int totalJobs = 9;
  
  for (int i = 0; i < totalJobs; i++)
    {
      cout << "The priority of print job? ";
      cin >> p;
      printQueue.insert (p);
    }
    
  cout << "\nThe print jobs:";
  printQueue.printJobs ();
  
  cout << "\n\nThe number of jobs the printer will run? ";
  cin >> n;
  
  for (int i = 0; i < n; i++)
    printQueue.deleteMin ();
    
  cout << "\nThe print jobs:";
  printQueue.printJobs ();
  
  return 0;
}