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
    public partial class MainForm : Form
    {
        #region 窗口传值（username）
        private string something;
        public string Something
        {
            get //读
            {
                return something;
            }
            set //写
            {
                something = value;
            }
        }
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
            Environment.Exit(0);
        }

        private void StaffInfoInsertBtn_Click(object sender, EventArgs e)
        {
            UserEnter staffs = new UserEnter();
            staffs.Owner = this;
            staffs.ShowDialog();
        }

        private void SellInfoInsertBtn_Click(object sender, EventArgs e)
        {
            SellEnter sells = new SellEnter();
            sells.Owner = this;
            sells.ShowDialog();
        }

        private void StoreInfoInsertBtn_Click(object sender, EventArgs e)
        {
            StockEnter stocks = new StockEnter();
            stocks.Owner = this;
            stocks.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.UserName.Text = something;
            if(something.CompareTo("rootMa") == 0 )
            {
                securityLabel.Text = "IT运维人员，具有所有权限";
            }else if(something.CompareTo("adminMa") == 0)
            {
                securityLabel.Text = "负责人，具有对员工信息、销售信息、进货信息、商品信息、库存信息的查询权限";
            }else if(something.CompareTo("staffMa") == 0)
            {
                securityLabel.Text = "人事管理人员，具有对员工信息的所有增删改查权限";
            }else if(something.CompareTo("sellMa") == 0)
            {
                securityLabel.Text = "销售管理人员，具有对销售信息、商品信息、库存信息的所有增删改查权限";
            }else if(something.CompareTo("stockMa") == 0)
            {
                securityLabel.Text = "仓储管理人员，具有对进货信息、商品信息、库存信息的所有增删改查权限";
            }
        }

        #region 库存信息查询
        private void InventorySelectBtn_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Owner = this;
            inventory.ShowDialog();
        }
        #endregion 
    }
}
