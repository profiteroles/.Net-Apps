#include "pitches.h"

int DHT11Pin = 4;
DHT dht(DHT11Pin, DHT11);
const int rotator = A0; // Assigning rotator A1 to variable
const int sensorLight = A1; // Assigning sensorlight A1 to variable
const int sensor = A2; // Assigning analog pin A2 to variable 'sensor'
float tempc; //variable to store temperature in degree Celsius
float tempf; //variable to store temperature in Fahreinheit
float vout; //temporary variable to hold sensor reading
int hot = 25; // Hot temperature
int waitTime = 500; //wait time between the blinks
int delayTime = 1000; // delay time between data sensor
int bluePin = 13;//The Blue is connected pin 13 of the Arduino.
int redPin = 12; //The red is connected pin 12 of the Arduino.
int ledRed = 9; // red LED Light
int ledGreen = 10;
int ledBlue = 11;
int buttonL = 2;
int buttonR = 3;
int buzzer = 5;

int fadeAmount = 5;
int song_duration[] = {80,100,80,100,80,100,80,100,80,100,80,100,80,100,80,100};
int song_note[] = {80,100,80,100,80,100,80,100,80,100,80,100,80,100,80,100};
int melody[] = {NOTE_C4, NOTE_G3, NOTE_G3, NOTE_A3, NOTE_G3, 0, NOTE_B3, NOTE_C4};
int noteDurations[] = {4, 8, 8, 4, 4, 4, 4, 4};

boolean timing = false;
unsigned long startTime;
unsigned long onTime = 2000;
int previousSensorValue;
int sensorValue = 0;
