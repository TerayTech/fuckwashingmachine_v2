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
using System.Threading;

namespace WindowsFormsApplication1219
{
    public partial class Form1 : Form
    {
        SerialPort sp = new SerialPort();//创建串口全局变量
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;//隐藏最大化按钮
             this.MaximumSize = this.Size;//固定窗口尺寸最大为当前尺寸
             this.MinimumSize = this.Size;//固定窗口尺寸最小为当前尺寸
 
             tbxSendData.Focus();//默认将光标放在发送文本框上
 
             rbtReceviedAscii.Select();//默认选择ASCII字符显示
             rbtSendAscii.Select();//默认选择ASCII字符显示
 
             CheckPort();//检测可用串口
 
             //初始化波特率
             cbxBaud.Items.Clear();
             cbxBaud.Items.Add("1200");
             cbxBaud.Items.Add("2400");
             cbxBaud.Items.Add("4800");
             cbxBaud.Items.Add("9600");
             cbxBaud.Items.Add("12800");
             cbxBaud.Items.Add("19200");
             cbxBaud.Items.Add("25600");
             cbxBaud.Items.Add("115200");
             cbxBaud.SelectedIndex = 3;
 
             //初始化校验位
             cbxParity.Items.Clear();
             cbxParity.Items.Add("无");
             cbxParity.Items.Add("奇校验");
             cbxParity.Items.Add("偶校验");
             cbxParity.SelectedIndex = 0;
 
             //初始化停止位
             cbxStopBits.Items.Clear();
             cbxStopBits.Items.Add("1");
             cbxStopBits.Items.Add("1.5");
             cbxStopBits.Items.Add("2");
             cbxStopBits.SelectedIndex = 0;
 
             //初始化数据位
             cbxDataBits.Items.Clear();
             cbxDataBits.Items.Add("7");
             cbxDataBits.Items.Add("8");
             cbxDataBits.SelectedIndex = 1;
 
             statusLabel1.Text = "";//修改状态条内容

        }

         //检测当前可用串口函数
        private void CheckPort()
        {
            cbxPort.Items.Clear();//清除控件中当前值
            bool haveCOM = false;//用于最终判断是否有串口
            string[] a = SerialPort.GetPortNames();//获取本机的所有串口名称
            if (a == null)
            {
                haveCOM = false; //无可用串口
            }
            else
            {
                foreach (string b in a) //将串口名称添加到下拉列表控件中
                {
                    bool excitent = false;
                    try  //打开串口,测试串口是否可用
                    {
                        SerialPort sp = new SerialPort(b);
                        sp.Open();
                        sp.Close();
                        excitent = true;
                    }
                    catch
                    {
                        excitent = false;
                    }
                    if (excitent)
                    {
                        cbxPort.Items.Add(b);
                        haveCOM = true;
                    }
                }
            }
            if (haveCOM)
            {
                cbxPort.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("无可用串口！", "错误提示");
            }
        }

        //设置串口函数
        private void SetCOM()
        {
            try
            {
                sp.PortName = cbxPort.Text.Trim();//串口名
                sp.BaudRate = Convert.ToInt32(cbxBaud.Text.Trim());//波特率
                if (cbxParity.Text.Trim() == "奇校验")//奇偶校验位
                {
                    sp.Parity = Parity.Odd;
                }
                else if (cbxParity.Text.Trim() == "偶校验")
                {
                    sp.Parity = Parity.Even;
                }
                else
                {
                    sp.Parity = Parity.None;
                }
                if (cbxStopBits.Text.Trim() == "1.5")//停止位
                {
                    sp.StopBits = StopBits.OnePointFive;
                }
                else if (cbxStopBits.Text.Trim() == "2")
                {
                    sp.StopBits = StopBits.Two;
                }
                else
                {
                    sp.StopBits = StopBits.One;
                }
                sp.DataBits = Convert.ToInt16(cbxDataBits.Text.ToString().Trim());//数据位

                sp.Encoding = Encoding.UTF8;//设置串口通信的编码格式，默认ASCII  Encoding.Default

            }
            catch
            {

            }
        }

        //16进制字符串转换成ASCII字符串
        private string HexToASCII(string str)
         {
             try
             {
                 string[] mystr1 = str.Trim().Split(' ');
                 byte[] t = new byte[mystr1.Length];
                 for (int i = 0; i < t.Length; i++)
                 {
                     t[i] = Convert.ToByte(mystr1[i], 16);
                 }
                 return Encoding.UTF8.GetString(t);
             }
             catch (Exception ex)
             {
                 rbtSendAscii.Select();
                 MessageBox.Show("转换失败！" + ex.Message, "错误提示");
                 return str;
             }
         }

