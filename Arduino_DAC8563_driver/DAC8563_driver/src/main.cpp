#include "dac8563.h"
#include <Arduino.h>


void setup()
{
  dac8563_gpio_init();

    CLR_L;
    LDAC_H;
    DAC8562_WRITE(0x28, 0x0001);
    DAC8562_WRITE(0x20, 0x0003);
    DAC8562_WRITE(0x38, 0x0001);

    uint16_t test;

    while (1)
    {
        DAC8562_WRITE(0x18, test);
        // DAC8562_WRITE(0x19, test);
        LDAC_L;
        //delay(1);
        LDAC_H;
        test += 200;
    }
}

void loop()
{
  // put your main code here, to run repeatedly:
}