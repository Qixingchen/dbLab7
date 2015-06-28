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
    public partial class Update_Purchase : Form
    {
        Boolean isUpdate = false;
        public Update_Purchase()
        {
            InitializeComponent();
        }

        #region 填充原值
        public void setValue(string stockid, string stocktime, string goodscount, string goodsid, string staffid)
        {
            textBox1.Text = stockid;
            textBox2.Text = stocktime;
            textBox3.Text = goodscount;
            textBox4.Text = goodsid;
            textBox5.Text = staffid;
            isUpdate = true;
            textBox1.ReadOnly = true;
        }
        #endregion

        private void Update_Parchase_Load(object sender, EventArgs e)
        {

        }

        #region 点击按钮更新进货信息表
        private void Update_Click(object sender, EventArgs e)
        {
            string stockid = textBox1.Text;
            string stocktime = textBox2.Text;
            string goodscount = textBox3.Text;
            string goodsid = textBox4.Text;
            string staffid = textBox5.Text;
            if (isUpdate)
            {
                string SQLString1 = "update stockInfo set stockid='" + stockid + "', stocktime = '"
                    + stocktime + "',goodscount = "
                    + goodscount + ", goodsid ='" + goodsid + "',staffid = '" + staffid +"' where stockid =" + stockid;
                goods_methods.ExecuteSql(SQLString1);
                string string1 = "您所更新的数据已更新成功！";
                string string2 = "更新成功";
                DialogResult result = MessageBox.Show(string1,string2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    this.Hide();
                }
            }
            else
            {
                string SQLString2 = "insert into  stockInfo values('" + stockid + "','" + stocktime
                    + "','" + goodscount + "','" + goodsid + "','" + staffid + "')";
                goods_methods.ExecuteSql(SQLString2);
            }
        }
        #endregion
    }
}
