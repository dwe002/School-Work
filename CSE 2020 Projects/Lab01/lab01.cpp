#include <fstream>
#include <iostream>
#include "funcs.h"

using namespace std;

int main()
{
	int list[CAPACITY];
	int number, size, i, key, index;

	ifstream input("search.txt");
	while (input >> number)
	{
		list[i] = number;
		i++;
	}
	input.close();

	size = i;

	cout << "The array: ";
	for(int i = 0; i < size; i++){
		cout << list[i] << " ";
	}
	cout << endl;
	cout << "Enter the key: ";
	cin >> key;

	index = linear_search(list, size, key);

	if(index < 0){
		cout << "key is not in list";
	}
		else{
			cout << "the index of key is: " << index << endl;
		}
		return 0;
	
}
