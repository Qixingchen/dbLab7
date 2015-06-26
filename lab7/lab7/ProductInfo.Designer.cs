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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodphotoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox
            // 
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 35);
            this.textBox1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(405, 49);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(231, 50);
            this.search.TabIndex = 1;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(688, 49);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(215, 50);
            this.update.TabIndex = 2;
            this.update.Text = "更新";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(948, 49);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(217, 50);
            this.delete.TabIndex = 3;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.goodid,
            this.goodsname,
            this.goodscount,
            this.goodprice,
            this.goodphotoid});
            this.dataGridView1.Location = new System.Drawing.Point(43, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // goodid
            // 
            this.goodid.HeaderText = "商品ID";
            this.goodid.Name = "goodid";
            // 
            // goodsname
            // 
            this.goodsname.HeaderText = "商品名称";
            this.goodsname.Name = "goodsname";
            // 
            // goodscount
            // 
            this.goodscount.HeaderText = "商品数量";
            this.goodscount.Name = "goodscount";
            // 
            // goodprice
            // 
            this.goodprice.HeaderText = "商品价格";
            this.goodprice.Name = "goodprice";
            // 
            // goodphotoid
            // 
            this.goodphotoid.HeaderText = "商品图片ID";
            this.goodphotoid.Name = "goodphotoid";
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