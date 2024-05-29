#include<string.h>
#include<ctype.h>
#include<stdio.h>
void keyword(char str[10])
{
if(strcmp("for",str)==0||strcmp("while",str)==0||strcmp("do",str)==0||strcmp("int",str)==0||strcmp("float",str)==0||strcmp("char",str)==0||strcmp("double",str)==0||strcmp("static",str)==0||strcmp("switch",str)==0||strcmp("case",str)==0)
printf("\n%s is a keyword",str);
else
printf("\n%s is an identifier",str);
}

void relational(char str[]) //relational void function
{
}

main() //changed to "int main"
{
FILE *f1,*f2,*f3, *f4; //included *f4

char c, str[10], st1[10];
int num[100], lineno=0, tokenvalue=0,i=0,j=0,k=0, cnt; //included variable "cnt"
printf("\n\n Enter the input in the program. Input at least 3 lines by pressing Enter at the end of each line. When done,press CTRL+D: ");/*gets(st1);*/
f1=fopen("input","w");
while((c=getchar())!=EOF)
putc(c,f1);
fclose(f1);
f1=fopen("input","r");
f2=fopen("identifier","w");
f3=fopen("specialchar","w");
f4=fopen("relational","w"); //open f4 file

while((c=getc(f1))!=EOF)
{
if(isdigit(c))
{
tokenvalue=c-'0';
c=getc(f1);
while(isdigit(c))
{
tokenvalue*=10+c-'0';
c=getc(f1);
}
num[i++]=tokenvalue;
ungetc(c,f1);
}
else
if(isalpha(c))
{
putc(c,f2);
c=getc(f1);
while(isdigit(c)||isalpha(c)||c=='_'||c=='$')
{
putc(c,f2);
c=getc(f1);
}
putc(' ',f2);
ungetc(c,f1);
}
else
if(c==' '||c=='\t')
printf(" ");
else
if(c=='\n')
lineno++;

else if(c=='>'||c=='<'||c=='=')//check for relational operator(s)
putc(c,f4);
else
putc(c,f3);
}
fclose(f2);
fclose(f3);
fclose(f1);
fclose(f4); //close relational

printf("\n\n The no's in the program are :");
for(j=0; j<i; j++)
printf("%d", num[j]);
printf("\n\n");
f2=fopen("identifier", "r");
k=0;
printf("The keywords and identifiers are:");
while((c=getc(f2))!=EOF)
{
if(c!=' ')
str[k++]=c;
else
{
str[k]='\0';
keyword(str);
k=0;
}
}
fclose(f2);
f3=fopen("specialchar","r");
printf("\n\n Special characters are : ");
while((c=getc(f3))!=EOF)
printf("%c",c);
printf("\n\n");
fclose(f3);
printf("Total no. of lines are:%d", lineno);

// relational operator(s) check
f4=fopen("relational","r");
printf("\n\n Relational Operator(s)  are: ");
c=fgetc(f4);
//storing relational operator(s) in string
cnt=0;
while(c!=EOF)
{
    str[cnt]=c;
    c=fgetc(f4);
    cnt++;
}
str[cnt]=NULL;
for(i=0;i<cnt-1;i++)
{
if(str[i]=='>') //check for ">"
if(str[i+1]=='=' && str[i+2]!='=') //check for ">="
{ printf(">= ");
i++;
}
else
printf("> ");
else
if(str[i]=='<') //check for "<""
if(str[i+1]=='=' && str[i+2]!='=')//check for "<=""
{
printf("<= ");
i++;
}
else
printf("< ");
else
if(str[i]=='='&& str[i+1]=='=')//check for "=="
{
printf("== ");
i++;
}
else
if(str[i]=='!' && str[i+1]=='=')//check for "!="
{
printf(" <> ");
i++;
}
}
printf("\n");
fclose(f4);
}
