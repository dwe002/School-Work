#include "funcs.h"

int linear_search(int a[], int size, int key)
{
	int i = 0;
	
	while(i < size)
	{
		if(key == a[i]){
			return i;
		}
		i++;
		
		}
	return -1;
}

