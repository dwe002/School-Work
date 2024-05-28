const int redPin = 7; //pin attatched to red led
const int yellowPin = 6; //pin attatched to yellow led
const int greenPin = 5; //pin attatched to green led

String colorInput = ""; //initialize input for color string


void setup()
{
pinMode(redPin,OUTPUT); //initialize the redPin as output
pinMode(yellowPin, OUTPUT); //initialize the yellowPin as output
pinMode(greenPin, OUTPUT); //initialize the greenPin as output

  
Serial.begin(9600); //start serial port at 9600 bps:
Serial.println("Input LED color to light up: "); //print and take input on serial monitor

}


void loop()
{
//take and read colorInput string
if(Serial.available() > 0) //checks if data has been sent
{
colorInput = "";

while (Serial.available() > 0) //while data is sent
{
colorInput += char(Serial.read()); //concatenate each cahracter of user input
delay(2); //delay by 2ms

}
Serial.println(colorInput); //prints colorInput string

}

if(colorInput == "red") //if input is red
{
digitalWrite(redPin, HIGH);//turn the red led on
digitalWrite(yellowPin, LOW);//turn the yellow led off
digitalWrite(greenPin, LOW);//turn the green led off

}

else if(colorInput == "yellow") //if input is yellow
{
digitalWrite(redPin, LOW);//turn the red led off
digitalWrite(yellowPin, HIGH);//turn the yellow led on
digitalWrite(greenPin, LOW);//turn the green led off

}

else if(colorInput == "green") //if input is green
{
digitalWrite(redPin, LOW);//turn the red led off
digitalWrite(yellowPin, LOW);//turn the yellow led off
digitalWrite(greenPin, HIGH);//turn the green led on

}

else
{
digitalWrite(redPin, LOW);//turn the red led off
digitalWrite(yellowPin, LOW);//turn the yellow led off
digitalWrite(greenPin, LOW);//turn the green led off

}

}
