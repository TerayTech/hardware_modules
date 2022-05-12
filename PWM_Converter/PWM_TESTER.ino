//定义pwm输入和pwm输出口
int PWM_IN = 2;
int PWM_OUT = 6;

//数据处理用变量
float length_;
float percent;
float output;
int val;

void setup() {
  pinMode(PWM_IN,INPUT);
  pinMode(PWM_OUT,OUTPUT);
  //Serial.begin(9600);
  //Serial.println("PWM TESTER");
}

void loop() {
  //输入采样
 length_ = pulseIn(PWM_IN, HIGH);
 //简单的数学计算
 percent = length_ / 1965 - 0.5;
 output = percent * 255;
 val = floor(output);
 //防止数值超过电路的接受范围导致停转
 if(val > 255){
    val = 255;
  }
  if(val < 0){
    val = 0;
  }
  //Serial.println(val); //测试用
  analogWrite(PWM_OUT,val);
  delay(1);

}
