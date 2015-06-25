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
    public partial class StockEnter : Form
    {
        public StockEnter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String stockid;
            String stocktime;
            String goodsid;
            String goodsname;
            String goodscount;
            String goodsprice;
            String goodsphotoid;
            String photourl;
            String staffid;

            stockid = textBox1.Text;  //获取窗口数据
            goodsid = textBox2.Text;
            goodsname = textBox3.Text;
            goodscount = textBox4.Text;
            goodsprice = textBox5.Text;
            goodsphotoid = textBox6.Text;
            photourl = textBox7.Text;
            staffid = textBox8.Text;
            stocktime = dateTimePicker1.Text;

            string sql = "insert into goodsinfo values(" + goodsid + "," + goodsname + "," + goodscount + "," + goodsprice + "," + goodsphotoid + ")";
            DBUtility.DbHelperSQL.ExecuteSql(sql);
            sql = "insert into goodsphoto values(" + goodsphotoid + "," + photourl + "," + goodsid + ")";
            DBUtility.DbHelperSQL.ExecuteSql(sql);
            sql = "insert into stockinfo values(" + stockid + "," + stocktime + "," + goodscount + "," + goodsid + "," + staffid + ")";
            DBUtility.DbHelperSQL.ExecuteSql(sql);
        }
        //Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\jiyu\net\dblab7\databaseLab7\lab7\db\Goods.mdf;Integrated Security=True;Connect Timeout=30
    }
}
