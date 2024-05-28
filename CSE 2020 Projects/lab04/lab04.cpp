#include <iostream>
#include <ctime>
#include <cstdlib>
#include <chrono>

using namespace std;

 long long int geom_suml (int x, int n);

 long long int geom_sum2 (int x, int n);

int main()
{
        unsigned int x = 1;
        unsigned int n = 1;

        cout << "Please enter x: ";
        cin >> x;

        cout << "Please enter n: ";
        cin >> n;

        using clock = chrono::steady_clock;

        clock::time_point start = clock::now();

        cout << geom_suml(x, n) << endl;

        clock::time_point end = clock::now();
           
        clock::duration time_span = end - start;
        double nseconds = double(time_span.count()) * clock::period::num / clock::period::den;
        cout << "The execution time is : " << nseconds << endl;

        start = clock::now();

        cout << geom_sum2(x, n) << endl;

        end = clock::now();

        time_span = end - start;
        nseconds = double(time_span.count()) * clock::period::num / clock::period::den;
        cout << "The execution time is : " << nseconds << endl;

        return 0;
}


long long int geom_suml (int x, int n)
    {
        long long int result = 0;

        for(int i=0; i<=n; i++)
        {
                long long int xpow = 1;
                for(int j = 0; j < i; j++)
                
                        xpow = xpow * x; 

                result = result + xpow;
        }

        return result;
    }


 long long int geom_sum2 (int x, int n)
    {
         long long int result = 0;

        for(int i = 0; i <= n; i++)
        {
                result = result * x + 1;
        }

        return result;
}

