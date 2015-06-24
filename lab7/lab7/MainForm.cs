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
        public MainForm()
        {
            InitializeComponent();
        }

        public void flush()
        {
            goods_methods getname = new goods_methods();
            string userName = getname.getUserName();
            this.UserName.Text = userName;

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
    }
}
