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
    public partial class Update_Staff : Form
    {
        Boolean isUpdate = false;
        public Update_Staff()
        {
            InitializeComponent();
        }

        #region 填充原值
        public void setValue(string staffid, string staffname, string staffgender, string staffage, string stafftype)
        {
            textBox1.Text = staffid;
            textBox2.Text = stafftype;
            textBox3.Text = staffage;
            textBox4.Text = staffgender;
            textBox5.Text = staffname;
            isUpdate = true;
            textBox1.ReadOnly = true;
        }
        #endregion

        #region 点击按钮更新员工信息表
        private void update_Click(object sender, EventArgs e)
        {
            string staffid = textBox1.Text;
            string stafftype = textBox2.Text;
            string staffage = textBox3.Text;
            string staffgender = textBox4.Text;
            string staffname = textBox5.Text;
            if (isUpdate)
            {
                string SQLString1 = "update staffInfo set staffid='" + staffid + "', staffname = '"
                    + staffname + "',staffgender = '"
                    + staffgender + "', staffage = " + staffage + ",staffType = '" + stafftype + "' where staffid =" + staffid;
                goods_methods.ExecuteSql(SQLString1);
                string string1 = "您所更新的数据已更新成功！";
                string string2 = "更新成功";
                DialogResult result = MessageBox.Show(string1, string2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                }
            }
            else
            {
                string SQLString2 = "insert into  staffInfo values('" + staffid + "','" + staffname
                    + "','" + staffgender + "','" + staffage + "','" + stafftype + "')";
                goods_methods.ExecuteSql(SQLString2);
            }
        }
        #endregion
    }
}
