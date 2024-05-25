#ifndef LL_H
#define LL_H

#include<iostream>
#include<string>
  
using namespace std;

 
template < typename T > 
class LinkedList 
{

private:
struct NodeType 
  {
    
T data;
    
NodeType * next;
  
};
  
NodeType * head;
  
int size; //Size of the list
public:
    //Constructor
    LinkedList ();
  
 
    //Destructor
    ~LinkedList ();
  
 
    //Make list empty
  void make_empty ();
  
 
    //Return size
  int get_size ();
  
 
    //Chek if item is in list or not
    bool find (T item);
  
 
    //Insert in front of list
  void insert_front (T item);
  
 
    //Remove from front of list
  void remove_front ();
  
 
    //Remove item from list
  void remove (T item);
  
 
    //Prints the list
  void print () const;

};


 
#endif