
/*


 Kod ile ilgili detaylı içeriğe ulaşmak için:  
 To access content related to this code:  
 https://www.youtube.com/@KeremSalepci  



 Bu projede kullanılan bazı animasyonlar aşağıdaki web sitesinden alınmıştır:  
 Some of the animations used in this project were taken from the following website:  
 https://www.tweaking4all.com/hardware/arduino/adruino-led-strip-effects/#RequiredLibraryNeoPixelorFastLED  


*/



#include <Adafruit_NeoPixel.h>

#define LED_PIN 3
#define LED_COUNT 249
char command[20];
bool newCommandAvailable;
bool colorFlag;
bool colorfulFlag;
int brightness = 50;
bool debug = true;
Adafruit_NeoPixel strip(LED_COUNT, LED_PIN, NEO_GRB + NEO_KHZ800);

void setup() {
  Serial.begin(115200);
  strip.begin();
  strip.show();
  strip.setBrightness(brightness);
  Serial.println("PC'den komut bekleniyor...");
  if (debug) Serial.println("setup bitisi");
}

void loop() {
  dongu();
}

void setColor(int red, int green, int blue) {
  if (colorFlag) {
    for (int i = 0; i < LED_COUNT; i++) {
      strip.setPixelColor(i, strip.Color(red, green, blue));
      serialPort();
    }
    strip.show();
    colorFlag = false;
  }
}

void rainbowEffect() {
  static unsigned long prevTime = 0;
  static long firstPixelHue = 0;

  while (firstPixelHue < 65536) {
    unsigned long currentMillis = millis();
    serialPort();
    if (currentMillis - prevTime >= 10) {
      prevTime = currentMillis;
      strip.rainbow(firstPixelHue);
      strip.show();
      firstPixelHue += 768;
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;
    }
  }
  firstPixelHue = 0;
}

void Fire(int Cooling, int Sparking, int SpeedDelay) {
  static byte heat[LED_COUNT];
  static unsigned long prevTime = 0;

  while (1) {
    unsigned long currentMillis = millis();
    serialPort();
    if (currentMillis - prevTime >= SpeedDelay) {
      prevTime = currentMillis;
      for (int i = 0; i < LED_COUNT; i++) {
        int cooldown = random(0, ((Cooling * 10) / LED_COUNT) + 2);
        heat[i] = (cooldown > heat[i]) ? 0 : heat[i] - cooldown;
      }
      for (int k = LED_COUNT - 1; k >= 2; k--) {
        heat[k] = (heat[k - 1] + heat[k - 2] + heat[k - 2]) / 3;
      }
      if (random(255) < Sparking) {
        int y = random(7);
        heat[y] = heat[y] + random(160, 255);
      }
      for (int j = 0; j < LED_COUNT; j++) {
        setPixelHeatColor(j, heat[j]);
      }
      showStrip();
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;
    }
  }
}

void setPixelHeatColor(int Pixel, byte temperature) {
  byte t192 = (temperature * 191) / 255;
  byte heatramp = t192 & 0x3F;
  heatramp <<= 2;

  if (t192 > 0x80) {
    setPixel(Pixel, 255, 255, heatramp);
  } else if (t192 > 0x40) {
    setPixel(Pixel, 255, heatramp, 0);
  } else {
    setPixel(Pixel, heatramp, 0, 0);
  }
}

void fadeOutEffect() {
  static unsigned long prevTime = 0;
  static int j = 0;
  static int k = 0;
  static bool isFadingIn = true;

  while (j < 3) {
    unsigned long currentMillis = millis();
    serialPort();
    if (currentMillis - prevTime >= 3) {
      prevTime = currentMillis;
      if (isFadingIn) {
        switch (j) {
          case 0: setAll(k, 0, 0); break;
          case 1: setAll(0, k, 0); break;
          case 2: setAll(0, 0, k); break;
        }
        k += 10;
        if (k > 255) {
          k = 255;
          isFadingIn = false;
        }
      } else {
        switch (j) {
          case 0: setAll(k, 0, 0); break;
          case 1: setAll(0, k, 0); break;
          case 2: setAll(0, 0, k); break;
        }
        k -= 10;
        if (k < 0) {
          k = 0;
          isFadingIn = true;
          j++;
        }
      }
      showStrip();
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;
    }
  }
  j = 0;
}

