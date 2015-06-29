using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class GoodsInsert : Form
    {
        public string mgoodsid = string.Empty;
        public string mgoodsname = string.Empty;
        public string mgoodsprice = string.Empty;
        public string mgoodsphotoid = string.Empty;
        private GoodsList goodslist = null;
        public GoodsInsert(GoodsList goodslist)
        {
            this.goodslist = goodslist;
            InitializeComponent();
        }

        public void flush()
        {
            string SQLString = "select goodsphotoid as sid from goodsphoto";
            photoid_comboBox.DisplayMember = "sid";
            photoid_comboBox.ValueMember = "sid";
            photoid_comboBox.DataSource = goods_methods.Query(SQLString).Tables[0];
            if (mgoodsid != string.Empty)
            {
                this.id_text.Text = mgoodsid;
                this.name_text.Text = mgoodsname;
                this.price_text.Text = mgoodsprice;
                this.photoid_comboBox.Text = mgoodsphotoid;
                this.id_text.ReadOnly = true;
            }
        }

        public void setPhotoID(String ID)
        {
            mgoodsphotoid = ID;
            photoid_comboBox.Text = ID;
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
                string SQLString = "update goodsInfo set  goodsname = '"
                    + name_text.Text + "',goodsprice = "
                    + price_text.Text + ", goodsphotoid =" + photoid_comboBox.Text
                    + " where goodsid= '" + mgoodsid + "'";
                goods_methods.ExecuteSql(SQLString);

                goodslist.flush();
                this.Close();
            }
            else //插入
            {
                string SQLString = "insert into  goodsInfo values('" + id_text.Text + "','" + name_text.Text
                    + "','" + price_text.Text + "','" + photoid_comboBox.Text + "')";
                goods_methods.ExecuteSql(SQLString);

                goodslist.flush();
                this.Close();
            }

        }

        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
            photoUploadForm photoupload = new photoUploadForm(this);
            photoupload.Owner = this;
            photoupload.ShowDialog();
        }
    }
}
