#ifndef STUDENT_H
#define STUDENT_H

#include <string>
#include <iostream>

class Student
{
    

#endif
    
    
public:
Student();
Student(int id, const string& name);
string get_name() const;
int get_id() const;
void set_name(const string& name);
void set_id(int id);
void print_student() const;
 
 private:
  // student name;
  string name;

  // student id
  int id;
};

#endif


	// Default constructor  
	Student::Student()  
	{
	name = "";
	id = 0;
	}

	// Creates a student with the specified id and name.
	Student::Student(int id, const string& name)
	{
	set_id(id);
	set_name(name);
	}
	
	
	string Student::get_name() const{
	    return name;}
	int Student::get_id() const{
	    return id;}
	void Student::set_name(const string& name){
	    this->name = name;}
	void Student::set_id(int id){
	    this->id=id;
	}
	void Student::print_student() const{
	    cout<<id<<" "<<name<<endl;}
	
	
	
	
	

