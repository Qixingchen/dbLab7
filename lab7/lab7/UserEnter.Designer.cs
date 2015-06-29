using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab7
{
    partial class UserEnter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gender_text = new System.Windows.Forms.ComboBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.age_text = new System.Windows.Forms.TextBox();
            this.commitBtn = new System.Windows.Forms.Button();
            this.staffType_text = new System.Windows.Forms.ComboBox();
            this.id_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(266, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(266, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "员工年龄";
            // 
            // gender_text
            // 
            this.gender_text.FormattingEnabled = true;
            this.gender_text.Items.AddRange(new object[] {
            "男",
            "女"});
            this.gender_text.Location = new System.Drawing.Point(105, 144);
            this.gender_text.Name = "gender_text";
            this.gender_text.Size = new System.Drawing.Size(100, 20);
            this.gender_text.TabIndex = 4;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(341, 27);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(100, 21);
            this.name_text.TabIndex = 6;
            // 
            // age_text
            // 
            this.age_text.Location = new System.Drawing.Point(341, 143);
            this.age_text.Name = "age_text";
            this.age_text.Size = new System.Drawing.Size(100, 21);
            this.age_text.TabIndex = 7;
            // 
            // commitBtn
            // 
            this.commitBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commitBtn.Location = new System.Drawing.Point(200, 211);
            this.commitBtn.Name = "commitBtn";
            this.commitBtn.Size = new System.Drawing.Size(75, 23);
            this.commitBtn.TabIndex = 8;
            this.commitBtn.Text = "录入";
            this.commitBtn.UseVisualStyleBackColor = true;
            this.commitBtn.Click += new System.EventHandler(this.commitBtn_Click);
            // 
            // staffType_text
            // 
            this.staffType_text.FormattingEnabled = true;
            this.staffType_text.Location = new System.Drawing.Point(105, 75);
            this.staffType_text.Name = "staffType_text";
            this.staffType_text.Size = new System.Drawing.Size(100, 20);
            this.staffType_text.TabIndex = 9;
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(111, 27);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(100, 21);
            this.id_text.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(36, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "员工ID";
            // 
            // UserEnter
            // 
            this.ClientSize = new System.Drawing.Size(499, 269);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.staffType_text);
            this.Controls.Add(this.commitBtn);
            this.Controls.Add(this.age_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.gender_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserEnter";
            this.Text = "UserEnter";
            this.Load += new System.EventHandler(this.On_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox gender_text;
        private TextBox name_text;
        private TextBox age_text;
        private Button commitBtn;
        private ComboBox staffType_text;
        private TextBox id_text;
        private Label label5;

    }
}