void theaterChaseEffect(int wait) {
  static unsigned long prevTime = 0;
  static int a = 0;
  static int b = 0;
  static int firstPixelHue = 0;

  while (a < 30) {
    unsigned long currentMillis = millis();
    serialPort();
    if (currentMillis - prevTime >= wait) {
      prevTime = currentMillis;
      strip.clear();
      for (int c = b; c < strip.numPixels(); c += 3) {
        int hue = firstPixelHue + c * 65536L / strip.numPixels();
        uint32_t color = strip.gamma32(strip.ColorHSV(hue));
        strip.setPixelColor(c, color);
      }
      strip.show();
      firstPixelHue += 65536 / 90;
      b++;
      if (b >= 3) {
        b = 0;
        a++;
      }
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      return;
    }
  }
  a = 0;
}

void strobeEffect(byte red, byte green, byte blue, int StrobeCount, int FlashDelay, int EndPause) {
  static unsigned long prevTime = 0;
  static int strobeCounter = 0;
  static bool isOn = false;
  static bool isEndPause = false;

  while (true) {
    unsigned long currentMillis = millis();
    serialPort();
    if (isEndPause) {
      if (currentMillis - prevTime >= EndPause) {
        isEndPause = false;
        strobeCounter = 0;
      }
    } else {
      if (currentMillis - prevTime >= FlashDelay) {
        prevTime = currentMillis;
        if (isOn) {
          setAll(0, 0, 0);
        } else {
          setAll(red, green, blue);
        }
        showStrip();
        isOn = !isOn;
        strobeCounter++;
        if (strobeCounter >= StrobeCount * 2) {
          isEndPause = true;
          prevTime = currentMillis;
        }
      }
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      return;
    }
  }
}

void CylonBounce(byte red, byte green, byte blue, int EyeSize, int SpeedDelay, int ReturnDelay) {
  static unsigned long prevTime = 0;
  static unsigned long returnStartTime = 0;
  static int position = 0;
  static bool direction = true;
  static bool isReturning = false;

  while (true) {
    unsigned long currentMillis = millis();
    serialPort();
    if (isReturning) {
      if (currentMillis - returnStartTime >= ReturnDelay) {
        isReturning = false;
      }
    } else {
      if (currentMillis - prevTime >= SpeedDelay) {
        prevTime = currentMillis;
        setAll(0, 0, 0);
        if (direction) {
          setPixel(position, red / 10, green / 10, blue / 10);
          for (int j = 1; j <= EyeSize; j++) {
            setPixel(position + j, red, green, blue);
          }
          setPixel(position + EyeSize + 1, red / 10, green / 10, blue / 10);
          position++;
        } else {
          setPixel(position, red / 10, green / 10, blue / 10);
          for (int j = 1; j <= EyeSize; j++) {
            setPixel(position - j, red, green, blue);
          }
          setPixel(position - EyeSize - 1, red / 10, green / 10, blue / 10);
          position--;
        }
        showStrip();
        if (position >= LED_COUNT - EyeSize - 2) {
          direction = false;
          isReturning = true;
          returnStartTime = currentMillis;
        } else if (position <= 0) {
          direction = true;
          isReturning = true;
          returnStartTime = currentMillis;
        }
      }
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;
    }
  }
  serialPort();
}

void TwinkleRandom(int Count, int SpeedDelay, boolean OnlyOne) {
  setAll(0, 0, 0);
  unsigned long prevTime = millis();
  int twinkleCount = 0;

  while (twinkleCount < Count) {
    serialPort();
    if (millis() - prevTime >= SpeedDelay) {
      prevTime = millis();
      setPixel(random(LED_COUNT), random(0, 255), random(0, 255), random(0, 255));
      showStrip();
      if (OnlyOne) {
        setAll(0, 0, 0);
      }
      twinkleCount++;
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;
    }
  }
  serialPort();
}

void Sparkle(byte red, byte green, byte blue, int SpeedDelay) {
  setAll(0, 0, 0);
  static unsigned long prevTime = 0;
  static int Pixel = -1;
  while (true) {
    serialPort();
    unsigned long currentMillis = millis();
    if (currentMillis - prevTime >= SpeedDelay) {
      prevTime = currentMillis;
      if (Pixel != -1) {
        setPixel(Pixel, 0, 0, 0);
      }
      Pixel = random(LED_COUNT);
      setPixel(Pixel, red, green, blue);
      showStrip();
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;
    }
  }
  serialPort();
}

