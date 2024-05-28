
#include "Question.h"
#include "FillInQuestion.h"
#include <iostream>
#include <string>


using namespace std;

int main()
{
    string response;

    cout << boolalpha;

    Question q1;

    q1.set_text("Who was the inventor of C++?");
    q1.set_answer("Bjarne Stroustrup");

    q1.display();

    cout << "Your answer: ";
    getline(cin, response);

    cout << q1.check_answer(response) << endl << endl;



     FillInQuestion q2;

    q2.set_text("The owner of Microsoft is");
    q2.set_answer("Bill Gates");

    q2.display();

    cout << "Your answer : ";
    getline(cin, response);

    cout << q2.check_answer(response) << endl << endl;

    return 0;
}
