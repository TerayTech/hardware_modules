#include "dac8563.h"

void dac8563_gpio_init()
{
    pinMode(PIN_DIN, OUTPUT);
    pinMode(SCLK_PIN, OUTPUT);
    pinMode(CLR_PIN, OUTPUT);
    pinMode(SYNC_PIN, OUTPUT);
    pinMode(LDAC_PIN, OUTPUT);
}

void DAC8562_WRITE(uint8_t cmd, uint16_t data)
{
    SYNC_H;
    // delay(0x01);
    SYNC_L;
    SCLK_L;
    for (uint8_t s = 0; s < 8; s++)
    {
        if ((cmd & 0x80) == 0x80)
        {
            DIN_H;
        }
        else
        {
            DIN_L;
        }
        // delay(0x01);
        SCLK_H;
        // delay(0x01);
        cmd <<= 1;
        SCLK_L;
        // delay(0x01);
    }
    for (uint8_t s = 0; s < 16; s++)
    {
        if ((data & 0x8000) == 0x8000)
        {
            DIN_H;
        }
        else
        {
            DIN_L;
        }
        // delay(0x01);
        SCLK_H;
        // delay(0x01);
        data <<= 1;
        SCLK_L;
        // delay(0x01);
    }
}
