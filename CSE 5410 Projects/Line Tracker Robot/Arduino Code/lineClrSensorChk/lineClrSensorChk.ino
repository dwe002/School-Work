/* line sensor & color sensor tester
QRE1113 line sensors from SparkFun connected to Analog pins 0 and 2
The line sensors are individual sensors, used to track the main line
TCS34725 color sensor used to STOP at a point on the track
Color sensor connected to the I2C bus on the Arduino
*/

#include <Wire.h> //Library for communicating with I2C device
#include <Adafruit_TCS34725.h> //Library of commands for the color sensor
/* Initialize instance of color sensor with default values (int time = 2.4ms, gain = 1x) */
Adafruit_TCS34725 tcs = Adafruit_TCS34725();
int qreLeft = A0; //connected to Analog 0
int qreRight = A2; //connected to Analog 2
void setup(){
Serial.begin(9600);
if (tcs.begin())
{
}
else
{
Serial.println("Give it up!");
while (1);
}
}
void loop(){
uint16_t r, g, b, c, colorTemp, lux; //Declare output variables for color sensor
int QRE_Left = analogRead(qreLeft); //Output of left IR sensor
int QRE_Right = analogRead(qreRight); // Output of right IR sensor
tcs.getRawData(&r, &g, &b, &c); // Read the color sensor outputs
//Print values to the serial monitor
Serial.print("R: "); Serial.print(r); Serial.print(" G: "); Serial.print(g);
Serial.print(" B: "); Serial.print(b); Serial.print(" C: "); Serial.println(c);
Serial.print(" left: "); Serial.print(QRE_Left);
Serial.print(" right: "); Serial.println(QRE_Right);
Serial.println("");
delay(2000);
}