void RunningLights(byte red, byte green, byte blue, int WaveDelay) {
  static int Position = 0;
  unsigned long previousMillis = 0;
  bool direction = true;

  while (true) {
    unsigned long currentMillis = millis();
    if (currentMillis - previousMillis >= WaveDelay) {
      previousMillis = currentMillis;
      for (int i = 0; i < LED_COUNT; i++) {
        float factor = (sin((i + Position) * 0.5) + 1) / 2;
        setPixel(i, factor * red, factor * green, factor * blue);
      }
      showStrip();
      if (direction) {
        Position++;
        if (Position >= LED_COUNT * 2) direction = false;
      } else {
        Position--;
        if (Position <= 0) direction = true;
      }
    }
    serialPort();
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;
    }
  }
  serialPort();
}

void meteorRain(byte red, byte green, byte blue, byte meteorSize, byte meteorTrailDecay, boolean meteorRandomDecay, int SpeedDelay) {
  setAll(0, 0, 0);
  unsigned long prevTime = millis();
  int i = 0;

  while (i < LED_COUNT + LED_COUNT) {
    serialPort();
    if (millis() - prevTime >= SpeedDelay) {
      prevTime = millis();
      for (int j = 0; j < LED_COUNT; j++) {
        if (!meteorRandomDecay || random(10) > 5) {
          fadeToBlack(j, meteorTrailDecay);
        }
      }
      for (int j = 0; j < meteorSize; j++) {
        if ((i - j < LED_COUNT) && (i - j >= 0)) {
          setPixel(i - j, red, green, blue);
        }
      }
      showStrip();
      i++;
    }
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;
    }
  }
  serialPort();
}

void fadeToBlack(int ledNo, byte fadeValue) {
  uint32_t oldColor = strip.getPixelColor(ledNo);
  byte r = (oldColor >> 16) & 0xFF;
  byte g = (oldColor >> 8) & 0xFF;
  byte b = oldColor & 0xFF;
  r = (r <= 10) ? 0 : (r - (r * fadeValue / 256));
  g = (g <= 10) ? 0 : (g - (g * fadeValue / 256));
  b = (b <= 10) ? 0 : (b - (b * fadeValue / 256));
  strip.setPixelColor(ledNo, r, g, b);
}


void Colorful() {
  uint32_t colors[] = { strip.Color(255, 0, 0),      // Kırmızı
                        strip.Color(0, 255, 0),      // Yeşil
                        strip.Color(0, 0, 255),      // Mavi
                        strip.Color(255, 255, 0),    // Sarı
                        strip.Color(0, 255, 255),    // Cyan
                        strip.Color(255, 0, 255) };  // Mor

  int colorCount = sizeof(colors) / sizeof(colors[0]);

  if (colorfulFlag) {
    int currentLED = 0;
    setAll(0, 0, 0);

    for (int i = 0; i < LED_COUNT; i++) {
      strip.setPixelColor(currentLED, colors[currentLED % colorCount]);
      currentLED++;  // Bir sonraki LED'e geç
      serialPort();
    }
    strip.show();
    colorfulFlag = false;
  }
}


void policeLights(int delayTime) {
  static unsigned long previousMillis = 0;  // Zaman kontrolü için değişken
  static bool ledState = false;             // LED'lerin yanık/sönük durumu
  static int flashCount = 0;                // Yanıp sönme sayacı
  static bool isRedPhase = true;            // Kırmızı fazında mıyız?
  while (1) {
    unsigned long currentMillis = millis();

    if (currentMillis - previousMillis >= delayTime) {
      previousMillis = currentMillis;  // Zamanı güncelle

      if (ledState) {
        // LED'leri söndür
        setAll(0, 0, 0);
        flashCount++;  // Yanıp sönme sayacını artır
      } else {
        // LED'leri yak
        int halfLEDs = LED_COUNT / 2;  // LED'lerin yarısı (tam sayı bölme)

        if (isRedPhase) {
          // Kırmızı fazı: İlk yarısı kırmızı
          for (int i = 0; i < halfLEDs; i++) {
            strip.setPixelColor(i, strip.Color(0, 0, 255));  // Kırmızı
          }
          // Ortadaki LED (tek sayı durumu için)
          if (LED_COUNT % 2 != 0) {
            strip.setPixelColor(halfLEDs, strip.Color(0, 0, 255));  // Kırmızı
          }
        } else {
          // Mavi fazı: İkinci yarısı mavi
          for (int i = halfLEDs; i < LED_COUNT; i++) {
            strip.setPixelColor(i, strip.Color(255, 0, 0));  // Mavi
          }
        }
      }

      strip.show();          // LED'leri güncelle
      ledState = !ledState;  // LED durumunu tersine çevir (yanık -> sönük, sönük -> yanık)

      // 2 kez yanıp söndükten sonra fazı değiştir
      if (flashCount >= 2) {
        flashCount = 0;            // Sayaçı sıfırla
        isRedPhase = !isRedPhase;  // Fazı değiştir (kırmızı -> mavi veya mavi -> kırmızı)
      }
    }

    // Yeni komut kontrolü
    serialPort();
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;  // Fonksiyondan çık
    }
  }
  serialPort();
}

