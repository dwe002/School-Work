// Question 3.39b
#include<iostream>
using namespace std;

int main()
{
	int state = 0, string;
	char input;
	cout<<"\nEnter string length(number):";
	cin >> string;
	for(int i=1; i <= string; i++)
	{
		cout<<"Enter string symbol(a or b):";
		cin>>input;
		switch(state)
		{
			case 0: if(input == "a") state = 1;
			 else state = 0;
				break;
			case 1: if(input == "a") state = 1;
			 else state = 2;
			break;
			case 2:
			if(input == "a") state = 0;
			else state = 1;
			break;
		}
	}
	if(state==1)
	cout<<"Accepted by FA";
	else
	cout<<"Not accepted by FA";
}