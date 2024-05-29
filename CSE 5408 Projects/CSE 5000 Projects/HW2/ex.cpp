#include<iostream>
using namespace std;
int main()
{
	//let states be 1,2 and 3 where 2 is final state and 1 is initial state
	int state=1,n;
	char input;
	cout<<"\nEnter total length of string :";
	cin>>n;
	for(int i=1;i<=n;i++)
	{
		cout<<"Enter string symbol :";
		cin>>input;
		switch(state)
		{
			case 1: if(input=='a')state=2;
			 else state=1;
				break;
			case 2: if(input=='a')state=2;
			 else state=3;
			break;
			case 3:
			if(input=='a') state=1;
			else state=2;
			break;
		}
	}
	if(state==2)
	cout<<"\nString is accepted by FA";
	else
	cout<<"\nString is not accepted by FA";
}