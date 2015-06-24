namespace lab7
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SellInfoInsertBtn = new System.Windows.Forms.Button();
            this.StoreInfoInsertBtn = new System.Windows.Forms.Button();
            this.StaffInfoInsertBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InventorySelectBtn = new System.Windows.Forms.Button();
            this.GoodsInfoActBtn = new System.Windows.Forms.Button();
            this.SellInfoActBtn = new System.Windows.Forms.Button();
            this.StoreInfoActBtn = new System.Windows.Forms.Button();
            this.StaffInfoActBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.securityLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SellInfoInsertBtn);
            this.groupBox1.Controls.Add(this.StoreInfoInsertBtn);
            this.groupBox1.Controls.Add(this.StaffInfoInsertBtn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(338, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(606, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息录入";
            // 
            // SellInfoInsertBtn
            // 
            this.SellInfoInsertBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SellInfoInsertBtn.Location = new System.Drawing.Point(48, 222);
            this.SellInfoInsertBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SellInfoInsertBtn.Name = "SellInfoInsertBtn";
            this.SellInfoInsertBtn.Size = new System.Drawing.Size(210, 76);
            this.SellInfoInsertBtn.TabIndex = 2;
            this.SellInfoInsertBtn.Text = "销售信息录入";
            this.SellInfoInsertBtn.UseVisualStyleBackColor = true;
            this.SellInfoInsertBtn.Click += new System.EventHandler(this.SellInfoInsertBtn_Click);
            // 
            // StoreInfoInsertBtn
            // 
            this.StoreInfoInsertBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoreInfoInsertBtn.Location = new System.Drawing.Point(330, 222);
            this.StoreInfoInsertBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StoreInfoInsertBtn.Name = "StoreInfoInsertBtn";
            this.StoreInfoInsertBtn.Size = new System.Drawing.Size(210, 76);
            this.StoreInfoInsertBtn.TabIndex = 1;
            this.StoreInfoInsertBtn.Text = "进货信息录入";
            this.StoreInfoInsertBtn.UseVisualStyleBackColor = true;
            this.StoreInfoInsertBtn.Click += new System.EventHandler(this.StoreInfoInsertBtn_Click);
            // 
            // StaffInfoInsertBtn
            // 
            this.StaffInfoInsertBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StaffInfoInsertBtn.Location = new System.Drawing.Point(48, 84);
            this.StaffInfoInsertBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StaffInfoInsertBtn.Name = "StaffInfoInsertBtn";
            this.StaffInfoInsertBtn.Size = new System.Drawing.Size(210, 76);
            this.StaffInfoInsertBtn.TabIndex = 0;
            this.StaffInfoInsertBtn.Text = "员工信息录入";
            this.StaffInfoInsertBtn.UseVisualStyleBackColor = true;
            this.StaffInfoInsertBtn.Click += new System.EventHandler(this.StaffInfoInsertBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InventorySelectBtn);
            this.groupBox2.Controls.Add(this.GoodsInfoActBtn);
            this.groupBox2.Controls.Add(this.SellInfoActBtn);
            this.groupBox2.Controls.Add(this.StoreInfoActBtn);
            this.groupBox2.Controls.Add(this.StaffInfoActBtn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(338, 368);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(606, 512);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询与管理";
            // 
            // InventorySelectBtn
            // 
            this.InventorySelectBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InventorySelectBtn.Location = new System.Drawing.Point(48, 72);
            this.InventorySelectBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.InventorySelectBtn.Name = "InventorySelectBtn";
            this.InventorySelectBtn.Size = new System.Drawing.Size(210, 76);
            this.InventorySelectBtn.TabIndex = 5;
            this.InventorySelectBtn.Text = "库存信息查询";
            this.InventorySelectBtn.UseVisualStyleBackColor = true;
            this.InventorySelectBtn.Click += new System.EventHandler(this.InventorySelectBtn_Click);
            // 
            // GoodsInfoActBtn
            // 
            this.GoodsInfoActBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoodsInfoActBtn.Location = new System.Drawing.Point(308, 354);
            this.GoodsInfoActBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GoodsInfoActBtn.Name = "GoodsInfoActBtn";
            this.GoodsInfoActBtn.Size = new System.Drawing.Size(210, 76);
            this.GoodsInfoActBtn.TabIndex = 4;
            this.GoodsInfoActBtn.Text = "商品信息管理";
            this.GoodsInfoActBtn.UseVisualStyleBackColor = true;
            this.GoodsInfoActBtn.Click += new System.EventHandler(this.GoodsInfoActBtn_Click);
            // 
            // SellInfoActBtn
            // 
            this.SellInfoActBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SellInfoActBtn.Location = new System.Drawing.Point(48, 354);
            this.SellInfoActBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SellInfoActBtn.Name = "SellInfoActBtn";
            this.SellInfoActBtn.Size = new System.Drawing.Size(210, 76);
            this.SellInfoActBtn.TabIndex = 3;
            this.SellInfoActBtn.Text = "销售信息管理";
            this.SellInfoActBtn.UseVisualStyleBackColor = true;
            this.SellInfoActBtn.Click += new System.EventHandler(this.SellInfoActBtn_Click);
            // 
            // StoreInfoActBtn
            // 
            this.StoreInfoActBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoreInfoActBtn.Location = new System.Drawing.Point(308, 204);
            this.StoreInfoActBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StoreInfoActBtn.Name = "StoreInfoActBtn";
            this.StoreInfoActBtn.Size = new System.Drawing.Size(210, 76);
            this.StoreInfoActBtn.TabIndex = 2;
            this.StoreInfoActBtn.Text = "进货信息管理";
            this.StoreInfoActBtn.UseVisualStyleBackColor = true;
            // 
            // StaffInfoActBtn
            // 
            this.StaffInfoActBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StaffInfoActBtn.Location = new System.Drawing.Point(48, 204);
            this.StaffInfoActBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StaffInfoActBtn.Name = "StaffInfoActBtn";
            this.StaffInfoActBtn.Size = new System.Drawing.Size(210, 76);
            this.StaffInfoActBtn.TabIndex = 1;
            this.StaffInfoActBtn.Text = "员工信息管理";
            this.StaffInfoActBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.securityLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.LogoutBtn);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.UserName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(24, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(302, 856);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // securityLabel
            // 
            this.securityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.securityLabel.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.securityLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.securityLabel.Location = new System.Drawing.Point(6, 466);
            this.securityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.securityLabel.Name = "securityLabel";
            this.securityLabel.Size = new System.Drawing.Size(264, 240);
            this.securityLabel.Location = new System.Drawing.Point(3, 233);
            this.securityLabel.Name = "securityLabel";
            this.securityLabel.Size = new System.Drawing.Size(132, 120);
            this.securityLabel.TabIndex = 9;
            this.securityLabel.Text = "对员工信息、销售信息、进货信息、商品信息、库存信息的查询权限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.label4.Location = new System.Drawing.Point(-2, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 36);

            this.label4.Location = new System.Drawing.Point(-1, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);

            this.label4.TabIndex = 7;
            this.label4.Text = "您的权限为:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(0, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "您好，";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogoutBtn.Location = new System.Drawing.Point(180, 758);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(96, 66);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "退出";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Location = new System.Drawing.Point(12, 84);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Size = new System.Drawing.Size(276, 218);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserName.Location = new System.Drawing.Point(112, 344);
            this.UserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(79, 36);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "先生";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "商品管理系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 904);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "商品信息管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SellInfoInsertBtn;
        private System.Windows.Forms.Button StoreInfoInsertBtn;
        private System.Windows.Forms.Button StaffInfoInsertBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button InventorySelectBtn;
        private System.Windows.Forms.Button GoodsInfoActBtn;
        private System.Windows.Forms.Button SellInfoActBtn;
        private System.Windows.Forms.Button StoreInfoActBtn;
        private System.Windows.Forms.Button StaffInfoActBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label securityLabel;
    }
}

