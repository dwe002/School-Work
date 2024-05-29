#include <Servo.h>

Servo myservo;//create servo object to control a servo
/************************************************/
void setup()
{
  myservo.attach(9);//attachs the servo on pin 9 to servo object
  myservo.write(0);//back to 0 degrees
  delay(1500);//wait for 1.5 seconds
}
/*************************************************/
void loop()
{
  myservo.write(30);//goes to 30 degrees
  delay(1500);//wait for 1.5 seconds
  myservo.write(60);//goes to 60 degrees
  delay(1500);//wait for 1.5 seconds
  myservo.write(90);//goes to 90 degrees
  delay(1500);//wait for 1.5 seconds
  myservo.write(60);//back to 60 degrees
  delay(1500);//wait for 1.5 seconds
  myservo.write(30);//back to 30 degrees
  delay(1500);//wait for 1.5 seconds
  myservo.write(0);//back to 0 degrees
  delay(1500);//wait for a 1.5 seconds
}
/**************************************************/
