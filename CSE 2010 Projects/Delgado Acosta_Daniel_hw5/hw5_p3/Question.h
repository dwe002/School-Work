#ifndef QUESTION_H_INCLUDED
#define QUESTION_H_INCLUDED
#include <iostream>
#include <sstream>
#include <string>

using namespace std;

class Question
{

public:

    Question();

    virtual void set_text(string question_text);

    void set_answer(string correct_response);

    virtual bool check_answer(string response) const;

    void display() const;

protected:
    string text;
    string answer;

};


#endif // QUESTION_H_INCLUDED
