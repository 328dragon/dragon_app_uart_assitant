using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dragon_app
{
    public partial class Dragon_app : Form
    {
        private long receive_count = 0;
        private long send_count = 0;
        private StringBuilder sb = new StringBuilder();
        private DateTime current_time = new DateTime();    //为了避免在接收处理函数中反复调用，依然声明为一个全局变量as
        public Dragon_app()
        {
            InitializeComponent();

        }
        private void Dragon_app_Load(object sender, EventArgs e)
        {
            //获取电脑当前可用串口并添加到选项列表中
            ComBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            string[] box_initial2 = { "19200", "38400", "43000", "56000", "57600", "115200", "128000", "230400", "256000", "460800", "921600", "1000000", "2000000", "3000000" };
            ComBox2.Items.AddRange(box_initial2);
            string[] box_initial3 = { "5", "6", "7", "8" };
            ComBox3.Items.AddRange(box_initial3);
            string[] box_initial4 = { "None", "Odd", "Even" };
            ComBox4.Items.AddRange(box_initial4);
            string[] box_initial5 = { "1", "1.5", "2" };
            ComBox5.Items.AddRange(box_initial5);
            textBox_uart_state.Text = "串口已关闭";
            textBox_uart_state.ForeColor = Color.Red;


        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "串口";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //加上串口后台
            try
            {
                //将可能产生异常的代码放置在try块中
                //根据当前串口属性来判断是否打开
                if (serialPort1.IsOpen)
                {
                    //串口已经处于打开状态
                    serialPort1.Close();    //关闭串口
                    button1.Text = "打开串口";
                    button1.BackColor = Color.ForestGreen;
                    ComBox1.Enabled = true;
                    ComBox2.Enabled = true;
                    ComBox3.Enabled = true;
                    ComBox4.Enabled = true;
                    ComBox5.Enabled = true;
                    //textBox_receive.Text = "";  //清空接收区
                    //textBox_send.Text = "";     //清空发送区
                    textBox_uart_state.Text = "串口已关闭";
                    textBox_uart_state.ForeColor = Color.Red;
                }
                else
                {
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    ComBox1.Enabled = false;
                    ComBox2.Enabled = false;
                    ComBox3.Enabled = false;
                    ComBox4.Enabled = false;
                    ComBox5.Enabled = false;
                    serialPort1.PortName = ComBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(ComBox2.Text);
                    serialPort1.DataBits = Convert.ToInt16(ComBox3.Text);

                    if (ComBox4.Text.Equals("None"))
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                    else if (ComBox4.Text.Equals("Odd"))
                        serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    else if (ComBox4.Text.Equals("Even"))
                        serialPort1.Parity = System.IO.Ports.Parity.Even;
                    else if (ComBox4.Text.Equals("Mark"))
                        serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    else if (ComBox4.Text.Equals("Space"))
                        serialPort1.Parity = System.IO.Ports.Parity.Space;

                    if (ComBox5.Text.Equals("1"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    else if (ComBox5.Text.Equals("1.5"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    else if (ComBox5.Text.Equals("2"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.Two;

                    serialPort1.Open();     //打开串口
                    button1.Text = "关闭串口";
                    button1.BackColor = Color.Firebrick;
                    textBox_uart_state.Text = "串口已打开";
                    textBox_uart_state.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理

                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                ComBox1.Items.Clear();
                ComBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                button1.Text = "打开串口";
                button1.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                ComBox1.Enabled = true;
                ComBox2.Enabled = true;
                ComBox3.Enabled = true;
                ComBox4.Enabled = true;
                ComBox5.Enabled = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] temp = new byte[1];
            try
            {
                //首先判断串口是否开启
                if (serialPort1.IsOpen)
                {
                    int num = 0;   //获取本次发送字节数
                    //串口处于开启状态，将发送区文本发送
                    if (radioButton4.Checked)
                    {

                    }
                    else
                    {


                    }

                    textBox_receive.AppendText("T：" + textBox_send.Text + "\r\n");
                    serialPort1.Write(textBox_send.Text);
                }
            }
            catch (Exception ex)
            {
                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                ComBox1.Items.Clear();
                ComBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                button1.Text = "打开串口";
                button1.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                ComBox1.Enabled = true;
                ComBox2.Enabled = true;
                ComBox3.Enabled = true;
                ComBox4.Enabled = true;
                ComBox5.Enabled = true;



            }

        }

        private void ComBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //try
            //{
            //    //因为要访问UI资源，所以需要使用invoke方式同步ui
            //    this.Invoke((EventHandler)(delegate
            //    {
            //        textBox_receive.AppendText("R：" + serialPort1.ReadExisting() + "\r\n");
            //    }
            //       )
            //    );

            //}
            //catch (Exception ex)
            //{
            //    //响铃并显示异常给用户
            //    System.Media.SystemSounds.Beep.Play();
            //    MessageBox.Show(ex.Message);
            //}
            //下面的代码是一些接收字节计数的处理
            int num = serialPort1.BytesToRead;      //获取接收缓冲区中的字节数
            byte[] received_buf = new byte[num];    //声明一个大小为num的字节数据用于存放读出的byte型数据

            receive_count += num;                   //接收字节计数变量增加nun
            serialPort1.Read(received_buf, 0, num);   //读取接收缓冲区中num个字节到byte数组中
                                                      //下面的代码是将读取到的字节数据转换为字符串并追加到接收区中           
            sb.Clear();     //防止出错,首先清空字符串构造器
                            //遍历数组进行字符串转化及拼接
                            //foreach (byte b in received_buf)
                            //{
                            //    sb.Append(Encoding.ASCII.GetString(received_buf));//按ASCII码转换
                            //}
            if (radioButton2.Checked)
            {
                //选中HEX模式显示
                foreach (byte b in received_buf)
                {
                    sb.Append(b.ToString("X2") + ' ');    //将byte型数据转化为2位16进制文本显示,用空格隔开
                }
            }
            else
            {
                //选中ASCII模式显示
                sb.Append(Encoding.ASCII.GetString(received_buf));  //将整个数组解码为ASCII数组
            }

            try
            {
                //因为要访问UI资源，所以需要使用invoke方式同步ui
                Invoke((EventHandler)(delegate
                {
                    //textBox_receive.AppendText("R：" + sb.ToString() + "\r\n");

                    if (checkBox1.Checked)
                    {
                        //显示时间
                        current_time = System.DateTime.Now;     //获取当前时间
                        textBox_receive.AppendText(current_time.ToString("HH:mm:ss") + " R：" + sb.ToString() + "\r\n");

                    }
                    else
                    {
                        //不显示时间 
                        textBox_receive.AppendText("R：" + sb.ToString() + "\r\n");
                    }
                    textBox_rx_count.Text = "Rx:" + receive_count.ToString() + "Bytes";
                }
                  )
                );
            }
            catch (Exception ex)
            {
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message);

            }



        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                //自动发送功能选中,开始自动发送
                numericUpDown1.Enabled = false;     //失能时间选择
                Timer2.Interval = (int)numericUpDown1.Value;     //定时器赋初值
                Timer2.Start();     //启动定时器
                textBox_uart_state.Text = "串口已打开" + " 自动发送中...";
            }
            else
            {
                //自动发送功能未选中,停止自动发送
                numericUpDown1.Enabled = true;     //使能时间选择
                Timer2.Stop();     //停止定时器
                textBox_uart_state.Text = "串口已打开";

            }

        }

        private void button_clear_rv_Click(object sender, EventArgs e)
        {
            textBox_receive.Text = "";
            receive_count = 0;          //计数清零
            textBox_rx_count.Text = "Rx:" + receive_count.ToString() + "Bytes";
        }

        private void textBox_uart_state_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_rx_count_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_tx_count_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_tx_Click(object sender, EventArgs e)
        {
            textBox_send.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //用于刷新COM口列表
        private void TIM1_UP_IRQ_Handler(object sender, EventArgs e)
        {

        }

        //用于定时自动发送数据
        private void TIM2_UP_IRQHandler(object sender, EventArgs e)
        {
            button2_Click(button2,new EventArgs());

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
