const int keyPin = 12; //the number of the key pin
const int ledPin = 13;//the number of the led pin

void setup()
{
pinMode(keyPin,INPUT);//initialize the key pin as input 
pinMode(ledPin,OUTPUT);//initialize the led pin as output
}

void loop()
{
  //checks for input and produces output
  if(digitalRead(keyPin) ==HIGH )//if button is pressed
  {
digitalWrite(ledPin,HIGH);//turn on the led
  }
  else //if button is not pressed
  {
digitalWrite(ledPin,LOW);//turn off the led
  }
}
