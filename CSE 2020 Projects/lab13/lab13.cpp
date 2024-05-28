#include "MergeSort.cpp"
#include <iostream>
#include <fstream>

int main()
{
	vector<int> v;
  
	ifstream input("sort.txt");
	int number;
	while(input >> number)
	{
    	v.push_back(number);
	}
	input.close();
  
	mergeSort(v);
  
	cout << "\nThe merge sort: ";
	for(unsigned int i = 0; i < v.size(); i++)
	{
    	cout << v[i] << " ";
	}
	cout << endl;

	return 0;
}