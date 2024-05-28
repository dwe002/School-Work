#include <iostream>

using namespace std;

const int COLS = 3;


bool values_identical_2d(int values[][COLS],int rows)
{
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < COLS - 1; j++)
		{
			if (values[i][j] != values[i][j+1])
			{
				return false;
			}
		}
	}
	return true;
}

int main()
{

	int arrayA [2][COLS] = {{1,2,3},
                                {4,5,6}};

	int arrayB [2][COLS] = {{2,2,2},
                                {3,3,3}};


	if (values_identical_2d(arrayA, 2))
    {
        cout << "Array A is identical." << endl;

    }
	else{

        cout << "Array A is NOT identical." << endl;
        }



        if (values_identical_2d(arrayB, 2))
    {
        cout << "Array B is identical." << endl;

    }
	else{

        cout << "Array B is NOT identical." << endl;
        }


	return 0;
}
