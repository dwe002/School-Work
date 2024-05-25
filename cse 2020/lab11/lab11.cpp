#include <iostream>
#include <bits/stdc++.h> 
using namespace std;
map<int,string> mp; 
void printMap()
{
    cout<< endl << "Content of student database: "<<endl;
    for (auto itr = mp.begin(); itr != mp.end(); ++itr) {
        cout << itr->first
             << ':' << itr->second << '\n';
    }
}
void getName()
{
    int id; 
    cout << endl << "Who you want to know? ";
    cin >> id;
    cout << "The corresponding name is: "<< mp[id]<< endl << endl;
} 

void changeName()
{
    int id;
    string name;
    cout << "Change which one? ";
    cin >> id;
    cout << "...to what name? ";
    cin >> name;
    mp[id] = name;
    cout << endl;
}
void RemoveID()
{
    int id;
    cout << endl << "Remove which one? ";
    cout << endl;
    cin >> id;
    mp.erase(id);
}
int main()
{
    cout << "using index operator to insert new pairs: " << endl;
    int n,i;
    int id;
    char name[25];
    while(1)
    {
        printf("Student ID? ");
        scanf("%d", &id);
        if(id == 0)
        break;
        printf("Student Name? ");
        scanf("%s",name);
        mp[id] = name;
        cout << endl;
    }
    printMap();
    getName();
    changeName();
    printMap();
    RemoveID();
    printMap();
    return 0;
}