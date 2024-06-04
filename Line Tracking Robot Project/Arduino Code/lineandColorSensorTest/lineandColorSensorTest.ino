/* Line and color tracker tester
by: Chandra Prayaga Feb 16, 2014
QRE1113 line sensors from SparkFun connected to Analog pins 0 and 2
The line sensors are individual sensors*/

//Code for the QRE1113 Analog board
//Outputs via the serial terminal - Lower numbers mean more reflected light
#include <Wire.h> // Control I2C bus
#include "Adafruit_TCS34725.h" //Control color sensor
/* Initialize with default values (int time = 2.4ms, gain = 1x) */
Adafruit_TCS34725 tcs = Adafruit_TCS34725();
#define CW 0
#define CCW 1
// Motor definitions:
#define MOTOR_A 0
#define MOTOR_B 1
// Pin Assignments //
// Don’t change these! These pins are statically defined by Arduino & Ardumoto shield layout
const byte PWMA = 3; // PWM control (speed) for motor A
const byte PWMB = 11; // PWM control (speed) for motor B
const byte DIRA = 12; // Direction control for motor A
const byte DIRB = 13; // Direction control for motor B
int qreLeft = A0; //connected to Analog 2
int qreRight = A2; //connected to Analog 0
byte spd = 100; // forward speed
byte hiSpd = 120; //turning speed
int threshold = 700;

// threshold for line sensor values. Greater than this means on the line (dark)
// less than this means the sensor is off the line (light)
// This must be determined experimentally for each surface and track
void setup()
{
//setupArdumoto(); // Set up & initialize all motor drive pins
if (tcs.begin())
{
}
else
{
allStop();
while (1);
}
}



void loop()
{
uint16_t r, g, b, c, colorTemp, lux;
int QRE_Left = analogRead(qreLeft);
int QRE_Right = analogRead(qreRight);
tcs.getRawData(&r, &g, &b, &c);
if (r > 40) //if color sensor is on the bare floor
{
if (QRE_Left > threshold && QRE_Right > threshold)
{
forward();
}
else if (QRE_Left < threshold && QRE_Right > threshold)
{
bearRight();
}
else if (QRE_Left > threshold && QRE_Right < threshold)
{
bearLeft();
}
}
else //If color sensor is on the red tape marker
{
allStop();
delay(5000); //Stop as long as you want - in this case, 5 seconds
forward();
delay(100);
}
}
// driveArdumoto drives ’motor’ in direction ’dir’ at speed ’spd’
void driveArdumoto(byte motor, byte dir, byte spd)
{
if (motor == MOTOR_A)
{
digitalWrite(DIRA, dir);
analogWrite(PWMA, spd);
}
else if (motor == MOTOR_B)
{
digitalWrite(DIRB, dir);
analogWrite(PWMB, spd);
}
}
void forward() // Runs both motors at speed ’spd’
{
driveArdumoto(MOTOR_A, CW, spd); // Motor A at speed spd
driveArdumoto(MOTOR_B, CW, spd); // Motor B at speed spd
}
void bearRight()
{
driveArdumoto(MOTOR_B, CW, 0); //Motor B Stop
driveArdumoto(MOTOR_A, CW, hiSpd); //Motor A hiSpd
}
void bearLeft()
{
driveArdumoto(MOTOR_B, CW, hiSpd); //Motor B hiSpd
driveArdumoto(MOTOR_A, CW, 0); //Motor A Stop
}
// stopArdumoto makes a motor stop
void stopArdumoto(byte motor)
{
driveArdumoto(motor, 0, 0);
}
void allStop() //Stop both motors
{
stopArdumoto(MOTOR_A); // Stop motor A
// All pins should be set up as outputs:
pinMode(PWMA, OUTPUT);
pinMode(PWMB, OUTPUT);
pinMode(DIRA, OUTPUT);
pinMode(DIRB, OUTPUT);
// Initialize all pins as low:
digitalWrite(PWMA, HIGH);
digitalWrite(PWMB, HIGH);
digitalWrite(DIRA, LOW);
digitalWrite(DIRB, LOW);
}
