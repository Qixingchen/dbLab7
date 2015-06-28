using System;
using System.Data;
using System.Windows.Forms;

namespace lab7
{
    public partial class SellEnter : Form
    {
        Boolean isUpdate = false;
        public SellEnter()
        {
            InitializeComponent();
        }
        private void SellEnter_Load(object sender, EventArgs e)
        {

            string SQLString = "select goodsid as sid from goodsInfo";
            comboBox1.DisplayMember = "sid";
            comboBox1.ValueMember = "sid";
            DataSet dataset = goods_methods.Query(SQLString);
            if (dataset==null)
            {
                Hide();
                return;
            }
            comboBox1.DataSource = dataset.Tables[0];
            
            SQLString = "select staffid as sid1 from staffInfo";
            comboBox2.DisplayMember = "sid1";
            comboBox2.ValueMember = "sid1";
            dataset = goods_methods.Query(SQLString);
            if (dataset == null)
            {
                this.Hide();
                return;
            }
            comboBox2.DataSource = dataset.Tables[0];

        }
        public void setValue(string sellid, DateTime selltime, string sellcount, string payment, string goodsid, string staffid)
        {
            textBox1.Text = sellid;
            comboBox1.Text = goodsid;
            textBox4.Text = payment;
            textBox3.Text = sellcount;
            comboBox2.Text = staffid;
            dateTimePicker1.Value = selltime;
            textBox1.ReadOnly = true;
            isUpdate = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sellid = textBox1.Text;
            string goodsid = comboBox1.Text;
            string payment = textBox4.Text;
            string sellcount = textBox3.Text;
            string staffid = comboBox2.Text;
            DateTime selltime = dateTimePicker1.Value;
            if (isUpdate)
            {
                string SQLString1 = "update sellInfo set sellid=" + sellid + ", goodsid = '" + goodsid + "', payment = " + payment + ",sellcount = " + sellcount + ", staffid =" + staffid + ",selltime = '" + selltime + "' where sellid=" + sellid;
                goods_methods.ExecuteSql(SQLString1);
            }
            else
            {
                string SQLString2 = "insert into  sellInfo values('" + sellid + "','" + selltime + "','" + sellcount + "','" + payment + "','" + goodsid + "','" + staffid + "')";
                goods_methods.ExecuteSql(SQLString2);
            }
        }
    }
}
