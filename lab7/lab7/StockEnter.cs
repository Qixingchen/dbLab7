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

        public void flush()
        {
            stockid_text.Text = string.Empty;
            goodsid_text.Text = string.Empty;
            count_text.Text = string.Empty;
            staffid_text.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String stockid;
            String stocktime;
            String goodsid;
            String goodscount;
            String staffid;

            stockid = stockid_text.Text;  //获取窗口数据
            goodsid = goodsid_text.Text;
            goodscount = count_text.Text;
            staffid = staffid_text.Text;
            stocktime = dateTimePicker1.Value.ToString();

            string sql = "insert into stockinfo values(" + stockid + "," + "'" + stocktime + "'" + "," + goodscount + "," + goodsid + "," + staffid + ")";
            int result = goods_methods.ExecuteSql(sql);

            if (result != 0)
            {
                this.flush();
            }
            else
            {
                MessageBox.Show("录入不成功！");
                return;
            }

        }
    }
}
