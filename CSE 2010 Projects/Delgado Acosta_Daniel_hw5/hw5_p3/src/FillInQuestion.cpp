#include "FillInQuestion.h"
#include <iostream>
#include <sstream>
#include <string>
#include <locale>

using namespace std;

void FillInQuestion::set_text(string question_text)
{
    text = question_text += " ____.";

}

bool FillInQuestion::check_answer(string response) const
{

    locale loc;
    string lowercaseCorrectAns = "";
    string lowercaseUserAns = "";


    for (int i=0; i < answer.size(); i++)
    {
        if(answer[i] != ' ')
            lowercaseCorrectAns += tolower(answer[i], loc);
    }

    for (int i=0; i < response.size(); i++)
    {
        if(response[i] != ' ')
            lowercaseUserAns += tolower(response[i], loc);
    }

if (lowercaseCorrectAns == lowercaseUserAns)
    return true;

else
    return false;


}


