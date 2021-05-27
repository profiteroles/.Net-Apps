#include "DHT.h"
#include "variables.h"
#include "pitches.h"

void setup() {
Serial.begin(9600);
pinMode(sensor, INPUT); //Setup temperature sensor as an output pin.
pinMode(redPin, OUTPUT);  //Setup red pin as an output pin.
pinMode(bluePin, OUTPUT);
pinMode(buzzer, OUTPUT);
pinMode(buttonL, INPUT);
pinMode(buttonR, INPUT);
pinMode(ledRed, OUTPUT);
pinMode(ledGreen, OUTPUT);
pinMode(ledBlue, OUTPUT);
dht.begin(); // starts the DHT to sense the temp and Humidity
}


void loop() {
  
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


// if(tempc > hot){
//  blinkRed();
// }
//
// if(humidity > 65){
//  blinkBlue();
//  }
//int btnLState = digitalRead(buttonL);
//
//  if(btnLState == HIGH){
//    digitalWrite(ledGreen, LOW);
//    digitalWrite(bluePin, LOW);
//  }else{
//    digitalWrite(ledGreen, HIGH);
//    digitalWrite(bluePin, HIGH);
//  }

  
//  if(Serial.available()){
//     
//    greenLightDimmer(Serial.read());
//    
//  }

  int val = Serial.parseInt();
  if (val == 100){
    
      digitalWrite(ledGreen, HIGH);
      digitalWrite(ledRed, LOW);
      digitalWrite(ledBlue, LOW); 
  }
    else if (val == 90) {
      digitalWrite(ledRed, HIGH);
      digitalWrite(ledBlue, LOW);
      digitalWrite(ledGreen, LOW);
    }
    else if (val == 110)
    {digitalWrite(ledBlue, HIGH); 
    digitalWrite(ledRed, LOW);
    digitalWrite(ledGreen, LOW);
    }
    else if (val == 120)
    {
    digitalWrite(redPin, HIGH);
    }
    else if (val == 12){
      digitalWrite(redPin, LOW);
    
    }
    else if (val == 1) 
    {digitalWrite(ledGreen, LOW);
    digitalWrite(ledRed, LOW);
    digitalWrite(ledBlue, LOW); 
    }
  }


void greenLightDimmer(byte brightness){
  analogWrite(ledGreen,brightness);
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

void blinkBlue(){
for(int i = 0; i <= 5; i++){
    digitalWrite(bluePin, HIGH);   //Turn on the red
    delay(waitTime);                  //Wait offTime.
    digitalWrite(bluePin, LOW);    //Turn off the red
    delay(waitTime);                  //Wait offTime.
  }
}
