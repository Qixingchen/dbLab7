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
    public partial class SellInfo : Form
    {
        public SellInfo()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
 //           DataSet dataset = goods_methods.querySellInfo(Textbox1.Text);
 //           dataGridView1.
        }

        private void update_Click(object sender, EventArgs e)
        {
            SellEnter sells = new SellEnter();
            sells.Owner = this;
            string sellid = "123";
            DateTime selltime = new DateTime(2015,5,14);
            string sellcount = "2";
            string payment = "10";
            string goodsid ="234";
            string staffid = "1001";
            sells.setValue(sellid, selltime, sellcount, payment, goodsid,staffid);
            sells.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id=Textbox1.Text;
            string caption = "删除销售信息";
            string text = "您确定要删除销售ID为" + id + "的销售信息？删除后将无法恢复";
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
//删除操作
                    break;
            }
        }






    }
}
