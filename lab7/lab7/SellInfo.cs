using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab7
{
    public partial class SellInfo : Form
    {
        BindingSource bindingSource = new BindingSource();
        public SellInfo()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = goods_methods.getInstance().querySellInfo(Textbox1.Text);
        }

        private void update_Click(object sender, EventArgs e)
        {
            SellEnter sells = new SellEnter();
            sells.Owner = this;
            string sellid = Textbox1.Text;
            string SQLString = "select * from sellInfo where sellid=" + sellid;
            SqlDataReader reader = goods_methods.ExecuteReader(SQLString);
            reader.Read();
            DateTime selltime = reader.GetDateTime(1);
            string sellcount = reader.GetInt16(2).ToString();
            string payment = reader.GetInt16(3).ToString();
            string goodsid = reader.GetString(4);
            string staffid = reader.GetString(5);
            reader.Close();
            sells.setValue(sellid, selltime, sellcount, payment, goodsid, staffid);
            sells.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string sellid = Textbox1.Text;
            string caption = "删除销售信息";
            string text = "您确定要删除销售ID为" + sellid + "的销售信息？删除后将无法恢复";
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.OK:
                    //删除操作      
                    string SQLString = "delete from sellInfo where sellid=" + sellid;
                    goods_methods.ExecuteSql(SQLString);
                    break;
            }
        }

        private void SellInfo_Load(object sender, EventArgs e)
        {
        }
        

    }
}
