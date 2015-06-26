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
        //private int row;
        BindingSource bindingSource = new BindingSource();
        public GoodsList()
        {
            InitializeComponent();
            goods_dataGridView.DataSource = bindingSource;
        }

        private void GoodsList_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = 
                goods_methods.getInstance().getGoodsInfo(1, "");
        }

        private void GoodsSelectBtn_Click(object sender, EventArgs e)
        {
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
            /*if (StudentDataIDSelected == string.Empty)
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }
            goodsedit.StudentID =
                 goods_dataGridView.Rows[row].Cells["SNO"].Value.ToString();

            goodsedit.StudentName =
                goods_dataGridView.Rows[row].Cells["SNAME"].Value.ToString();

            goodsedit.StudentGrade =
                goods_dataGridView.Rows[row].Cells["GRADE"].Value.ToString();

            goodsedit.StudentEmail =
                goods_dataGridView.Rows[row].Cells["EMAIL"].Value.ToString();*/
            goodsedit.ShowDialog();
        }

        private void GoodsDeleteBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
