#include <avr/pgmspace.h>

#define LED 13

// string array in program memory
const char string_Off[] PROGMEM = "Off";   
const char string_On[] PROGMEM = "On";
const char* const onOff[] PROGMEM = {string_Off, string_On};

// Help
const char string_0[] PROGMEM = "0 - Reset system";
const char string_1[] PROGMEM = "1 - Set pin 1 On";
const char string_2[] PROGMEM = "2 - Set pin 2 On";
const char string_B[] PROGMEM = "B - Brief mode";
const char string_V[] PROGMEM = "V - Verbose mode";
const char string_H[] PROGMEM = "H - Print this help";
const char* const help[] PROGMEM = {string_0, string_1, string_2, string_B, string_V, string_H};

// other variables;
bool brief = false;
float volt = 0;
char cmd[1];
bool error;

void setup() {
  // put your setup code here, to run once:
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(LED, OUTPUT);
  reset();
  
  // Serial init
  Serial.begin(9600);
  Serial.println(F("Ohm test v.2"));
  Serial.println(F("copyright (c) 2016 Roberto Ceccarelli - CasaSoft"));
  writeStatus();
}

void loop() {
  // put your main code here, to run repeatedly:

  while (Serial.available() > 0) {
    if(Serial.readBytes(cmd, 1) > 0) {
      error = false;
      switch(cmd[0]) {
        case '1':
          enable(2);
          break;
          
        case '2':
          enable(3);
          break;
          
        case '0':
          reset();
          break;
  
        case 'B':
          brief = true;
          break;   
    
        case 'V':
          brief = false;
          break; 

        case 'H':
          writeHelp();
          break;

        default:
          error = true;
          break;
      }

      if(error) {  
        Serial.println(F("Unknown command. Press 'H' for help."));
      }
      else {
        volt = analogRead(A0) / 1024.0 * 5.0;
        if(!brief) {
          writeStatus();
          Serial.print(F("Volt: "));   
        }
        Serial.println(volt);
      }
    }
  }   
}

// emulate tristate logic
void setTriState(int pin) {
  pinMode(pin, OUTPUT);
  digitalWrite(pin, LOW);
  pinMode(pin, INPUT);
  digitalWrite(pin+2, LOW);
}

// output 5V to the pin
void enable(int pin) {
  pinMode(pin, OUTPUT);
  digitalWrite(pin, HIGH); 
  digitalWrite(LED, HIGH);
  digitalWrite(pin+2, HIGH);
}

// reset pin status
void reset() {
  setTriState(2);
  setTriState(3);
  digitalWrite(LED, LOW);  
}

// get pin status
bool pinStatus(int pin) {
  return  DDRD & _BV(pin);
}

// write alpha status to serial
void writePinStatus(int pin) {
  char buffer[4];
  strcpy_P(buffer, (char*)pgm_read_word(&(onOff[pinStatus(pin) ? 1 : 0]))); // Necessary casts and dereferencing.
  Serial.print(buffer);
}

// write status to serial
void writeStatus() {
  Serial.print(F("\nPin 1: "));
  writePinStatus(2);
  Serial.print(F(", "));
  Serial.print(F("Pin 2: "));
  writePinStatus(3);
  Serial.println("");
}

// write help
void writeHelp() {
    char buffer[30];
    Serial.println(F("\nAvailable commands:"));
    for(int i=0; i <6; i++) {
      strcpy_P(buffer, (char*)pgm_read_word(&(help[i]))); // Necessary casts and dereferencing.
      Serial.println(buffer);
    }
}

