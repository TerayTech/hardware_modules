#ifndef __DAC8563_H
#define __DAC8563_H

#include <Arduino.h>

#define PIN_DIN 3U
#define SCLK_PIN 4U
#define CLR_PIN 5U
#define SYNC_PIN 6U
#define LDAC_PIN 7U

#define DIN_H digitalWrite(PIN_DIN, HIGH)
#define DIN_L digitalWrite(PIN_DIN, LOW)
#define SCLK_H digitalWrite(SCLK_PIN, HIGH)
#define SCLK_L digitalWrite(SCLK_PIN, LOW)
#define CLR_H digitalWrite(CLR_PIN, HIGH)
#define CLR_L digitalWrite(CLR_PIN, LOW)
#define SYNC_H digitalWrite(SYNC_PIN, HIGH)
#define SYNC_L digitalWrite(SYNC_PIN, LOW)
#define LDAC_H digitalWrite(LDAC_PIN, HIGH)
#define LDAC_L digitalWrite(LDAC_PIN, LOW)

void DAC8562_WRITE(uint8_t cmd, uint16_t data);
void dac8563_gpio_init(void);

#endif