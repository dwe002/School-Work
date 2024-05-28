#ifndef STUDENT_H
#define STUDENT_H

#include <string>
#include <iostream>

class Student
{
public:
	// Default constructor  
	Student()  
	{
	name = "";
	id = 0;
	}

	// Creates a student with the specified id and name.
	Student(int idvalue, const string& namevale)
	{
	this -> id = id;
	this -> name = name;
	}

	// Returns the student name. 
	string get_name() const
	{
	  return name;
	}

	// Returns the student id.
	int get_id() const
	{
	  return id;
	}

	// Sets the student name.
	void set_name(const string& namevalue)
	{
	this -> name = name;
	}

	// Sets the student id.
	void set_id(int idvalue)
	{
	this -> id = id;
	}

	// Prints the student id and name.
	void print_student() const
	{
	cout << id << " " << name << endl;
	}

private:
  // student name;
  string name;

  // student id
  int id;
};

#endif
