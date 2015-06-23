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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //检查是否填写完整
            if (userName.Text == "")
            {
                MessageBox.Show("用户名称不能为空！");
                return;
            }
            if (userPwd.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            //检查登录状态，相关函数封装在 goods_methods
            if (S_enter.tb_JoinChoice(userName.Text, userPwd.Text) == 1)
            {
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("无访问权利，登录失败！");
            }
        }
    }
}