        //字符串转换成16进制字符
        private string ASCIIToHex(string str)
         {
             try
             {
                 byte[] a = Encoding.UTF8.GetBytes(str.Trim());
                 string mystr1 = "";
                 for (int i = 0; i < a.Length; i++)
                 {
                     mystr1 += a[i].ToString("X2") + " ";
                 }
                 return mystr1;
             }
             catch (Exception ex)
             {
                 rbtSendAscii.Select();
                 MessageBox.Show("转换失败！" + ex.Message, "错误提示");
                 return str;
             }
         }

        private void COMReceived(object sender,SerialDataReceivedEventArgs e)
         {
             Thread.Sleep(100);
             this.Invoke((EventHandler)(delegate {
                 try
                 {
                     string mystr1 = "[接收] " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + " ";
                     byte[] a = new byte[sp.BytesToRead];
                     Byte[] BSendTemp0 = new Byte[1];
                     sp.Read(a, 0, a.Length);
                     string mystr2 = Encoding.UTF8.GetString(a);
                     //string mystr2 = Encoding.UTF8.GetString(a);
                     string b = "";
                     if (rbtReceviedHex.Checked)
                     {
                         b = ASCIIToHex(mystr2);
                     }
                     else
                     {
                         b = mystr2;
                         
                     }
                     //tbxReceivedData.Text += mystr1 + b + "\r\n";
                     tbxReceivedData.Text += mystr1 + a + "\r\n";
                     statusLabel1.Text = "接收成功！";
                 }
                 catch
                 {
                     statusLabel1.Text = "接收失败！";
                 }
             }));
         }

        //检测串口按钮事件
        private void bt_check_com_Click(object sender, EventArgs e)
        {
            statusLabel1.Text = "检测串口开始！";
            CheckPort();
            statusLabel1.Text = "串口检测完成！";
        }

        private void bt_open_com_Click(object sender, EventArgs e)
        {
            if (bt_open_com.Text == "打开串口")
             {
                 SetCOM();//设置串口函数
                 if (sp.IsOpen)
                 {
                     statusLabel1.Text = "串口"+cbxPort.Text+"已打开！";
                 }
                 else
                 {
                     try
                     {
                         sp.Open(); //打开串口
                         //禁用设置控件
                         bt_check_com.Enabled = false;
                         cbxPort.Enabled = false;
                         cbxBaud.Enabled = false;
                         cbxParity.Enabled = false;
                         cbxStopBits.Enabled = false;
                         cbxDataBits.Enabled = false;
                         bt_open_com.Text = "关闭串口";
                         statusLabel1.Text = "串口" + cbxPort.Text + "打开成功！";
                         sp.DataReceived += new SerialDataReceivedEventHandler(COMReceived);//定义串口接收事件
                     }
                     catch(Exception ex)
                     {
                         MessageBox.Show("串口"+cbxPort.Text+"打开失败,失败原因："+ex.Message,"错误提示");
                         statusLabel1.Text = "串口" + cbxPort.Text + "打开失败,失败原因：" + ex.Message;
                     }
                 }
             }
             else //关闭串口
             {
                 if (sp.IsOpen) //判断串口是否打开
                 {
                     try
                     {
                         sp.Close(); //关闭串口
                         //启用设置控件
                         bt_check_com.Enabled = true;
                         cbxPort.Enabled = true;
                         cbxBaud.Enabled = true;
                         cbxParity.Enabled = true;
                         cbxStopBits.Enabled = true;
                         cbxDataBits.Enabled = true;
                         bt_open_com.Text = "打开串口";
                         statusLabel1.Text = "串口" + cbxPort.Text + "关闭成功！";
                     }
                     catch(Exception ex)
                     {
                         MessageBox.Show("串口"+ cbxPort.Text + "关闭失败,错误提示："+ex.Message,"错误提示");
                         statusLabel1.Text = "串口" + cbxPort.Text + "关闭失败,错误提示：" + ex.Message;
                     }
                 }
                 else
                 {
                     bt_check_com.Enabled = true;
                     cbxPort.Enabled = true;
                     cbxBaud.Enabled = true;
                     cbxParity.Enabled = true;
                     cbxStopBits.Enabled = true;
                     cbxDataBits.Enabled = true;
                     bt_check_com.Text = "打开串口";
                     statusLabel1.Text = "串口未打开，无法关闭！";
                     MessageBox.Show("串口未打开，无法关闭！","错误提示");
                 }
             }
        }

