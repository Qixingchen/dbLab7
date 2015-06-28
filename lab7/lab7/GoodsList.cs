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
    public partial class GoodsList : Form
    {
        private int row = -1;
        private string GoodsDataIDSelected;
        BindingSource bindingSource = new BindingSource();
        public GoodsList()
        {
            InitializeComponent();
            goods_dataGridView.DataSource = bindingSource;
        }

        public void flush()
        {
            bindingSource.DataSource =
                goods_methods.getInstance().getGoodsInfo(1, "");
        }

        private void GoodsSelectBtn_Click(object sender, EventArgs e)
        {
            if (goodsname_key.Text == "")
            {
                MessageBox.Show("搜索关键字不能为空！");
                return;
            }
            bindingSource.DataSource =
                    goods_methods.getInstance().getGoodsInfo(2, goodsname_key.Text);
        }

        private void GoodsInsertBtn_Click(object sender, EventArgs e)
        {
            GoodsInsert goodsinsert = new GoodsInsert();
            goodsinsert.Owner = this;
            goodsinsert.Text = "商品信息插入";
            goodsinsert.ShowDialog();
        }

        private void GoodsEditBtn_Click(object sender, EventArgs e)
        {
            GoodsInsert goodsedit = new GoodsInsert();
            goodsedit.Owner = this;
            goodsedit.Text = "商品信息更新";
            if (row < 0)
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }
            goodsedit.mgoodsid =
                 goods_dataGridView.Rows[row].Cells["商品编号"].Value.ToString();

            goodsedit.mgoodsname =
                goods_dataGridView.Rows[row].Cells["商品名称"].Value.ToString();

            goodsedit.mgoodsprice =
                goods_dataGridView.Rows[row].Cells["单价"].Value.ToString();

            goodsedit.mgoodsphotoid =
                goods_dataGridView.Rows[row].Cells["图片编号"].Value.ToString();
            row = -1;
            goodsedit.flush();
            goodsedit.ShowDialog();
        }

        private void GoodsDeleteBtn_Click(object sender, EventArgs e)
        {
            if (row < 0)
            {
                MessageBox.Show("请选择要删除的行");
                return;
            }
            string mgoodsid = goods_dataGridView.Rows[row].Cells["商品编号"].Value.ToString();
            string caption = "删除商品信息";
            string text = "您确定要删除商品ID为" + mgoodsid + "的商品信息？删除后将无法恢复";
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            try
            {
                switch (result)
                {
                    case DialogResult.OK:
                        //删除操作  (级联删除)
                        /*string SQLString1 = "delete from stockInfo where goodsid=" + mgoodsid;
                        goods_methods.ExecuteSql(SQLString1);
                        string SQLString2 = "delete from sellInfo where goodsid=" + mgoodsid;
                        goods_methods.ExecuteSql(SQLString2);*/
                        string SQLString3 = "delete from goodsInfo where goodsid=" + mgoodsid;
                        goods_methods.ExecuteSql(SQLString3);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.flush();

        }

        #region 定位选中的行
        private void goods_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            row_text.Text = row.ToString();
        }
        #endregion

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.flush();
        }

    }
}
