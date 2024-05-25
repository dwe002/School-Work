int in1 = 9; // attatches digital pin 9 to 2A motor chip
int in2 = 10; // attatches digital pin 10 to 1A motor chip

void setup()
{
  pinMode(in1, OUTPUT); //initialize the terminal 1 of mottor pin as output 
  pinMode(in2, OUTPUT); //initialize the terminal 2 of mottor pin as output
}

void loop() 
{
  //spin dc motor clockwise
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  delay(3000); //wait 3 seconds
  
  //spin dc motor counterclockwise
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
  delay(3000); //wait 3 seconds
}