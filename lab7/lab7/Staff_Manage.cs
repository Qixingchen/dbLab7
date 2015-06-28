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

        private void Sell_Inquire_Click(object sender, EventArgs e)
        {

        }
    }
}
