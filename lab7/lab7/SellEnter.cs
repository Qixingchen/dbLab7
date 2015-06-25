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

        private void SellEnter_Load(object sender, EventArgs e)
        {

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
         private void button1_Click(object sender, EventArgs e)
        {
            String sellid;
            String selltime;    
            String goodsid;
            String sellcount;
            String payment;
            String staffid;

            sellid = textBox1.Text;  //获取窗口数据
            goodsid = textBox2.Text;
            sellcount = textBox3.Text;
            payment = textBox4.Text;
            staffid = textBox5.Text;
            selltime = dateTimePicker1.Text;

            string sql = "insert into sellInfo values(" + sellid + "," + selltime + "," + goodsid + "," + sellcount + "," + payment + "," + staffid + ")";
            DBUtility.DbHelperSQL.ExecuteSql(sql);    

        }  
    }
}
