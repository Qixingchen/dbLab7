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
        public void flush()
        {
            id_text.Text = string.Empty;
            name_text.Text = string.Empty;
            count_text.Text = string.Empty;
            payment_text.Text = string.Empty;
            staff_id.Text = string.Empty;
        }
        private void SellEnter_Load(object sender, EventArgs e)
        {

            string SQLString = "select goodsid as sid from goodsInfo";
            name_text.DisplayMember = "sid";
            name_text.ValueMember = "sid";
            DataSet dataset = goods_methods.Query(SQLString);
            if (dataset==null)
            {
                Hide();
                return;
            }
            name_text.DataSource = dataset.Tables[0];
            
            SQLString = "select staffid as sid1 from staffInfo";
            staff_id.DisplayMember = "sid1";
            staff_id.ValueMember = "sid1";
            dataset = goods_methods.Query(SQLString);
            if (dataset == null)
            {
                this.Hide();
                return;
            }
            staff_id.DataSource = dataset.Tables[0];

        }
        public void setValue(string sellid, DateTime selltime, string sellcount, string payment, string goodsid, string staffid)
        {
            id_text.Text = sellid;
            name_text.Text = goodsid;
            payment_text.Text = payment;
            count_text.Text = sellcount;
            staff_id.Text = staffid;
            dateTimePicker1.Value = selltime;
            id_text.ReadOnly = true;
            isUpdate = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sellid = id_text.Text;
            string goodsid = name_text.Text;
            string payment = payment_text.Text;
            string sellcount = count_text.Text;
            string staffid = staff_id.Text;
            DateTime selltime = dateTimePicker1.Value;
            if (isUpdate)
            {
                string SQLString1 = "update sellInfo set sellid=" + sellid + ", goodsid = '" + goodsid + "', payment = " + payment + ",sellcount = " + sellcount + ", staffid =" + staffid + ",selltime = '" + selltime + "' where sellid=" + sellid;
                if (goods_methods.ExecuteSql(SQLString1) != 0)
                {
                    this.flush();
                }
            }
            else
            {
                string SQLString2 = "insert into  sellInfo values('" + sellid + "','" + selltime + "','" + sellcount + "','" + payment + "','" + goodsid + "','" + staffid + "')";
                if(goods_methods.ExecuteSql(SQLString2) != 0)
                {
                    this.flush();
                }
            }
        }
    }
}