        private void bt_clear_Click(object sender, EventArgs e)   //清除按钮
        {
            tbxReceivedData.Text = "";
            tbxSendData.Text = "";
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
              try
             {
                 string mystr1 = tbxSendData.Text;
                 if (rbtSendHex.Checked)
                 {
                     mystr1 = HexToASCII(tbxSendData.Text);
                     //mystr1 = tbxSendData.Text;
                }
                 byte[] a = Encoding.UTF8.GetBytes(mystr1);
                 string mystr2 = Encoding.UTF8.GetString(a);
                //sp.Write(mystr2);
                Byte[] data = new byte[3] { 0xa2, 0x01, 0xa3 };
                Byte[] BSendTemp = new Byte[1];
                for (int i = 0; i < 3; i++)
                {
                    BSendTemp[0] = data[i];
                    sp.Write(BSendTemp, 0, 1);
                }
                

                //tbxReceivedData.Text += "[发送] " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + " " + tbxSendData.Text + "\r\n";
                //tbxReceivedData.Text += "[发送] " + DateTime.Now.ToString("yyyyMMddHHmmssfff") + " " + Convert.ToString(byteSend1[0], 16) + " "+ Convert.ToString(byteSend2[0], 16) + " "+ Convert.ToString(byteSend3[0], 16) + "\r\n";
                statusLabel1.Text = "发送成功！";

                 //this.tbxReceivedData.Focus();//获取焦点
                 //this.tbxReceivedData.Select(this.tbxReceivedData.TextLength, 0);//光标定位到文本最后
                 //this.tbxReceivedData.ScrollToCaret();//滚动到光标处
             }
             catch
             {
                 statusLabel1.Text = "发送失败";
             }
        }

        private void rbtSendAscii_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbtSendAscii.Checked)    //have issue
            //{
            //    tbxSendData.Text = HexToASCII(tbxSendData.Text);
            //}
        }

        private void rbtSendHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSendHex.Checked)
             {
                 tbxSendData.Text = ASCIIToHex(tbxSendData.Text.ToString());
             } 
        }

        private void tbxReceivedData_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Byte[] data = new byte[41] { 0xA0, 0x01, 0x02, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA6 };
            Byte[] BSendTemp = new Byte[1];
            for (int i = 0; i < 41; i++)
            {
                BSendTemp[0] = data[i];
                sp.Write(BSendTemp, 0, 1);
            }
            statusLabel1.Text = "脱水指令发送成功！";
        }


        //强制停止执行
        private void button2_Click(object sender, EventArgs e)
        {
            Byte[] data = new byte[41] { 0xA0, 0x01, 0x02, 0x00, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA6 };
            Byte[] BSendTemp = new Byte[1];
            for (int i = 0; i < 41; i++)
            {
                BSendTemp[0] = data[i];
                sp.Write(BSendTemp, 0, 1);
            }
            statusLabel1.Text = "强制停止指令发送成功！";
        }

        private void cbxBaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Byte[] data = new byte[41] { 0xA0, 0x01, 0x02, 0x03, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA8 };
            Byte[] BSendTemp = new Byte[1];
            for (int i = 0; i < 41; i++)
            {
                BSendTemp[0] = data[i];
                sp.Write(BSendTemp, 0, 1);
            }
            statusLabel1.Text = "标准洗衣指令发送成功！";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Byte[] data = new byte[41] { 0xA0, 0x01, 0x02, 0x02, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA7 };
            Byte[] BSendTemp = new Byte[1];
            for (int i = 0; i < 41; i++)
            {
                BSendTemp[0] = data[i];
                sp.Write(BSendTemp, 0, 1);
            }
            statusLabel1.Text = "快速洗衣指令发送成功！";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Byte[] data = new byte[41] { 0xA0, 0x01, 0x02, 0x04, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA9 };
            Byte[] BSendTemp = new Byte[1];
            for (int i = 0; i < 41; i++)
            {
                BSendTemp[0] = data[i];
                sp.Write(BSendTemp, 0, 1);
            }
            statusLabel1.Text = "大件物品指令发送成功！";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Byte[] data = new byte[41] { 0xA0, 0x01, 0x02, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA6 };
            Byte[] BSendTemp = new Byte[1];
            for (int i = 0; i < 41; i++)
            {
                BSendTemp[0] = data[i];
                sp.Write(BSendTemp, 0, 1);
            }
            statusLabel1.Text = "测试脱水指令发送成功！";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Byte[] data = new byte[41] { 0xA0, 0x01, 0x02, 0x00, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA6 };
            Byte[] BSendTemp = new Byte[1];
            for (int i = 0; i < 41; i++)
            {
                BSendTemp[0] = data[i];
                sp.Write(BSendTemp, 0, 1);
            }
            statusLabel1.Text = "强制停止指令发送成功！";
        }
    }
}
