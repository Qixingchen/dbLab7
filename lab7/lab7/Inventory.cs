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
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            // Resize the DataGridView columns to fit the newly loaded content.
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }


        private void inquire_Click(object sender, EventArgs e)
        {
            if (selectName.Text.CompareTo("") == 0)
            {
                bindingSource.DataSource = goods_methods.getInstance()
                    .getInventoryInfo();
            }
            else
            {
                bindingSource.DataSource = goods_methods.getInstance()
                    .getInventoryInfo(selectName.Text);
            }            
        }
    }
}
