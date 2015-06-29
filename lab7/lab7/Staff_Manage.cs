using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab7
{
    public partial class Staff_Manage : Form
    {
        BindingSource bindingSource = new BindingSource();
        public Staff_Manage()
        {
            InitializeComponent();
            Staff_Info_Manage.DataSource = bindingSource;
        }

        private void Staff_Manage_Load(object sender, EventArgs e)
        {

        }

        private void Staff_Info_Manage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region 信息查询
        private void Info_Inquire_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = goods_methods.getInstance().queryStaffInfo(textBox1.Text);
        }
        #endregion

        #region 销售业绩查询
        private void Sell_Inquire_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = goods_methods.getInstance().queryStaffSellInfo(textBox1.Text);
            
        }
        #endregion

        #region 删除员工信息
        private void Delete_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")/*若输入为空则无法删除*/
            {
                MessageBox.Show("员工编号不能为空！");
            }
            else
            {
                string staffid = textBox1.Text;
                string SQLString1 = "select * from staffInfo where staffid = " + staffid;
                SqlDataReader reader = goods_methods.ExecuteReader(SQLString1);
                if(!reader.HasRows)/*不存在要删除的员工*/
                {
                    MessageBox.Show("不存在您要删除的员工信息");
                }
                else
                {
                    reader.Read();
                    string staffType = reader.GetString(4);
                    reader.Close();
                    /*判断员工类型是不是disable*/
                    if (staffType == "disable")
                    {
                        string caption1 = "删除警告";
                        string text1 = "没有您要删除的员工信息";
                        DialogResult result1 = MessageBox.Show(text1, caption1, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string caption = "删除员工信息";
                        string text = "您确定要将员工编号为" + staffid + "的员工信息删除？删除后将无法恢复";
                        DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        switch (result)
                        {
                            case DialogResult.OK: /*将员工类型更改为disable*/
                            string SQLString2 = "update staffInfo set staffType = " + "'disable'" + "where staffid = " + staffid;
                            goods_methods.ExecuteSql(SQLString2);
                            bindingSource.DataSource = goods_methods.getInstance().queryStaffInfo(textBox1.Text);
                            break;
                        }
                    }
                }
            }
        }
        #endregion

        #region 更新员工信息
        private void Update_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("员工编号不能为空！");
            }
            else
            {
                string staffid = textBox1.Text;
                string SQLString = "select * from staffInfo where staffid=" + staffid;
                SqlDataReader reader = goods_methods.ExecuteReader(SQLString);
                if(!reader.HasRows)
                {
                    MessageBox.Show("不存在您需要更新的员工信息");
                }
                else
                {
                    Update_Staff updatestaff = new Update_Staff();
                    updatestaff.Owner = this;
                    reader.Read();
                    string staffid1 = reader.GetString(0);
                    string staffname = reader.GetString(1);
                    string staffgender = reader.GetString(2);
                    string staffage = reader.GetSqlInt16(3).ToString();
                    string staffType = reader.GetString(4);
                    reader.Close();
                    updatestaff.setValue(staffid1, staffname, staffgender, staffage, staffType);
                    updatestaff.ShowDialog();
                }            
            }
        }
        #endregion

    }
}
