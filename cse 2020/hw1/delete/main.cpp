#include <iostream>

using namespace std;

int
main ()
{
 int result = 0;
for (int i = 0; i <= 10; i++)
{
int temp = 1;

for (int j = 0; j < i; j++)
{
temp= temp* 2;
}
result = result + temp;
}

cout << result;
}
