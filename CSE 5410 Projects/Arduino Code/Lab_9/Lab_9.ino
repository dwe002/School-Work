const int xPin = A0;
const int yPin = A1;
const int swPin = 8;
void setup()
{
pinMode(swPin,INPUT);
digitalWrite(swPin, HIGH);
pinMode(13, OUTPUT);
Serial.begin(9600);
}
void loop()
{
Serial.print("X: ");
Serial.print(analogRead(xPin),DEC);
Serial.print("|Y: ");
Serial.print(analogRead(yPin),DEC);
Serial.print("|Z: ");
Serial.println(digitalRead(swPin)); 

if (digitalRead(swPin) == 1)
{
  digitalWrite(13, HIGH);
}
else if (digitalRead(swPin) == 0)
{
  digitalWrite(13, LOW);
}

delay(500);
}
