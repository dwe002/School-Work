#define analogPin A0 //the thermistor attach to
#define beta 3950 //the beta of the thermistor
#define resistance 10 //the value of the pull-down resistor

const int buttonPin = 7; // the number of the pushbutton pin
const int ledPin = 13; // the number of the LED pin
// variables will change:
int buttonState = 0; // variable for reading the pushbutton status

void setup()
{
// initialize the LED pin as an output:
pinMode(ledPin, OUTPUT);
// initialize the pushbutton pin as an input:
pinMode(buttonPin, INPUT);
Serial.begin(9600);
}
void loop()
{
// read the state of the pushbutton value:
buttonState = digitalRead(buttonPin);
int val = analogRead(0);
// check if the pushbutton is pressed.
// if it is, the buttonState is HIGH:
if (buttonState == HIGH) {
// turn LED on:
digitalWrite(ledPin, HIGH);
}
else {
// turn LED off:
digitalWrite(ledPin, LOW);
}

  
//read thermistor value
long a = analogRead(analogPin);
//the calculating formula of temperature
float tempC = beta /(log((1025.0 * 1 * a - 10) / 100) + beta / 2980.0) - 418.0;
//float tempF = 1.8*tempC + 32.0;//convert centigrade to Fahrenheit
Serial.print("TempC: ");//print&quot; TempC: &quot;
Serial.print(tempC);//print Celsius temperature
Serial.print(" C");//print the unit
Serial.println();
//Serial.print("TempF: ");
// Serial.print(tempF);
// Serial.print(" F");
delay(200); //wait for 200 milliseconds}
}
