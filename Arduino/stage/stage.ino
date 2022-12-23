#include "CytronMotorDriver.h"


// Configure the motor driver.
CytronMD motor1(PWM_DIR, 5, 4);  // PWM 1 = Pin 3, DIR 1 = Pin 4.
CytronMD motor2(PWM_DIR, 6, 7); // PWM 2 = Pin 9, DIR 2 = Pin 10.
String readString;

///motor1
int encoderPin1 = 3; //Encoder Output 'A' must connected with intreput pin of arduino.
int encoderPin2 = 2; //Encoder Otput 'B' must connected with intreput pin of arduino.
long target = 0; // for incoming serial data
//int motorSpeed=100;

volatile int lastEncoded = 0; // Here updated value of encoder store.
volatile long encoderValue = 0; // Raw encoder value


// The setup routine runs once when you press reset.
void setup() {
  Serial.begin(115200); //initialize serial comunication

  pinMode(encoderPin1, INPUT_PULLUP);
  pinMode(encoderPin2, INPUT_PULLUP);


  digitalWrite(encoderPin1, HIGH); //turn pullup resistor on
  digitalWrite(encoderPin2, HIGH); //turn pullup resistor on
  //on interrupt 0 (pin 2), or interrupt 1 (pin 3)
  attachInterrupt(0, updateEncoder, CHANGE);
  attachInterrupt(1, updateEncoder, CHANGE);


}



// The loop routine runs over and over again forever.
void loop() {

  int dead_band =30;
   //Serial.println("hello/");
  delay(100);
  while (Serial.available()) {
    char c = Serial.read();  //gets one byte from serial buffer
    readString += c; //makes the string readString
    delay(50);
  }
  
  if (readString.length() >0) {
    //Serial.print(readString);  //so you can see the captured string
    target = readString.toInt();  //convert readString into a number

    delay(100);
    }
  readString=""; //empty for next input
  
  
  if (encoderValue > target - dead_band && encoderValue < target + dead_band){
    motor1.setSpeed(0);
  }
  else
  { 
    if (encoderValue< target){
      motor1.setSpeed(60);  // Run forward at full speed.
   }
    if (encoderValue > target){
      motor1.setSpeed(-60);
    }
  }
  
  delay(1);
  Serial.println(encoderValue);
  delay(10);

}

void updateEncoder(){
  int MSB = digitalRead(encoderPin1); //MSB = most significant bit
  int LSB = digitalRead(encoderPin2); //LSB = least significant bit

  int encoded = (MSB << 1) |LSB; //converting the 2 pin value to single number
  int sum  = (lastEncoded << 2) | encoded; //adding it to the previous encoded value

  if(sum == 0b1101 || sum == 0b0100 || sum == 0b0010 || sum == 0b1011) encoderValue --;
  if(sum == 0b1110 || sum == 0b0111 || sum == 0b0001 || sum == 0b1000) encoderValue ++;

  lastEncoded = encoded; //store this value for next time

}
