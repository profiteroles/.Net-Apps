#include "DHT.h"
#include "variables.h"
#include "pitches.h"

void setup() {
Serial.begin(9600);
pinMode(buttonL, INPUT);
pinMode(buttonR, INPUT);
pinMode(sensor, INPUT); //Setup temperature sensor as an output pin.
pinMode(redPin, OUTPUT);  //Setup red pin as an output pin.
pinMode(sensorLight, INPUT); // sets analog pin A1 to be an input
pinMode(bluePin, OUTPUT);
pinMode(buzzer, OUTPUT);
pinMode(ledRed, OUTPUT);
pinMode(ledGreen, OUTPUT);
pinMode(ledBlue, OUTPUT);
dht.begin(); // starts the DHT to sense the temp and Humidity
}


void loop() {
int lightA1 = analogRead(sensorLight);
float humidity = dht.readHumidity();
float celsius = dht.readTemperature();
float fahrenheit = dht.readTemperature(true);
float heatIndexF = dht.computeHeatIndex(fahrenheit, humidity);
float heatIndexC = dht.computeHeatIndex(celsius, humidity, false);

vout = analogRead(sensor);
vout = (vout * 500) / 1023;
tempc = vout;
tempf = (vout * 1.8) + 32;

String data = String(tempc) + "," + String(heatIndexC) + "," + String(humidity);

 Serial.println(data);

int btnLState = digitalRead(buttonL);
int btnRState = digitalRead(buttonR);

  if(btnLState == 0){
  maxTempAlarm();
    
}else if (btnLState == HIGH){
    noAlarm();
}

int intValue = Serial.parseInt();
//  char value = Serial.read();

  switch (intValue){
    case 90: digitalWrite(ledRed, HIGH); digitalWrite(ledBlue, LOW); digitalWrite(ledGreen, LOW); break;
    case 100: digitalWrite(ledGreen, HIGH); digitalWrite(ledRed, LOW); digitalWrite(ledBlue, LOW); break;
    case 110: digitalWrite(ledBlue, HIGH); digitalWrite(ledRed, LOW); digitalWrite(ledGreen, LOW); break;
    case 1: digitalWrite(ledGreen, LOW); digitalWrite(ledRed, LOW); digitalWrite(ledBlue, LOW); break;
    case 120: digitalWrite(redPin, HIGH); break;
    case 12: digitalWrite(redPin, LOW); break;
    case 24: if(heatIndexC > 24){ maxTempAlarm();} break;
    case 25: if(heatIndexC > 25){ maxTempAlarm();} break;
    case 26: if(heatIndexC > 26){ maxTempAlarm();} break;
    case 27: if(heatIndexC > 27){ maxTempAlarm();} break;
    case 28: if(heatIndexC > 28){ maxTempAlarm();} break;
    case 29: if(heatIndexC > 29){ maxTempAlarm();} break;
    case 30: if(heatIndexC > 30){ maxTempAlarm();} break;
    case 31: if(heatIndexC > 31){ maxTempAlarm();} break;
    case 32: if(heatIndexC > 32){ maxTempAlarm();} break;
    case 33: if(heatIndexC > 33){ maxTempAlarm();} break;
    case 34: if(heatIndexC > 34){ maxTempAlarm();} break;
    case 35: if(heatIndexC > 35){ maxTempAlarm();} break;
    case 36: if(heatIndexC > 36){ maxTempAlarm();} break;
    case 37: if(heatIndexC > 37){ maxTempAlarm();} break;
    case 38: if(heatIndexC > 38){ maxTempAlarm();} break;
  }
}

void greenLightDimmer(int brightness){
  digitalWrite(ledGreen,sensorValue);
}

void maxTempAlarm(){
  digitalWrite(bluePin,HIGH);
  tone(buzzer, 80); 
  delay(100);
//  noTone(buzzer);
//  delay(100);
}

void noAlarm(){
  digitalWrite(bluePin,LOW);
  noTone(buzzer);
}

void blinkRed() {
  for (int x = 0; x <=5; x++)
  {
    digitalWrite(redPin, HIGH);   //Turn on the red
    delay(waitTime);                  //Wait offTime.
    digitalWrite(redPin, LOW);    //Turn off the red
    delay(waitTime);                  //Wait offTime.
  }
}

void blueLight(){
    digitalWrite(bluePin, HIGH);   //Turn on the blue light
  }
