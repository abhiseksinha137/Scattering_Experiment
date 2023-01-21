// Motor Params
#define dirPin 2
#define stepPin 3
#define endPin 11


const unsigned int MAX_MESSAGE_LENGTH = 12;
static char message[MAX_MESSAGE_LENGTH];
int flagMsg;
int dly=1000;
long mov;
String readString="";
void setup() {
   Serial.begin(9600);
   // Declare pins as output:
   pinMode(stepPin, OUTPUT);
   pinMode(dirPin, OUTPUT);
   pinMode(endPin, OUTPUT);
   digitalWrite(endPin, HIGH);
   // Set the spinning direction CW/CCW:
   Serial.begin(9600);
}

void loop() {
   flagMsg=0;
   while (Serial.available()) {
      char c = Serial.read();  //gets one byte from serial buffer
      readString += c; //makes the string readString
      delay(50);
   }
   if (readString.length() >0) {
      //Serial.print(readString);  //so you can see the captured string
      mov = readString.toInt();  //convert readString into a number
      flagMsg=1;
      delay(50);
   }
   readString=""; //empty for next input
   if (flagMsg==1){
      //Serial.println(moveVal);

      if (mov  > 0){
         for(int i=0; i<mov;i++){
           digitalWrite(dirPin, HIGH);
           digitalWrite(stepPin, HIGH);
           delayMicroseconds(dly);
           digitalWrite(stepPin, LOW);
           delayMicroseconds(dly);
         }
      }
      if (mov  < 0){
         mov=-mov;
         for(int i=0; i<mov; i++){
           digitalWrite(dirPin, LOW);
           digitalWrite(stepPin, HIGH);
           delayMicroseconds(dly);
           digitalWrite(stepPin, LOW);
           delayMicroseconds(dly);
         }
      }
   }
 delay(100);
}
