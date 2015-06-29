using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab7
{
    public partial class Purchase : Form
    {
        BindingSource bindingSource = new BindingSource();
        public Purchase()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource;
        }

        #region 查询
        private void button1_Click(object sender, EventArgs e)
        {
           
            bindingSource.DataSource = goods_methods.getInstance().queryPurchaseInfo(textBox1.Text);
        }
        #endregion

        #region 删除进货单信息
        private void Delete_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == "")
            {
                MessageBox.Show("进货编号不能为空");
            }
            else
            {
                string stockid = textBox1.Text;
                string SQLString = "select * from stockInfo where stockid=" + stockid;
                SqlDataReader reader = goods_methods.ExecuteReader(SQLString);
                if(!reader.HasRows)/*若表单需要删除的表单不存在*/
                {
                    MessageBox.Show("您所要删除的表单不存在");
                }
                else
                {
                    string caption = "删除进货信息";
                    string text = "您确定要将进货编号为" + stockid + "的商品信息删除？删除后将无法恢复";
                    DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    switch (result)
                    {
                        case DialogResult.OK: /*确认删除*/
                            string SQLString2 = "delete from stockInfo where stockid = " + stockid;
                            goods_methods.ExecuteSql(SQLString2);
                            break;
                    }
                }
            }
        }
        #endregion

        private void Purchase_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region 更新进货表
        private void Update_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("进货编号不能为空");
            }
            else
            {
                string stockid = textBox1.Text;
                string SQLString = "select * from stockInfo where stockid=" + stockid;
                SqlDataReader reader = goods_methods.ExecuteReader(SQLString);
                if (!reader.HasRows)/*需要更新的表单不存在*/
                {
                    MessageBox.Show("不存在您要更新的表单");
                }
                else
                {
                    Update_Purchase updatepurchase = new Update_Purchase();
                    updatepurchase.Owner = this;
                    reader.Read();
                    string stockid1 = reader.GetString(0);
                    string stocktime = reader.GetSqlDateTime(1).ToString();
                    string goodscount = reader.GetSqlInt16(2).ToString();
                    string goodsid = reader.GetString(3);
                    string staffid = reader.GetString(4);
                    reader.Close();
                    updatepurchase.setValue(stockid1, stocktime, goodscount, goodsid, staffid);
                    updatepurchase.ShowDialog();
                }
            }
        }
        #endregion
    }
}
