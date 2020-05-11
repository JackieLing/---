using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实例8__3
{
    public partial class 温度监控 : Form
    {
        Random r = new Random();
        TemperatureWaring tw = new TemperatureWaring();
        public 温度监控()
        {
            InitializeComponent();
            //第四步 订阅事件
            tw.OnWarning += new TemperatureWaring.TemperatureHandler(Tw_OnWarning);
        }

        
 

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nowTemp;
            if (txtTemp.Text == "")
                nowTemp = 35;
            else
                nowTemp = Convert.ToInt32(txtTemp.Text);
            int change = r.Next(-2, 3);
            txtTemp.Text = (change + nowTemp).ToString();
            //第五步 触发事件
            tw.Monitor(change + nowTemp);
        }


        //第三步 声明事件时调用方法
        private void Tw_OnWarning(object sender, TemperatureEventArgs e)
        {
            if (e.Temperate < 35)
            {
                lblShow.Text = "正常";
                lblColor.BackColor = Color.Blue;
            }
            else if (e.Temperate < 37)
            {
                lblShow.Text = "高温黄色预警";
                lblColor.BackColor = Color.Yellow;
            }
            else if (e.Temperate < 40)
            {
                lblShow.Text = "高温橙色预警";
                lblColor.BackColor = Color.Orange;
            }
            else if (e.Temperate < 37)
            {
                lblShow.Text = "高温红色预警";
                lblColor.BackColor = Color.Red;
            }
        }
    }

    
}


//第一步 定义事件相关信息类
class TemperatureEventArgs : EventArgs
    {
        private int temperature;
        //TemperatureEventArgs是一个类
        public TemperatureEventArgs(int temperature)//声明构造函数
        {
            this.temperature = temperature;
        }

        public int Temperate//定义只读属性
        {//专门定义一个Temperature方法来返回数据
            get
            {
                return temperature;
            }
        }
    }


//第二步：定义事件警报器
class TemperatureWaring
    {
        //1.声明委托类型
        public delegate void TemperatureHandler(object sender, TemperatureEventArgs e);

        //2.声明温度预警事件
        public event TemperatureHandler OnWarning;

        //3.开始监控气温，同时发布事件
        public void Monitor(int tp)
        {
            TemperatureEventArgs e = new TemperatureEventArgs(tp);
            if (OnWarning != null)
            {
                OnWarning(this, e);
            }
        }
    }

