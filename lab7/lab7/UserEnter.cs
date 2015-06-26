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
    public partial class UserEnter : Form
    {
        public UserEnter()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            String staffid;
            String staffname;
            String staffgender;
            String staffage;

            staffid = textBox1.Text;  //获取窗口数据
            staffname = textBox2.Text;
            staffage = textBox3.Text;
            staffgender = comboBox1.Text;

            string sql = "insert into staffinfo values(" + staffid + "," + "'"+staffname+"'" + "," + "'"+staffgender +"'"+ "," + staffage + ")";
            goods_methods.ExecuteSql(sql);

            Popup popup = new Popup();
            popup.ShowDialog();


        }

    }
}
