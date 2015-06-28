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
    public partial class GoodsInsert : Form
    {
        public string mgoodsid = string.Empty;
        public string mgoodsname = string.Empty;
        public string mgoodsprice = string.Empty;
        public string mgoodsphotoid = string.Empty;
        GoodsList goodslist = new GoodsList();
        public GoodsInsert()
        {
            InitializeComponent();
        }

        public void flush()
        {
            if (mgoodsid != string.Empty)
            {
                this.id_text.Text = mgoodsid;
                this.name_text.Text = mgoodsname;
                this.price_text.Text = mgoodsprice;
                this.photoid_comboBox.Text = mgoodsphotoid;
                this.id_text.ReadOnly = true;
            }
        }

        private void GoodsInsert_Load(object sender, EventArgs e)
        {
            string SQLString = "select goodsphotoid as sid from goodsphoto";
            photoid_comboBox.DisplayMember = "sid";
            photoid_comboBox.ValueMember = "sid";
            photoid_comboBox.DataSource = goods_methods.Query(SQLString).Tables[0];
        }

        private void commitBtn_Click(object sender, EventArgs e)
        {
            //检查是否填写完整
            if (id_text.Text == "")
            {
                MessageBox.Show("商品编号不能为空！");
                return;
            }
            if (name_text.Text == "")
            {
                MessageBox.Show("商品名称不能为空！");
                return;
            }
            if (price_text.Text == "")
            {
                MessageBox.Show("单价不能为空！");
                return;
            }
            if (photoid_comboBox.Text == "")
            {
                MessageBox.Show("商品图片不能为空！");
                return;
            }
            //更新、插入操作
            if (mgoodsid != string.Empty)  //更新
            {
                try
                {
                    string SQLString = "update goodsInfo set  goodsname = '"
                        + name_text.Text + "',goodsprice = "
                        + price_text.Text + ", goodsphotoid =" + photoid_comboBox.Text
                        + " where goodsid= '" + mgoodsid + "'";
                    goods_methods.ExecuteSql(SQLString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                goodslist.flush();
                this.Close();
            }
            else //插入
            {
                try
                {
                    string SQLString = "insert into  goodsInfo values('" + id_text.Text + "','" + name_text.Text
                        + "','" + price_text.Text + "','" + photoid_comboBox.Text + "')";
                    goods_methods.ExecuteSql(SQLString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                goodslist.flush();
                this.Close();
            }
            
        }
    }
}
