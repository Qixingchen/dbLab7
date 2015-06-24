using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class SellEnter : Form
    {
        public SellEnter()
        {
            InitializeComponent();
        }
        //潘晨星是猪你好 我是PLY 你在写下面这个函数的时候要判断一下加入的东西是新的还是更新的，因为我的更新界面也用的你的这个界面
        private void SellEnter_Load(object sender, EventArgs e)
        {

        }

        public void setValue(string sellid,DateTime selltime,string sellcount,string payment,string goodsid,string staffid)
        {
            textBox1.Text = sellid;
            textBox2.Text = goodsid;
            textBox4.Text = payment;
            textBox3.Text = sellcount;
            textBox5.Text = staffid;
            dateTimePicker1.Value = selltime;
        }
    }
}