void SequentialColor(int delayTime) {
  uint32_t colors[] = {
    strip.Color(255, 0, 0),    // Kırmızı
    strip.Color(0, 255, 0),    // Yeşil
    strip.Color(0, 0, 255),    // Mavi
    strip.Color(255, 255, 0),  // Sarı
    strip.Color(0, 255, 255),  // Cyan
    strip.Color(255, 0, 255)   // Mor
  };
  int colorCount = sizeof(colors) / sizeof(colors[0]);  // Renk sayısı

  static unsigned long previousMillis = 0;  // Zaman kontrolü için değişken
  static int currentColor = 0;              // Şu anki renk indeksi

  while (1) {  // Sonsuz döngü
    unsigned long currentMillis = millis();

    if (currentMillis - previousMillis >= delayTime) {
      previousMillis = currentMillis;  // Zamanı güncelle

      // Tüm LED'leri şu anki renkle yak
      for (int i = 0; i < LED_COUNT; i++) {
        strip.setPixelColor(i, colors[currentColor]);
      }
      strip.show();  // LED'leri güncelle

      // Bir sonraki renge geç
      currentColor = (currentColor + 1) % colorCount;
    }

    // Yeni komut kontrolü
    serialPort();
    if (newCommandAvailable) {
      newCommandAvailable = false;
      break;  // Döngüden çık
    }
  }
}

void kapat() {
  strip.clear();
  strip.show();
}

void showStrip() {
  strip.show();
}

void setPixel(int Pixel, byte red, byte green, byte blue) {
  strip.setPixelColor(Pixel, strip.Color(red, green, blue));
}

void setAll(byte red, byte green, byte blue) {
  for (int i = 0; i < LED_COUNT; i++) {
    setPixel(i, red, green, blue);
  }
  showStrip();
}

void serialPort() {
  if (Serial.available()) {
    char buffer[20];
    int bytesRead = Serial.readBytesUntil('\n', buffer, (sizeof(buffer) - 1));
    buffer[bytesRead] = '\0';
    strncpy(command, buffer, sizeof(command));
    newCommandAvailable = true;
    colorFlag = true;
    colorfulFlag = true;
    if (debug) {
      Serial.print("Serial dongu bitisi, degiskendeki deger: ");
      Serial.println(command);
    }
  }
}

void dongu() {
  serialPort();
  char commandType = command[0];
  switch (commandType) {
    case 'A':
      {
        int r, g, b;
        sscanf(command, "A %d %d %d", &r, &g, &b);
        setColor(r, g, b);
        break;
      }
    case 'B':
      rainbowEffect();
      break;
    case 'C':
      Fire(55, 70, 25);
      break;
    case 'D':
      fadeOutEffect();
      break;
    case 'E':
      theaterChaseEffect(60);
      break;
    case 'F':
      strobeEffect(0xff, 0xff, 0xff, 10, 50, 1000);
      break;
    case 'G':
      CylonBounce(0xff, 0, 0, 4, 10, 50);
      break;
    case 'H':
      TwinkleRandom(20, 100, false);
      break;
    case 'I':
      Sparkle(0xff, 0xff, 0xff, 15);
      break;
    case 'J':
      RunningLights(0x00, 0xff, 0xff, 20);
      break;
    case 'K':
      meteorRain(0xff, 0xff, 0xff, 10, 64, true, 0);
      break;
    case 'L':
      kapat();
      break;
    case 'M':
      SequentialColor(110);
      break;
    case 'N':
      policeLights(75);
      break;
    case 'O':
      Colorful();
      break;
    default:
      if (debug) Serial.println("Bilinmeyen komut!");
      break;
  }
}