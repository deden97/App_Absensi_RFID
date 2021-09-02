#include <SPI.h>
#include <MFRC522.h>
#define RST_PIN D2
#define SS_PIN D4
#define buzzer D3
String feedBack;
bool buz = false;

MFRC522 mfrc522(SS_PIN, RST_PIN);

void setup()
{
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  pinMode(buzzer, OUTPUT);
}

void loop()
{
  if(mfrc522.PICC_IsNewCardPresent())
  {
    if(mfrc522.PICC_ReadCardSerial())
    {
      buz = true;
      for(byte i = 0; i < mfrc522.uid.size; i++)
        Serial.print(mfrc522.uid.uidByte[i], HEX);
      mfrc522.PICC_HaltA();
    }
  }

  if(buz)
  {
    tone(buzzer, 250, 300);
    buz = false;
  }
}
