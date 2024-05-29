/* Recursive Descent Parser for the Expression Grammar:
S → aAB
A → Abc|b
B → d
Valid inputs: 
Invalid inputs:
*/
#include <stdio.h>
#include <string.h>
int S(), A(), B();
char *ip;
char string[50];

int main()
{
printf("Enter the string\n");
scanf("%s", string);
ip = string;
printf("\n\nInput\t\tAction\n ------------------------------\n");
if (S())
{
printf("\n------------------------------------------------\n");
printf("\n String is successfully parsed\n");
}
else
{
printf("\n ------------------------------------------------\n");
printf("Error in parsing string\n");
}
}

int B()
{
    if (*ip == 'd')
    {
        printf("%s\t\tB →d \n", ip);
        ip++;
        if (S())
        {
        if (B())
        {
        return 1;
    }
    else
    return 0;
    }
    else
    return 0;
}
}

int A()
{
if (*ip == 'a')
    {
        printf("%s\t\tA →Abc \n", ip);
        ip++;
        if(S())
        {
        if (A() && *ip == 'b')
        {
            ip++;
            return 1;
        }
        else
        return 0;
        }
        else
        return 0;
    }
    else if (*ip == 'b')
    {
        ip++;
        printf("%s\t\tA →b \n", ip);
        return 1;
    }
}

int S()
{
 if (*ip == 'a')
    {
        printf("%s\t\tS →aAB \n", ip);
        ip++;
        if (A() && B())
        {
            return 1;
        }
    }
    else
    return 0;
}