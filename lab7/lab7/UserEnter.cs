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

        private void On_Load(object sender, EventArgs e)
        {
            staffTypeSelect.DisplayMember = "Text";
            staffTypeSelect.ValueMember = "Value";

            var items = new[] { 
    new { Text = "IT运维", Value = "root" }, 
    new { Text = "人事管理", Value = "staff" }, 
    new { Text = "仓储管理", Value = "stock" },
    new { Text = "销售管理", Value = "sell" },
    new { Text = "负责人", Value = "admin" }
};

            staffTypeSelect.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String staffType;
            String staffID;
            String staffname;
            String staffgender;
            String staffage;

            staffID = staffIDBox.Text;
            staffType = (string) staffTypeSelect.SelectedValue;  //获取窗口数据
            staffname = textBox2.Text;
            staffage = textBox3.Text;
            staffgender = comboBox1.Text;

            goods_methods.getInstance().AddUser(staffID, staffname, staffage, staffgender, staffType);

            //string sql = "insert into staffinfo values(" + staffType + "," + "'"+staffname+"'" + "," + "'"+staffgender +"'"+ "," + staffage + ")";
            //goods_methods.ExecuteSql(sql);

            Popup popup = new Popup();
            popup.ShowDialog();


        }



    }
}
