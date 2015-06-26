using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Inventory : Form
    {
        BindingSource bindingSource = new BindingSource();
        public Inventory()
        {
            InitializeComponent();

            dataGridView1.DataSource = bindingSource;
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void inquire_Click(object sender, EventArgs e)
        {
            if (selectName != null)
            {
                bindingSource.DataSource = goods_methods.getInstance()
                    .getInventoryInfo();
            }
        }
    }
}
