#include <iostream>
#include <string>
#include <vector>


using namespace std;

vector<int> append(vector<int> a, vector<int> b)
{
    vector<int> rtnVector;

    for(int i = 0; i < a.size(); i++)
    {
        rtnVector.push_back(a.at(i));
    }

        for(int i = 0; i < b.size(); i++)
        {
            rtnVector.push_back(b.at(i));
        }

        return rtnVector;
}

void readVec(vector<int> a)
{
    for (int i = 0; i < a.size(); i++)
        cout << a.at(i) << " ";

    cout << endl;
}

int main()
{
    vector<int> vectorA;
    vectorA.push_back(1);
    vectorA.push_back(4);
    vectorA.push_back(9);
    vectorA.push_back(16);

    vector<int> vectorB;
    vectorB.push_back(9);
    vectorB.push_back(7);
    vectorB.push_back(4);
    vectorB.push_back(9);
    vectorB.push_back(11);


    vector<int> vectorC = append(vectorA, vectorB);

    cout << "vector A: ";
    readVec(vectorA);

    cout << "vector B: ";
    readVec(vectorB);

    cout << "vector C: ";
    readVec(vectorC);

    return 0;
}
