#include <Wire.h> //I2C library

#define SLAVE_ADDR 9 //defines the other arduino as the slave

const int photocellPin = A0; //photoresistor attach to A0
int sensorValue = 0; //value read from the photoresistor


void setup()
{
  Wire.begin(); //initiates I2C communication
}

void loop()
{
  delay (50); //delay 50ms
  
  //read the value of A0 and map from 1 to 255
  sensorValue = map(analogRead(photocellPin), 0, 1023, 1, 255);
  
  //transmits data to the slave arduino
  Wire.beginTransmission(SLAVE_ADDR);
  Wire.write(sensorValue);
  Wire.endTransmission();
}

