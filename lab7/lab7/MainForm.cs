using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class MainForm : Form
    {
     
        #region 窗口传值（username）
        private string userType;
        private string userNameString;

        public string UserNameString
        {
            get //读
            {
                return userNameString;
            }
            set //写
            {
                userNameString = value;
            }
        }

        public string UserType
        {
            get //读
            {
                return userType;
            }
            set //写
            {
                userType = value;
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
            this.UserName.Text = userNameString;
            if(userType.CompareTo("rootMa") == 0 )
            {
                securityLabel.Text = "IT运维人员，具有所有权限";
            }else if(userType.CompareTo("adminMa") == 0)
            {
                securityLabel.Text = "负责人，具有对员工信息、销售信息、进货信息、商品信息、库存信息的查询权限";
            }else if(userType.CompareTo("staffMa") == 0)
            {
                securityLabel.Text = "人事管理人员，具有对员工信息的所有增删改查权限";
            }else if(userType.CompareTo("sellMa") == 0)
            {
                securityLabel.Text = "销售管理人员，具有对销售信息、商品信息、库存信息的所有增删改查权限";
            }else if(userType.CompareTo("stockMa") == 0)
            {
                securityLabel.Text = "仓储管理人员，具有对进货信息、商品信息、库存信息的所有增删改查权限";
            }
        }


        private void SellInfoActBtn_Click(object sender, EventArgs e)
        {
            SellInfo sellinfo = new SellInfo();
            sellinfo.Owner = this;
            sellinfo.ShowDialog();
        }


        #region 库存信息查询
        private void InventorySelectBtn_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Owner = this;
            inventory.ShowDialog();
        }
        #endregion 

        #region 商品清单
        private void button1_Click(object sender, EventArgs e)
        {
            GoodsList goodslist = new GoodsList();
            goodslist.Owner = this;
            goodslist.flush();
            goodslist.ShowDialog();
        }
        #endregion

        #region 员工信息录入
        private void staffInfoBtn_Click(object sender, EventArgs e)
        {
            UserEnter userenter = new UserEnter();
            userenter.Owner = this;
            userenter.ShowDialog();
        }
        #endregion
    }
}
