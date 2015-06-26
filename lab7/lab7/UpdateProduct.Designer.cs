namespace lab7
{
    partial class UpdateProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.goodsid = new System.Windows.Forms.Label();
            this.goodsname = new System.Windows.Forms.Label();
            this.goodscount = new System.Windows.Forms.Label();
            this.goodsprice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 35);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(771, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 35);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(219, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 35);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(771, 275);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(253, 35);
            this.textBox4.TabIndex = 3;
            // 
            // goodsid
            // 
            this.goodsid.AutoSize = true;
            this.goodsid.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goodsid.Location = new System.Drawing.Point(83, 88);
            this.goodsid.Name = "goodsid";
            this.goodsid.Size = new System.Drawing.Size(86, 24);
            this.goodsid.TabIndex = 6;
            this.goodsid.Text = "商品ID";
            // 
            // goodsname
            // 
            this.goodsname.AutoSize = true;
            this.goodsname.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goodsname.Location = new System.Drawing.Point(645, 88);
            this.goodsname.Name = "goodsname";
            this.goodsname.Size = new System.Drawing.Size(110, 24);
            this.goodsname.TabIndex = 7;
            this.goodsname.Text = "商品名称";
            // 
            // goodscount
            // 
            this.goodscount.AutoSize = true;
            this.goodscount.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goodscount.Location = new System.Drawing.Point(83, 286);
            this.goodscount.Name = "goodscount";
            this.goodscount.Size = new System.Drawing.Size(110, 24);
            this.goodscount.TabIndex = 8;
            this.goodscount.Text = "商品数量";
            // 
            // goodsprice
            // 
            this.goodsprice.AutoSize = true;
            this.goodsprice.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goodsprice.Location = new System.Drawing.Point(645, 285);
            this.goodsprice.Name = "goodsprice";
            this.goodsprice.Size = new System.Drawing.Size(110, 24);
            this.goodsprice.TabIndex = 9;
            this.goodsprice.Text = "商品价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(87, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "照片ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(649, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 479);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 32);
            this.comboBox1.TabIndex = 13;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 632);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.goodsprice);
            this.Controls.Add(this.goodscount);
            this.Controls.Add(this.goodsname);
            this.Controls.Add(this.goodsid);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label goodsid;
        private System.Windows.Forms.Label goodsname;
        private System.Windows.Forms.Label goodscount;
        private System.Windows.Forms.Label goodsprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}