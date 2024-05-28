#include <iostream>
#include <string>
#include <vector>

using namespace std;



    vector<string> decompose(string address)
    {

        string city = "";
        string state = "";
        string zip = "";

        city = address.substr(0, address.find(","));
        address.erase(0, address.find(",") + 2);

        zip = address.substr(address.size() - 5, 5);
        address.erase(address.size() - 6, 6);
        state = address;

        vector<string> ss;
        ss.push_back(city);
        ss.push_back(state);
        ss.push_back(zip);

        return ss;
    }



int main()
{
    string test = "Ann Arbor, Michigan 48109";
    vector<string> output = decompose(test);

    for (int i = 0; i < output.size(); i++)
    {
        cout << output[i] << endl;
    }
    return 0;
}
