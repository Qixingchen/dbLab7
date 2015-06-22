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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.PwdEditBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(169, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息录入";
            // 
            // SellInfoInsertBtn
            // 
            this.SellInfoInsertBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SellInfoInsertBtn.Location = new System.Drawing.Point(24, 111);
            this.SellInfoInsertBtn.Name = "SellInfoInsertBtn";
            this.SellInfoInsertBtn.Size = new System.Drawing.Size(105, 38);
            this.SellInfoInsertBtn.TabIndex = 2;
            this.SellInfoInsertBtn.Text = "销售信息录入";
            this.SellInfoInsertBtn.UseVisualStyleBackColor = true;
            // 
            // StoreInfoInsertBtn
            // 
            this.StoreInfoInsertBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoreInfoInsertBtn.Location = new System.Drawing.Point(165, 111);
            this.StoreInfoInsertBtn.Name = "StoreInfoInsertBtn";
            this.StoreInfoInsertBtn.Size = new System.Drawing.Size(105, 38);
            this.StoreInfoInsertBtn.TabIndex = 1;
            this.StoreInfoInsertBtn.Text = "进货信息录入";
            this.StoreInfoInsertBtn.UseVisualStyleBackColor = true;
            // 
            // StaffInfoInsertBtn
            // 
            this.StaffInfoInsertBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StaffInfoInsertBtn.Location = new System.Drawing.Point(24, 42);
            this.StaffInfoInsertBtn.Name = "StaffInfoInsertBtn";
            this.StaffInfoInsertBtn.Size = new System.Drawing.Size(105, 38);
            this.StaffInfoInsertBtn.TabIndex = 0;
            this.StaffInfoInsertBtn.Text = "员工信息录入";
            this.StaffInfoInsertBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InventorySelectBtn);
            this.groupBox2.Controls.Add(this.GoodsInfoActBtn);
            this.groupBox2.Controls.Add(this.SellInfoActBtn);
            this.groupBox2.Controls.Add(this.StoreInfoActBtn);
            this.groupBox2.Controls.Add(this.StaffInfoActBtn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(169, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询与管理";
            // 
            // InventorySelectBtn
            // 
            this.InventorySelectBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InventorySelectBtn.Location = new System.Drawing.Point(24, 36);
            this.InventorySelectBtn.Name = "InventorySelectBtn";
            this.InventorySelectBtn.Size = new System.Drawing.Size(105, 38);
            this.InventorySelectBtn.TabIndex = 5;
            this.InventorySelectBtn.Text = "库存信息查询";
            this.InventorySelectBtn.UseVisualStyleBackColor = true;
            // 
            // GoodsInfoActBtn
            // 
            this.GoodsInfoActBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoodsInfoActBtn.Location = new System.Drawing.Point(154, 177);
            this.GoodsInfoActBtn.Name = "GoodsInfoActBtn";
            this.GoodsInfoActBtn.Size = new System.Drawing.Size(105, 38);
            this.GoodsInfoActBtn.TabIndex = 4;
            this.GoodsInfoActBtn.Text = "商品信息管理";
            this.GoodsInfoActBtn.UseVisualStyleBackColor = true;
            // 
            // SellInfoActBtn
            // 
            this.SellInfoActBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SellInfoActBtn.Location = new System.Drawing.Point(24, 177);
            this.SellInfoActBtn.Name = "SellInfoActBtn";
            this.SellInfoActBtn.Size = new System.Drawing.Size(105, 38);
            this.SellInfoActBtn.TabIndex = 3;
            this.SellInfoActBtn.Text = "销售信息管理";
            this.SellInfoActBtn.UseVisualStyleBackColor = true;
            // 
            // StoreInfoActBtn
            // 
            this.StoreInfoActBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoreInfoActBtn.Location = new System.Drawing.Point(154, 102);
            this.StoreInfoActBtn.Name = "StoreInfoActBtn";
            this.StoreInfoActBtn.Size = new System.Drawing.Size(105, 38);
            this.StoreInfoActBtn.TabIndex = 2;
            this.StoreInfoActBtn.Text = "进货信息管理";
            this.StoreInfoActBtn.UseVisualStyleBackColor = true;
            // 
            // StaffInfoActBtn
            // 
            this.StaffInfoActBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StaffInfoActBtn.Location = new System.Drawing.Point(24, 102);
            this.StaffInfoActBtn.Name = "StaffInfoActBtn";
            this.StaffInfoActBtn.Size = new System.Drawing.Size(105, 38);
            this.StaffInfoActBtn.TabIndex = 1;
            this.StaffInfoActBtn.Text = "员工信息管理";
            this.StaffInfoActBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LogoutBtn);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.PwdEditBtn);
            this.groupBox3.Controls.Add(this.UserName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 428);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "商品管理系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBox5
            // 
            //this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Location = new System.Drawing.Point(6, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 109);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "您好,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserName.Location = new System.Drawing.Point(60, 172);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(40, 18);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "先生";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // PwdEditBtn
            // 
            this.PwdEditBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PwdEditBtn.Location = new System.Drawing.Point(10, 209);
            this.PwdEditBtn.Name = "PwdEditBtn";
            this.PwdEditBtn.Size = new System.Drawing.Size(48, 33);
            this.PwdEditBtn.TabIndex = 2;
            this.PwdEditBtn.Text = "密码";
            this.PwdEditBtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogoutBtn.Location = new System.Drawing.Point(75, 209);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(48, 33);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "退出";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "商品信息管理系统";
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
        private System.Windows.Forms.Button PwdEditBtn;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label1;
    }
}

