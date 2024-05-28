
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	ifstream inData;
	ofstream outData;
	inData.open("input.txt");
	outData.open("output.txt");
	string line;


	while (!inData.eof())
	{
	    getline(inData, line);

		for(int i = line.size() - 1; i >= 0; i--)
		{
			outData << line.at(i);
		}
	outData << endl;
	}

inData.close();
outData.close();

return 0;

}
