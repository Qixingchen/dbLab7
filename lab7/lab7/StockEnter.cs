using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class StockEnter : Form
    {
        public StockEnter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String stockid;
            String stocktime;
            String goodsid;
            String goodscount;
            String staffid;

            stockid = textBox1.Text;  //获取窗口数据
            goodsid = textBox2.Text;
            goodscount = textBox4.Text;
            staffid = textBox8.Text;
            stocktime = dateTimePicker1.Value.ToString();

            string sql = "insert into stockinfo values(" + stockid + "," + "'" + stocktime + "'" + "," + goodscount + "," + goodsid + "," + staffid + ")";
            int result = goods_methods.ExecuteSql(sql);

            if (result != 0)
            {
                Popup popup = new Popup();
                popup.ShowDialog();
            }

        }
    }
}
