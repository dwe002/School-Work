/* Recursive Descent Parser for the Expression Grammar:
S → (L) |a
L' →,SL'|ε
L → SL'
Valid inputs: (a,(a,a)) and (a,((a,a),(a,a)))
Invalid inputs:(aa,a)
*/
#include <stdio.h>
#include <string.h>
int S(), Ldash(), L();
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
int L()
{
printf("%s\t\tL →SL' \n", ip);
if (S())
{
if (Ldash())
{
return 1;
}
else
return 0;
}
else
return 0;
}
int Ldash()
{
if (*ip == ',')
{
printf("%s\t\tL' →, SL' \n", ip);
ip++;
if (S())
{
if (Ldash())
{
return 1;
}
else
return 0;
}
else
return 0;
}
else
{
printf("%s\t\tL' →ε \n", ip);
return 1;
}
}
int S()
{
if (*ip == '(')
{
printf("%s\t\tS →(L) \n", ip);
ip++;
if (L())
{
if (*ip == ')')
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
else if (*ip == 'a')
{
ip++;
printf("%s\t\tS →a \n", ip);
return 1;
}
else
return 0;
}
