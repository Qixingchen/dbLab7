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
    public partial class UpdateProduct : Form
    {
        Boolean isUpdate = false;
        public UpdateProduct()
        {
            InitializeComponent();
        }
        public void setValue(string goodsid1, string goodsname, string goodsprice, string goodsphotoid, string photourl)
        {
            textBox1.Text = goodsid1;
            textBox2.Text = goodsname;
            textBox4.Text = goodsprice;
            comboBox1.Text = goodsphotoid;
            isUpdate = true;
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string goodsid1 = textBox1.Text;
            string goodsname = textBox2.Text;
            string goodscount = textBox3.Text;
            string goodsprice = textBox4.Text;
            string goodsphotoid = comboBox1.Text;
            if (isUpdate)
            {
                string SQLString2 = "update goodsInfo set goodsid=" + goodsid1 + ", goodsname = '" 
                    + goodsname + "',goodsprice = " 
                    + goodsprice + ", goodsphotoid =" + goodsphotoid + " where goodsid=" + goodsid1;
                goods_methods.ExecuteSql(SQLString2);
            }
            else
            {
                string SQLString4 = "insert into  goodsInfo values('" + goodsid1 + "','" + goodsname 
                    + "','" + goodsprice + "','" + goodsphotoid + "')";
                goods_methods.ExecuteSql(SQLString4);
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            string SQLString = "select goodsphotoid as sid from goodsphoto";
            comboBox1.DisplayMember = "sid";
            comboBox1.ValueMember = "sid";
            comboBox1.DataSource = goods_methods.Query(SQLString).Tables[0];
        }
    }
}
