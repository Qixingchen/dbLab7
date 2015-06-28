using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AcceptButton = LoginBtn;
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
            if (goods_methods.getInstance().LoginCheck(userName.Text, userPwd.Text)
                == true)
            {
                MainForm form = new MainForm();
                form.UserType = goods_methods.getInstance().getUserType(userName.Text);
                form.UserNameString = userName.Text;
                
                form.Show();
                this.Hide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
