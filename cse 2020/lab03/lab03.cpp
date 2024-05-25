#include"Student.cpp"
#include<iostream>
#include<string>
using namespace std;
struct NodeType
{
    Student student;
    NodeType *next;

    NodeType()
    {
        
        next = nullptr;
    }
    NodeType(const Student &s)
    {
        student.set_name(s.get_name());
        student.set_id(s.get_id());
        next=nullptr;
    }
};

NodeType * team = nullptr;

void addStudent(Student s)
{
    
    if(team == nullptr)
    {
        team = new NodeType(s);
        return;
    }
    
    NodeType * cur = team;
    NodeType * temp = new NodeType(s);
    while(cur->next != nullptr)
    {
        cur = cur->next;
    }
    cur->next = temp;
}


void deleteStudent(int id)
{
    
    if (team != NULL && team->student.get_id() == id)
    {
        team = team->next;
        return;
    }
    NodeType * prev = nullptr;
    NodeType * cur = team; 
     
    while (cur != nullptr && cur->student.get_id() != id)
    {
        prev = cur;
        cur = cur->next;
    }
 
  
    if (cur == nullptr)
        return;
 
   
    prev->next = cur->next;
}


void displayStudent()
{
    NodeType * cur = team;
    while(cur != nullptr)
    {
        cur->student.print_student();   
        cur = cur->next;
    }
}

int main()
{
    
    int id;
    string name;
    
    while(1)
    {
        cout << "Enter the student id and name(0 no = exit):";
        cin >> id >> name;
        cout << "The student is added" << endl << endl;
        
        //if 0 is entered
        if(id == 0 && name == "no")
        {
            break;
        }
        
        Student s(id,name);
        addStudent(s);
    }
    cout<< endl << "The students are:" << endl;
    displayStudent();
    
    
    cout<< endl << "The student id to be removed: ";
    cin >> id;
    deleteStudent(id);
    cout << "the student is removed" << endl;
    
    cout << endl << "The students are:" << endl;
    displayStudent(); 
}
