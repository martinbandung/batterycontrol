String command="";
String commandHeader;
String commandVal="";
uint32_t nilaiParameter=0;

bool fungsi1Flag=false;

void fungsi1(uint32_t _parameter){
  if(nilaiParameter==1){
    Serial.println("hidup");
    digitalWrite(8, 0);
    delay(2000);
    digitalWrite(8, 0);
    delay(2000);
    digitalWrite(8, 0);
    delay(2000);        
  }
  if(nilaiParameter==0){
    Serial.println("mati");
    digitalWrite(8, 1);
    delay(2000);
    digitalWrite(8, 1);
    delay(2000);    
    digitalWrite(8, 1);
    delay(2000);
  }
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(19200);
  pinMode(8,OUTPUT);
  digitalWrite(8, 0);
  delay(1000);   
  digitalWrite(8, 1);
  delay(1000); 
  digitalWrite(8, 0);
  delay(1000);   
  digitalWrite(8, 1);
  delay(1000);     
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()>0){
    command=Serial.readString();    //untuk menerima string dari serial
    commandHeader=command.substring(0,command.indexOf(':')); //untuk mengekstrak header dari string yang diterima
    commandVal=command.substring(command.indexOf(':')+1,command.indexOf(';'));  //untuk mengekstrak nilai yang dikirim
    nilaiParameter=commandVal.toInt();  //konversi nlai variabel dari string menjadi int
    Serial.print("Received string: ");Serial.print(command);
    Serial.print("commandHeader: ");Serial.println(commandHeader);
    Serial.print("commandVal: ");Serial.println(commandVal);
    Serial.print("nilaiParameter: ");Serial.println(nilaiParameter);

    if(commandHeader=="fungsi1"){
      fungsi1Flag=true;
    }
    else{
      Serial.print(commandHeader);Serial.println(" tidak dikenal");
    }
  }

  if(fungsi1Flag==true){
    fungsi1Flag=false;
    fungsi1(nilaiParameter);
  }
/*
  uint16_t dataADC0=analogRead(0);
  uint16_t dataADC1=analogRead(1);
  uint16_t dataADC2=analogRead(2);
*/
  //Serial.print(dataADC0);Serial.print(",");Serial.print(dataADC1);Serial.print(",");Serial.print(dataADC2);Serial.println(",");
  delay(500);
  
  

}
