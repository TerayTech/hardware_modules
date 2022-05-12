using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace serialControlPWM
{
    public partial class Form1 : Form
    {
        private SerialPort myport;


        public delegate void Displaydelegate(byte[] InputBuf);
        Byte[] OutputBuf = new Byte[128];
        public Displaydelegate disp_delegate;

        public Form1()

        {
            //INIT
            InitializeComponent();
            init();
            label2.Text = "0";
            //LOAD
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 255;
            trackBar1.TickFrequency = 10;

            string[] ports = SerialPort.GetPortNames();
            cbox_ports.Items.AddRange(ports);
            /*
            //serial builder
            StringBuilder builder = new StringBuilder();
            string Buffer_recv = "";

            disp_delegate = new Displaydelegate(DispUI);
     myport.DataReceived += new SerialDataReceivedEventHandler(Comm_DataReceived);

            InitializeComponent();
        }

      public void DispUI(byte[] InputBuf)
        {
            //textBox1.Text = Convert.ToString(InputBuf);  

            ASCIIEncoding encoding = new ASCIIEncoding();
     textBox1.Text = encoding.GetString(InputBuf);
        }
        */

        }


        private void btn_0_Click(object sender, EventArgs e)
        {
            myport.WriteLine("0, 0, 0, 0, 0, 0");
            MessageBox.Show("数据已上传");

        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            myport.WriteLine("50, 0, 0, 0, 0, 0");
            MessageBox.Show("数据已上传");
        }

        private void btn_100_clk(object sender, EventArgs e)
        {
            myport.WriteLine("100, 0, 0, 0, 0, 0");
            MessageBox.Show("数据已上传");

        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            myport.WriteLine("200, 0, 0, 0, 0, 0");
            MessageBox.Show("数据已上传");
        }

        private void btn_255_clk(object sender, EventArgs e)
        {
            myport.WriteLine("255,0,0,0,0,0");
            MessageBox.Show("数据已上传");

        }

        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           

              label2.Text = trackBar1.Value.ToString();
         // myport.WriteLine("0, 0, 0, 0, 0, 0");
            // myport.WriteLine(trackBar1.Value.ToString());
            //textBox1.Text = trackBar1.Value.ToString();
        }
        
        
        /*
        void Comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Byte[] InputBuf = new Byte[128];

            try
            {
                myport.Read(InputBuf, 0, myport.BytesToRead);                                //读取缓冲区的数据直到“}”即0x7D为结束符  
                //InputBuf = UnicodeEncoding.Default.GetBytes(strRD);             //将得到的数据转换成byte的格式  
                System.Threading.Thread.Sleep(50);
                this.Invoke(disp_delegate, InputBuf);

            }
            catch (TimeoutException ex)         //超时处理  
            {
                MessageBox.Show(ex.ToString());
            }
        }
        */

        //serial write progress
        private void init() {
            try
            {
                
            }
            catch(Exception)
            {
                MessageBox.Show("Error!");
            }
            
        
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_apply_Click(object sender, EventArgs e)
        {
            string data = trackBar1.Value.ToString();
            string data_end = ",0,0,0,0,0";

            string final_data = data + data_end;
            myport.WriteLine(final_data);
            MessageBox.Show("数据已上传");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            myport = new SerialPort();
            myport.BaudRate = Convert.ToInt32(cbox_baud_rate.Text);
            myport.PortName = cbox_ports.Text;
            myport.Open();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message,"警告！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_srl_close_Click(object sender, EventArgs e)
        {
            myport.Close();
        }
    }
}
