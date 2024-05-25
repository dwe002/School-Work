#include<iostream>
#include "Set.cpp"
using namespace std;

 
template < typename C > 
void print (const Set < C > &s) 
{
  
// ADD YOUR CODE
for(typename Set<C>::iterator itr = s.begin(); itr != s.end(); ++itr)
cout << *itr << ",";

} 
 
template < typename C > 
Set < C > operator+ (const Set < C > &s1, const Set < C > &s2) 
{
  
Set < C > result;
  
// ADD YOUR CODE
for(typename Set<C>::iterator itr = s1.begin(); itr != s1.end(); ++itr)
    result.insert(*itr);
for(typename Set<C>::iterator itr = s2.begin(); itr != s2.end(); ++itr)
    result.insert(*itr);


    return result;

}

 
template < typename C > 
Set < C > operator- (const Set < C > &s1, const Set < C > &s2) 
{
  
Set < C > result;
  
// ADD YOUR CODE
for(typename Set<C>::iterator itr = s1.begin(); itr != s1.end(); ++itr)
    result.insert(*itr);
for(typename Set<C>::iterator itr = s2.begin(); itr != s2.end(); ++itr)
    result.insert(*itr);

return result;
} 
 
 
template < typename C > 
Set < C > operator* (const Set < C > &s1,
						     const Set < C > &s2) 
{
  
Set < C > result;
// ADD YOUR CODE return result;
for (typename Set<C>::iterator itr = s1.begin(); itr != s1.end(); ++itr)
if(s2.contains(*itr))
result.insert(*itr);

return result;
} 
 
 
 
int main () 
 
{
    
    Set<int>setA;
    Set<int>setB;
    int x;
    
    cout << "insert the values to SetA (stop when entering 0): " << endl;
    cin >> x;
    while (x != 0)
    {
    setA.insert(x);
    cin >> x;
    }
    cout << "print the values: " << endl;
    print (setA);
    cout << endl<<endl;
    
    cout<< "insert the values to SetB (stop when entering 0): " << endl;
    cin >> x;
    while (x != 0)
    {
        setB.insert(x);
        cin >> x;
    }
    
    cout << "print the values: " << endl;
    print(setB);
    cout << endl << endl;
    
    
    Set<int> theUnion = setA + setB;
    cout << "The unuion of two sets: ";
    print(theUnion);
    cout << endl;
    
    Set<int> theDifference = setA - setB;
    cout << "The difference of two sets: ";
    print(theDifference);
    cout << endl;
    
    Set<int> theIntersection = (setA + setB) - (setA - setB);
    cout << "The intersection of two sets: ";
    print(theIntersection);
    cout << endl << endl;
    
    
    
    Set<string>setS;
    Set<string>setT;
    string s;
    
    cout << "insert the values to SetS (stop when entering exit): " << endl;
    cin >> s;
    while (s != "exit")
    {
    setS.insert(s);
    cin >> s;
    }
    cout << "print the values: " << endl;
    print (setS);
    cout << endl << endl;
    
    cout<< "insert the values to SetT (stop when entering exit): " << endl;
    cin >> s;
    while (s != "exit")
    {
        setT.insert(s);
        cin >> s;
    }
    
    cout << "print the values: " << endl;
    print(setT);
    cout << endl << endl;
    
    
    Set<string> theStrUnion = setS + setT;
    cout << "The union of two sets: ";
    print(theStrUnion);
    cout << endl;
    
    Set<string> theStrDifference = setS - setT;
    cout << "The difference of the two sets: ";
    print(theStrDifference);
    cout << endl;
    
     Set<string> theStrIntersection = (setS + setT) - (setS - setT);
    cout << "The intersection of two sets: ";
    print(theStrIntersection);
    cout << endl << endl;
}