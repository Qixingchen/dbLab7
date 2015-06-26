using System.ComponentModel;
using System.Windows.Forms;

namespace lab7
{
    partial class ProductInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.insert);
            this.groupbox.Controls.Add(this.delete);
            this.groupbox.Controls.Add(this.update);
            this.groupbox.Controls.Add(this.search);
            this.groupbox.Controls.Add(this.textBox1);
            this.groupbox.Location = new System.Drawing.Point(43, 32);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(1208, 150);
            this.groupbox.TabIndex = 0;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "商品信息管理";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(784, 59);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(176, 50);
            this.delete.TabIndex = 3;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(548, 59);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(192, 50);
            this.update.TabIndex = 2;
            this.update.Text = "更新";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(310, 59);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(199, 50);
            this.search.TabIndex = 1;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 35);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(998, 59);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(168, 50);
            this.insert.TabIndex = 4;
            this.insert.Text = "插入";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 645);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupbox);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ProductInfo";
            this.Text = "ProductInfo";
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button insert;
        private GroupBox groupbox;
        private Button delete;
        private Button update;
        private Button search;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn goodid;
        private DataGridViewTextBoxColumn goodsname;
        private DataGridViewTextBoxColumn goodscount;
        private DataGridViewTextBoxColumn goodprice;
        private DataGridViewTextBoxColumn goodphotoid;
    }
}