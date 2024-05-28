#include "LinkedList.h"

using namespace std;


template<typename T>
LinkedList<T>::LinkedList()
{
    head = nullptr;
    size = 0;
}


template<typename T>
int LinkedList<T>::get_size()
{
    return size;
}


template<typename T>
void LinkedList<T>::insert_front(T item)
{
    NodeType *newNode = new NodeType;
    newNode->data = item;
    newNode->next = nullptr;
    if(size == 0)
    {
        head = newNode;
    }
    else
    {
        newNode->next = head;
        head = newNode;
    }
    size++;
}


template<typename T>
void LinkedList<T>::remove_front()
{
    if(head == nullptr)
        return;
    
    size--;
    if(size == 1)
    {
        delete head;
        head = nullptr;
        return;
    }
    NodeType *ptr = head;
    head = head->next;
    delete ptr;
}


template<typename T>
void LinkedList<T>::remove(T item)
{
    NodeType *pre = nullptr;
    NodeType *cur = head;
    
    while(cur != nullptr && cur->data != item)
    {
        pre = cur;
        cur = cur->next;
    }
    
    if(cur == nullptr)
    {
        cout<<item<<" not found in the list"<<endl;
        return;
    }
    
    if(cur == head)
        head = head->next;
    else
        pre->next = cur->next;
    delete cur;
    size--;
}


template<typename T>
bool LinkedList<T>::find(T item)
{
    NodeType *ptr = head;
    while(ptr != nullptr && ptr->data != item)
        ptr = ptr->next;
    
    if(ptr == nullptr)
        return false;
    
    return true;
}


template<typename T>
void LinkedList<T>::print() const
{
    NodeType *ptr = head;
    while(ptr != nullptr)
    {
        cout<<ptr->data<<" ";
        ptr = ptr->next;
    }
}


template<typename T>
LinkedList<T>::~LinkedList()
{

}


template<typename T>
void LinkedList<T>::make_empty()
{
    while(size != 0)
        remove_front();
}
