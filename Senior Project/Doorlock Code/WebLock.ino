/*
 ESP 32 powered door lock
 ESP32 acts as a web server to control a servo motor to turn the deadbolt
 Sparkfun ESP 32 IoT RedBoard Drivers: https://github.com/sparkfun/SparkFun_IoT_RedBoard-ESP32 
 */
#include <Wire.h> // Needed for I2C
#include <WiFi.h> // ESP 32 Defualt WiFi library
#include <Servo.h> //Needed for servo, Library link: https://github.com/jkb-git/ESP32Servo
#include <WiFiManager.h> //Needed for WiFi credential setup, Library link: https://github.com/tzapu/WiFiManager
#include <SparkFun_MAX1704x_Fuel_Gauge_Arduino_Library.h> // Needed for LiPo Battery, Library link: https://github.com/sparkfun/SparkFun_MAX1704x_Fuel_Gauge_Arduino_Library
#include <SoftwareSerial.h> // Needed for lcd 

SFE_MAX1704X lipo(MAX1704X_MAX17048); // Create a MAX17048
SoftwareSerial OpenLCD(3, 4); // RX(not used), TX, Pins used for LCD display

WiFiServer server(80); // Server port
WiFiClient client;

String header;

int servoState = 0; // Variable for the lock states of servo

Servo boltServo;

int outputPIN = 13; // Variable for servo pin
double soc = 0; // Variable for battery percentage

void setup()
{
    Serial.begin(115200); // Initialize serial monitor and buad rate
    delay(10);

    OpenLCD.begin(9600); // Begin communication with LCD and its buad rate

    lcd_on(); // Makes LCD full brightness and white

      //Send the reset command to the display - this forces the cursor to return to the beginning of the display
    OpenLCD.write('|'); //Send setting character
    OpenLCD.write('-'); //Send clear display character

    OpenLCD.write("Hello check your WiFi Settings"); // Display to LCD

    WiFiManager wifiManager;


    if (!wifiManager.autoConnect("WiFiManagerAP", "")) {
      Serial.println("failed to connect and hit timeout");
      //reset and try again
      ESP.restart();
      delay(1000);
    }


    // Initialize servo
    boltServo.attach(outputPIN);
    boltServo.write(110); // Servo rotates to degree 110

    delay(100);

    Serial.println("");
    Serial.println("WiFi connected.");
    Serial.println("IP address: ");
    Serial.println(WiFi.localIP()); // Print local IP to serial
    IPAddress myIP = WiFi.localIP(); // Display local IP to LCD
    
    server.begin(); // Initialize web server

    Wire.begin();
    lipo.enableDebugging(); //enables helpful debug messages on Serial

  // Set up the MAX17048 LiPo fuel gauge:
  if (lipo.begin() == false) // Connect to the MAX17048 using the default wire port
  {
    Serial.println(F("MAX17048 not detected. Please check wiring. Freezing."));
    while (1)
      ;
  }

  // Reset the MAX17048 fuel guage
  Serial.println(F("Resetting the MAX17048..."));
  delay(1000); // Give it time to get its act back together

  // Read and print the reset indicator to serial
  Serial.print(F("Reset Indicator was: "));
  bool RI = lipo.isReset(true); // Read the RI flag and clear it automatically if it is set
  Serial.println(RI); // Print the RI
  // If RI was set, check it is now clear
  if (RI)
  {
    Serial.print(F("Reset Indicator is now: "));
    RI = lipo.isReset(); // Read the RI flag
    Serial.println(RI); // Print the RI    
  }

  // Send the reset command to the display - this forces the cursor to return to the beginning of the display
  OpenLCD.write('|'); // Send setting character
  OpenLCD.write('-'); // Send clear display character


  OpenLCD.print(myIP); // Displays local IP to lcd display
  delay(15000);

  lcd_dim(); // Dim display and set green only
}

