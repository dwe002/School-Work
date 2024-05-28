#ifndef STACK_H
#define STACK_H
#include<iostream>
using namespace std;

 
template <typename T> 
class Stack 
{

 
public:
Stack () 
  {
    
topOfStack = -1;
    
items = new T[CAPACITY];
  
}
  
 
    // Destructor
    ~Stack () 
    {
    topOfStack = -1;
 
    delete items;
    }
  
 
    //Checks if stack is empty or not.
  bool empty ()const 
  {
    if (topOfStack == -1)
    
    return true;
    return false;
    
  }
   

    // Makes the stack to the empty state.
  void make_empty () 
  {
  }
  
    // Insert item in the stack.
  void push (const T & item) 
  {
if (topOfStack == CAPACITY - 1)
    
    return;
    items[++topOfStack] = item;
    
}
  
 
//Return the top element.
  const T& top() const 
  {
return items[topOfStack];
}


// Removes the top element.
  void pop () 
  {
if (empty())	
    
      return;
    
    topOfStack--;
    
}
  
static const int CAPACITY = 50;
 
private:
 
int topOfStack;// -1 for empty stack
  T* items;

};
 
#endif