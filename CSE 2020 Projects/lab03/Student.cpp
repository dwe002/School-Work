#ifndef STUDENT_H
#define STUDENT_H
#include<string>
#include<iostream>
using namespace std;

class Student
{
    public:
    //Default Constructor
    Student()
    {

    }
    //copy constructor
    Student(Student & s)
    {
        name = s.name;
        id = s.id;
    }
    //creates a student with the specified id and name
    Student(int idvalue, const string& namevalue)
    {
        id = idvalue;
        name = namevalue;
    }
    //Returns the student name
    string get_name() const 
    {
        return name;
    }
    //Returns the student id
    int get_id() const
    {
        return id;
    }
    //Sets the student name
    void set_name(const string & namevalue)
    {
        name = namevalue;
    }
    //Sets the student id
    void set_id(int idvalue)
    {
        id = idvalue;
    }
    //Prints the student id and name
    void print_student() const
    {
        cout<< id << " " << name <<endl;
    }
    private:
    //student name
    string name;
    //student id
    int id;
};

#endif