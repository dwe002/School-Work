#ifndef FILLINQUESTION_H
#define FILLINQUESTION_H
#include "../Question.h"

#include <iostream>
#include <sstream>
#include <string>

using namespace std;

class FillInQuestion : public Question
{
    public:
        void set_text(string question_text);
        bool check_answer(string response) const;



};

#endif // FILLINQUESTION_H
