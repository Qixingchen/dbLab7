using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab7
{
    public partial class SellInfo : Form
    {
        private int row = -1;
        BindingSource bindingSource = new BindingSource();
        public SellInfo()
        {
            InitializeComponent();
            sell_dataGridView.DataSource = bindingSource;
            sell_dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(key_words.Text == "")
            {
                bindingSource.DataSource = goods_methods.getInstance().querySellInfo(key_words.Text, 1);
                select_row(row);
                return;
            }
            bindingSource.DataSource = goods_methods.getInstance().querySellInfo(key_words.Text,2);
            select_row(0);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(row < 0)
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }
            SellEnter sells = new SellEnter();
            sells.Owner = this;
            string sellid = sell_dataGridView.Rows[row].Cells["销售ID"].Value.ToString();
            string SQLString = "select * from sellInfo where sellid=" + sellid;
            SqlDataReader reader = goods_methods.ExecuteReader(SQLString);
            reader.Read();
            DateTime selltime = reader.GetDateTime(1);
            string sellcount = reader.GetInt16(2).ToString();
            string payment = reader.GetSqlMoney(3).ToString();
            string goodsid = reader.GetString(4);
            string staffid = reader.GetString(5);
            reader.Close();
            sells.setValue(sellid, selltime, sellcount, payment, goodsid, staffid);
            sells.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (row < 0)
            {
                MessageBox.Show("请选择要删除的行");
                return;
            }
            string msellid = sell_dataGridView.Rows[row].Cells["销售ID"].Value.ToString();
            string caption = "删除销售信息";
            string text = "您确定要删除销售ID为" + msellid + "的销售信息？删除后将无法恢复";
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.OK:
                    //删除操作
                    string SQLString = "delete from sellInfo where sellid=" + msellid;
                    goods_methods.ExecuteSql(SQLString);
                    break;
            }
            SellInfo_Load(null,null);
        }

        private void SellInfo_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = goods_methods.getInstance().querySellInfo("", 1);
        }
        private void select_row(int location)
        {
            if (location < 0)
            {
                return;
            }
            row = location;
        }

        private void sell_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            select_row(e.RowIndex);
        }

        private void sell_dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            select_row(e.RowIndex);
        }
    }
}
