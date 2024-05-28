const int sensor = A1; // assigns termperature sensor to analog pin A1

float temp; // stores temperature in Celsius
float output; // temporary variable to hold sensor reading


void setup() 
{
pinMode(sensor,INPUT); // makes sensor pin as input

Serial.begin(9600); // sets buadrate to 9600
}


void loop() 
{
output = analogRead(sensor); //Reads value from sensor

output = ((output * 1024) / 6266);

temp = output; // Storing value in Degree Celsius

// prints temperature read on serial monitor every second  
Serial.print("Degree Celsius: ");

Serial.print(temp);

Serial.println();

delay(1000); //Delay 1 second
}