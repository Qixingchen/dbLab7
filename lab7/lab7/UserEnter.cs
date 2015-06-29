using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class UserEnter : Form
    {
        public UserEnter()
        {
            InitializeComponent();
        }

        public void flush()
        {
            id_text.Text = string.Empty;
            name_text.Text = string.Empty;
            staffType_text.Text = string.Empty;
            gender_text.Text = string.Empty;
            age_text.Text = string.Empty;
        }

        private void On_Load(object sender, EventArgs e)
        {
            staffType_text.DisplayMember = "Text";
            staffType_text.ValueMember = "Value";

            var items = new[] { 
                new { Text = "IT运维", Value = "root" }, 
                new { Text = "人事管理", Value = "staff" }, 
                new { Text = "仓储管理", Value = "stock" },
                new { Text = "销售管理", Value = "sell" },
                new { Text = "负责人", Value = "admin" }
            };

            staffType_text.DataSource = items;
        }

        private void commitBtn_Click(object sender, EventArgs e)
        {
            String staffType;
            String staffID;
            String staffname;
            String staffgender;
            String staffage;

            staffID = id_text.Text;
            staffType = (string) staffType_text.SelectedValue;  //获取窗口数据
            staffname = name_text.Text;
            staffage = age_text.Text;
            staffgender = gender_text.Text;

            if (goods_methods.getInstance().AddUser(staffID, staffname, staffage, staffgender, staffType) != 0)
            {
                this.flush();
            }
            else
            {
                MessageBox.Show("录入不成功！");
                return;
            }

            //string sql = "insert into staffinfo values(" + staffType + "," + "'"+staffname+"'" + "," + "'"+staffgender +"'"+ "," + staffage + ")";
            //goods_methods.ExecuteSql(sql);

            //Popup popup = new Popup();
            //popup.ShowDialog();


        }



    }
}
