/* lineSensorChk
Two QRE1113 Analog line sensors from SparkFun connected to Analog pins 0 and 2
Outputs to the serial monitor - Lower numbers mean light surface, more light reflected
*/

int qreLeft = A0; //Left sensor OUT pin connected to Analog Pin 0 of Arduino
int qreRight = A2; //Right sensor OUT pin connected to Analog Pin 2 of Arduino
void setup()
{
Serial.begin(9600); // Start the serial monitor
}
void loop()
{
int QRE_Left = analogRead(qreLeft); //Read the output value from the left sensor
int QRE_Right = analogRead(qreRight); // Read the output value from the right sensor
Serial.print("left: "); // Start printing the values to the serial monitor
Serial.print(QRE_Left);
Serial.print(" right: ");
Serial.println(QRE_Right);
delay(2000);
}
