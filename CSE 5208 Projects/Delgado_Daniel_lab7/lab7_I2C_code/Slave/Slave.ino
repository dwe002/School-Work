#include <Servo.h> //servo library
#include <Wire.h> //I2C library

#define SLAVE_ADDR 9 //defines slave address

//initialized variables
int receivedData; 
int pos = 0;

Servo servo_9; //attatches servo to pin 9 on slave


void setup()
{
  //servo initialization
  servo_9.attach(9, 500, 2500);
  servo_9.write(0);
  
  //intiates communication with master
  Wire.begin(SLAVE_ADDR);
  Wire.onReceive(receiveEvent);
  
  Serial.begin(9600); //sets buad rate to 9600
  
}

//recieves data from master through receivedData variable
void receiveEvent(int sensitivity)
{
  receivedData = Wire.read();
  Serial.println(receivedData);
}

  
void loop()
{
  //rotates servo according to the light sensitivity
  delay(50);
  
  if (receivedData <= 50)
  {
  servo_9.write(30);
  }
  
  else if (receivedData <= 155)
  {
  servo_9.write(60);
  }
  
  else if (receivedData <= 205)
  {
  servo_9.write(90);
  }
  
  else if (receivedData <= 235)
  {
  servo_9.write(120);
  }
  
  else if (receivedData >= 236)
  {
  servo_9.write(150);
  }
}