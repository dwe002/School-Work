const int analogPin = 0; //potetentiometer attatched to pin A0
const int ledPin = 9; //led attatched to pin 9
int inputValue = 0; //stores the value coming from potetentiometer 
int outputValue = 0; //store the output value

void setup() 
{ 
  Serial.begin(9600);//sets baudrate to 9600
}
void loop() 
{ 
  inputValue = analogRead(analogPin); //reads the value from the potentiometer
  Serial.print("Input: "); //print Input
  Serial.println(inputValue); //print inputValue
  outputValue = map(inputValue, 0, 1024, 0, 255); //Converts 0-1024 to a proportional number from 0 to 255
  Serial.print("Output: "); //print Output
  Serial.println(outputValue); //print outputValue 
  analogWrite(ledPin, outputValue); //turn the LED on depending on the output value
  delay(1000); //delay by a second
}
