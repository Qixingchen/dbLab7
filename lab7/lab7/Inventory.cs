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
    public partial class Inventory : Form
    {
        BindingSource bindingSource = new BindingSource();
        public Inventory()
        {
            InitializeComponent();

            dataGridView1.DataSource = bindingSource;
        }


        private void inquire_Click(object sender, EventArgs e)
        {
            if (selectName != null)
            {
                bindingSource.DataSource = goods_methods.getInstance()
                    .getInventoryInfo();
            }

            // Resize the DataGridView columns to fit the newly loaded content.
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
    }
}
