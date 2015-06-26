using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace lab7
{
    public partial class ProductInfo : Form
    {
        BindingSource bindingSource = new BindingSource();
        public ProductInfo()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource;
        }

        private void search_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = goods_methods.getInstance().queryProductInfo(textBox1.Text);
        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateProduct updateproduct = new UpdateProduct();
            updateproduct.Owner = this;
            string goodsid = textBox1.Text;
            string SQLString = "select * from goodsInfo where goodsid=" + goodsid;
            SqlDataReader reader = goods_methods.ExecuteReader(SQLString);
            reader.Read();
            string goodsid1 = reader.GetString(1);
            string goodsname = reader.GetString(2);
            string goodscount = reader.GetInt16(3).ToString();
            string goodsprice = reader.GetInt16(4).ToString();
            string goodsphotoid = reader.GetString(5);
            reader.Close();
            string SQLString1 = "select * from goodsphoto where goodsphotoid=" + goodsphotoid;
            SqlDataReader reader1 = goods_methods.ExecuteReader(SQLString1);
            reader1.Read();
            string photourl = reader1.GetString(2);
            reader1.Close();
            updateproduct.setValue(goodsid1, goodsname, goodscount, goodsprice, goodsphotoid, photourl);
            updateproduct.ShowDialog();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            UpdateProduct updateproduct = new UpdateProduct();
            updateproduct.Owner = this;
            updateproduct.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string goodsid = textBox1.Text;
            string caption = "删除商品信息";
            string text = "您确定要删除商品ID为" + goodsid + "的商品信息？删除后将无法恢复";
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.OK:
                    //删除操作  
                    string SQLString1 = "delete from stockInfo where goodsid=" + goodsid;
                    goods_methods.ExecuteSql(SQLString1);
                    string SQLString2 = "delete from sellInfo where goodsid=" + goodsid;
                    goods_methods.ExecuteSql(SQLString2);
                    string SQLString3 = "delete from goodsInfo where goodsid=" + goodsid;
                    goods_methods.ExecuteSql(SQLString3);
                    break;
            }
        }
    }
}
