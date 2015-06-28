using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab7
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

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
            this.staffInfoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SellInfoInsertBtn = new System.Windows.Forms.Button();
            this.StoreInfoInsertBtn = new System.Windows.Forms.Button();
            this.StaffInfoInsertBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InventorySelectBtn = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.staffInfoBtn);
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
            // staffInfoBtn
            // 
            this.staffInfoBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.staffInfoBtn.Location = new System.Drawing.Point(165, 42);
            this.staffInfoBtn.Name = "staffInfoBtn";
            this.staffInfoBtn.Size = new System.Drawing.Size(105, 38);
            this.staffInfoBtn.TabIndex = 7;
            this.staffInfoBtn.Text = "员工信息录入";
            this.staffInfoBtn.UseVisualStyleBackColor = true;
            this.staffInfoBtn.Click += new System.EventHandler(this.staffInfoBtn_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(154, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "商品清单管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.SellInfoInsertBtn.Click += new System.EventHandler(this.SellInfoInsertBtn_Click);
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
            this.StoreInfoInsertBtn.Click += new System.EventHandler(this.StoreInfoInsertBtn_Click);
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
            this.StaffInfoInsertBtn.Click += new System.EventHandler(this.StaffInfoInsertBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InventorySelectBtn);
            this.groupBox2.Controls.Add(this.button1);
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
            this.InventorySelectBtn.Click += new System.EventHandler(this.InventorySelectBtn_Click);
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
            this.SellInfoActBtn.Click += new System.EventHandler(this.SellInfoActBtn_Click);
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
            this.groupBox3.Controls.Add(this.securityLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.LogoutBtn);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.UserName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 428);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // securityLabel
            // 
            this.securityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.securityLabel.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.securityLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.securityLabel.Location = new System.Drawing.Point(3, 236);
            this.securityLabel.Name = "securityLabel";
            this.securityLabel.Size = new System.Drawing.Size(132, 128);
            this.securityLabel.TabIndex = 9;
            this.securityLabel.Text = "对员工信息、销售信息、进货信息、商品信息、库存信息的查询权限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(2, 208);
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
            this.label1.Location = new System.Drawing.Point(0, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "您好，";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogoutBtn.Location = new System.Drawing.Point(90, 379);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(48, 33);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "退出";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Location = new System.Drawing.Point(6, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 109);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserName.Location = new System.Drawing.Point(56, 172);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(40, 18);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "先生";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(485, 447);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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

        /*private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button button1;*/
        private GroupBox groupBox1;
        private Button SellInfoInsertBtn;
        private Button StoreInfoInsertBtn;
        private Button StaffInfoInsertBtn;
        private GroupBox groupBox2;
        private Button InventorySelectBtn;
        private Button SellInfoActBtn;
        private Button StoreInfoActBtn;
        private Button StaffInfoActBtn;
        private GroupBox groupBox3;
        private Label label2;
        private GroupBox groupBox5;
        private Button LogoutBtn;
        private Label UserName;
        private Label label1;
        private Label label4;
        private Label securityLabel;
        private Button button1;
        private Button staffInfoBtn;
    }
}