void loop()
{

   soc = lipo.getSOC(); // Initializes variable to battery percentage function
   OpenLCD.write('|'); // Send setting character
   OpenLCD.write('-'); // Send clear display character
  
   // Print battery percentage on LCD display
   OpenLCD.print("Battery: ");
   OpenLCD.print(soc);
   OpenLCD.print("%");
   delay(2);

 client = server.available(); // listen for incoming clients

  if (client) {                             // if you get a client,
    Serial.println("New Client.");           // print a message out the serial port
    String currentLine = "";                // make a String to hold incoming data from the client
    while (client.connected()) {            // loop while the client's connected
      if (client.available()) {             // if there's bytes to read from the client,
        char c = client.read();             // read a byte, then
        Serial.write(c);                    // print it out the serial monitor
        if (c == '\n') {                    // if the byte is a newline character

          // if the current line is blank, you got two newline characters in a row.
          // that's the end of the client HTTP request, so send a response:
          if (currentLine.length() == 0) {
            
            sendRequest();
            sendWebAppHTML();
            
            // break out of the while loop:
            break;
          } else {    // if you got a newline, then clear currentLine:
            currentLine = "";
          }
        } 
        else if (c != '\r') {  // if you got anything else but a carriage return character,
          currentLine += c;      // add it to the end of the currentLine
        }

        // Unlock deadbolt
        if(currentLine.endsWith("GET /unlock")){
          Serial.println("  Servo is now disengaged.");
          servoState = 0;
          boltServo.write(110); // Servo rotates to degree 110
        }     
        // Lock deadbolt        
        else if(currentLine.endsWith("GET /lock")){
          Serial.println("  Servo is now engaged.");
          servoState = 1;
          boltServo.write(60); // Servo rotates to degree 60
        }
      }
    }
    // Close the connection:
    client.stop();
    Serial.println("Client Disconnected.");
  }
}

// Handles the HTML request of server
void sendRequest(){
  client.println("HTTP/1.1 200 OK");
  client.println("Content-type:text/html");
  client.println("Connection: close");
  client.println();    
}

/*
  Prints out HTML for web page to the client
  Also updates the door status and button text depending on the state of the servo
*/
void sendWebAppHTML(){
  client.println("<!DOCTYPE html><html>");
  client.println("<link rel=\"icon\" href=\"data:,\">");
  client.println("<head><title>Remote Lock</title><style>.page{font-family: Arial; font-size: 2.5em; color: white; text-align: center;}");
  client.println("body{background: linear-gradient(to bottom, rgba(255,255,255,0.15) 0%, rgba(0,0,0,0.15) 100%), radial-gradient(at top center, rgba(255,255,255,0.40) 0%, rgba(0,0,0,0.40) 120%) #989898;background-blend-mode: multiply,multiply;background-attachment: fixed;}");
  client.println(".button{text-align: center;text-decoration: none;padding: 45px 65px;border-radius: 8px;border: none;font-size: 65px;font-family: Arial;color: white;}");
  client.println("a{line-height: 200px;}");
  client.println(".unlockbutton{background-color: #3DA100;}");
  client.println(".lockbutton{background-color: #F54242;}</style></head>");
  client.println("<body><div class=\"page\">");
  client.println("<h1>Remote Lock Control</h1>");

  // If else statement to read lock state of the deadbolt and the battery life to diplay onto the web server
  if(servoState == 0){
    client.println("<p>Door Status: Unlocked</p>");

    client.println("<p>Battery Level:");    
    client.println(lipo.getSOC(), 2);
    client.println("%</p>");

    client.println("<a href=\"/lock\" class=\"button lockbutton\">LOCK</a>"); // Red lock button
  }
  else{
    client.println("<p>Door Status: Locked</p>");

    client.println("<p>Battery Level:");    
    client.println(lipo.getSOC(), 2);
    client.println("%</p>");

    client.println("<a href=\"/unlock\" class=\"button unlockbutton\">UNLOCK</a>"); // Green lock button
  }

  client.println("</div></body></html>");
  client.println();

}

// Void function to dim lcd display to a dim green
void lcd_dim(void)
{
  // Set all colors to 0% brightness, save green to 7%
  OpenLCD.write('|'); // Put LCD into setting mode
  OpenLCD.write(128); // Set white/red backlight amount to 0%    

  OpenLCD.write('|'); // Put LCD into setting mode
  OpenLCD.write(158 + 2); // Set green backlight amount to 7%

  OpenLCD.write('|'); // Put LCD into setting mode
  OpenLCD.write(188 + 0); // Set blue backlight amount to 0%

  delay(1000);  
}

// Void function to enable 100% brightness of lcd display
void lcd_on(void)
{
  // Set all colors 100% brightness
  OpenLCD.write('|'); // Put LCD into setting mode
  OpenLCD.write(128 + 29); //Set white/red backlight amount to 100%    

  OpenLCD.write('|'); // Put LCD into setting mode
  OpenLCD.write(158 + 29); // Set green backlight amount to 100%

  OpenLCD.write('|'); // Put LCD into setting mode
  OpenLCD.write(188 + 29); // Set blue backlight amount to 100%

  delay(1000);  
}




