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
        public GoodsInsert()
        {
            InitializeComponent();
        }

        private void GoodsInsert_Load(object sender, EventArgs e)
        {
            if(Form.ActiveForm.Name.CompareTo("商品信息更新") == 0)  //载入商品原始信息
            {

            }
        }
    }
}
